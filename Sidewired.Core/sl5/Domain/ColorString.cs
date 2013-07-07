using System;
using System.Windows.Media;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using Newtonsoft.Json;
using Sidewired.Core.Serialization;

namespace Sidewired.Core.Domain
{
    /// <summary>
    /// Light wrapper used to convert colors to hex strings and viceversa. Also provides serialization support based on the resulted hex string.
    /// </summary>
    [JsonConverter(typeof(ColorStringConverter))]
    public struct ColorString : IXmlSerializable
    {
        private Color _value;

        private Color ConvertToColor(string colorString)
        {
            try
            {
                var colorConverter = new ColorConverter();
                return colorConverter.ConvertFromString(colorString);
            }
            catch (Exception)
            {
                throw new InvalidCastException("String provided is not in a recognized Hex format.");
            }
        }

        /// <summary>
        /// Returns the fully qualified type name of this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.String"/> containing a fully qualified type name.
        /// </returns>
        public override string ToString()
        {
            return _value.ToString();
        }

        public ColorString(string colorString = "#00000000") : this()
        {
            _value = ConvertToColor(colorString);
        }

        public static implicit operator ColorString(Color value)
        {
            return new ColorString { _value = value };
        }

        public static implicit operator ColorString?(Color? value)
        {
            return new ColorString { _value = value ?? new Color() };
        }

        public static implicit operator Color(ColorString value)
        {
            return value._value;
        }

        public static implicit operator String(ColorString value)
        {
            return value.ToString();
        }

        public static implicit operator ColorString(String value)
        {
            return new ColorString(value);
        }

        public static implicit operator Color?(ColorString value)
        {
            return value._value;
        }

        public static implicit operator ColorString?(Color value)
        {
            return new ColorString {_value = value};
        }

        /// <summary>
        /// This method is reserved and should not be used. When implementing the <see cref="T:System.Xml.Serialization.IXmlSerializable"/> interface, you should return a null reference (Nothing in Visual Basic) from this method.
        /// </summary>
        /// <returns>
        /// An <see cref="T:System.Xml.Schema.XmlSchema"/> that describes the XML representation of the object that is produced by the <see cref="M:System.Xml.Serialization.IXmlSerializable.WriteXml"/> method and consumed by the <see cref="M:System.Xml.Serialization.IXmlSerializable.ReadXml"/> method.
        /// </returns>
        public XmlSchema GetSchema()
        {
            return null;
        }

        /// <summary>
        /// Generates an object from its XML representation.
        /// </summary>
        /// <param name="reader">The <see cref="T:System.Xml.XmlReader"/> stream from which the object is deserialized.</param>
        public void ReadXml(XmlReader reader)
        {
            var value = reader.ReadElementContentAsString();
            _value = ConvertToColor(string.IsNullOrEmpty(value) ? "#00000000" : value);
        }

        /// <summary>
        /// Converts an object into its XML representation.
        /// </summary>
        /// <param name="writer">The <see cref="T:System.Xml.XmlWriter"/> stream to which the object is serialized.</param>
        public void WriteXml(XmlWriter writer)
        {
            writer.WriteValue(ToString());
        }

        private class ColorConverter
        {
            public Color ConvertFromString(string hexColor)
            {
                if (string.IsNullOrEmpty(hexColor))
                {
                    throw new ArgumentNullException("hexColor");
                }

                // remove any "#" characters
                while (hexColor.StartsWith("#"))
                {
                    hexColor = hexColor.Substring(1);
                }

                int num = 0;
                // get the number out of the string 
                if (!Int32.TryParse(hexColor, System.Globalization.NumberStyles.HexNumber, null, out num))
                {
                    throw new ArgumentOutOfRangeException("hexColor");
                }

                int[] pieces = new int[4];
                if (hexColor.Length > 7)
                {
                    pieces[0] = ((num >> 24) & 0x000000ff);
                    pieces[1] = ((num >> 16) & 0x000000ff);
                    pieces[2] = ((num >> 8) & 0x000000ff);
                    pieces[3] = (num & 0x000000ff);
                }
                else if (hexColor.Length > 5)
                {
                    pieces[0] = 255;
                    pieces[1] = ((num >> 16) & 0x000000ff);
                    pieces[2] = ((num >> 8) & 0x000000ff);
                    pieces[3] = (num & 0x000000ff);
                }
                else if (hexColor.Length == 3)
                {
                    pieces[0] = 255;
                    pieces[1] = ((num >> 8) & 0x0000000f);
                    pieces[1] += pieces[1] * 16;
                    pieces[2] = ((num >> 4) & 0x000000f);
                    pieces[2] += pieces[2] * 16;
                    pieces[3] = (num & 0x000000f);
                    pieces[3] += pieces[3] * 16;
                }
                return Color.FromArgb((byte)pieces[0], (byte)pieces[1], (byte)pieces[2], (byte)pieces[3]);
            }
        }
    }
}
