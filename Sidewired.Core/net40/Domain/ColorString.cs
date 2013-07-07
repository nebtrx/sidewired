using System;
using System.Drawing;
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
                return (Color) colorConverter.ConvertFromString(colorString);
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
        /// <filterpriority>2</filterpriority>
        public override string ToString()
        {
            return "#" + _value.A.ToString("X2") + _value.R.ToString("X2") + _value.G.ToString("X2") + _value.B.ToString("X2");
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
        /// This method is reserved and should not be used. When implementing the IXmlSerializable interface, you should return null (Nothing in Visual Basic) from this method, and instead, if specifying a custom schema is required, apply the <see cref="T:System.Xml.Serialization.XmlSchemaProviderAttribute"/> to the class.
        /// </summary>
        /// <returns>
        /// An <see cref="T:System.Xml.Schema.XmlSchema"/> that describes the XML representation of the object that is produced by the <see cref="M:System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter)"/> method and consumed by the <see cref="M:System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader)"/> method.
        /// </returns>
        public XmlSchema GetSchema()
        {
            return null;
        }

        /// <summary>
        /// Generates an object from its XML representation.
        /// </summary>
        /// <param name="reader">The <see cref="T:System.Xml.XmlReader"/> stream from which the object is deserialized. </param>
        public void ReadXml(XmlReader reader)
        {
            var value = reader.ReadElementContentAsString();
            _value = ConvertToColor(string.IsNullOrEmpty(value) ? "#00000000" : value);
        }

        /// <summary>
        /// Converts an object into its XML representation.
        /// </summary>
        /// <param name="writer">The <see cref="T:System.Xml.XmlWriter"/> stream to which the object is serialized. </param>
        public void WriteXml(XmlWriter writer)
        {
            writer.WriteValue(ToString());
        }
    }
}
