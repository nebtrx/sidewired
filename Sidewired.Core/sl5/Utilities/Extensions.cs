using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Serialization;
using Sidewired.Core.Domain;
using Sidewired.Core.Interfaces;

namespace Sidewired.Core.Utilities
{
    public static class Extensions
    {
        /// <summary>
        /// Creates an <see cref="ObservableCollection{TOut}"/> from the target <see cref="List{TIn}"/> to be used as concrete collection in Type deserialization involving interfaces. The <see cref="ObservableCollection{TOut}"/> acts as a mediator and passes every added item to the target collection properly converted through an event handler hook on <see cref="ObservableCollection{T}.CollectionChanged"/> event.
        /// </summary>
        /// <param name="collectionToSerialize">Target <see cref="List{TIn}"/>.</param>
        /// <typeparam name="TIn">Home target type.</typeparam>
        /// <typeparam name="TOut">Away type to be deserialized.</typeparam>
        /// <returns><see cref="ObservableCollection{TOut}"/> with a event handler for passing every added item to the target <see cref="List{TIn}"/>.</returns>
        public static ObservableCollection<TOut> SerializableCollectionFor<TIn, TOut>(this List<TIn> collectionToSerialize)
        {
            var outputCollection = new ObservableCollection<TOut>(collectionToSerialize.Cast<TOut>());
            outputCollection.CollectionChanged += (sender, args) =>
            {
                if (args.NewItems != null && args.Action == NotifyCollectionChangedAction.Add)
                {
                    collectionToSerialize.AddRange(from object item in args.NewItems select (TIn)item);
                }
            };
            return outputCollection;
        }

        /// <summary>
        /// Returns the content store in current <see cref="MemoryStream"/> Object as a <see cref="string"/> UTF8 encoded.
        /// </summary>
        /// <remarks>
        /// This method escapes some characters converting them in specials <see cref="char"/> sequences.
        /// The process wil be later reversed by <see cref="AsStream"/>.
        /// </remarks>
        /// <param name="stream">Current <see cref="MemoryStream"/> Object.</param>
        /// <returns><see cref="MemoryStream"/> content as <see cref="string"/> UTF8 encoded.</returns>
        public static string AsString(this MemoryStream stream)
        {
            var content = stream.ToArray();
            // se escapan las comas
            return Encoding.UTF8.GetString(content, 0, content.Length).Replace(",", @"\#'");
        }

        /// <summary>
        /// Returns the string resulted of serializing current <see cref="IPlayerSettings"/> Object with an <see cref="XmlSerializer"/> instance.
        /// </summary>
        /// <param name="silverlightMediaJackSettings">Current <see cref="IPlayerSettings"/> instance.</param>
        /// <returns>Xml serialized object.</returns>
        public static string AsXmlSerializedString(this IPlayerSettings silverlightMediaJackSettings)
        {
            // avoiding namespaces in the result xml
            var xmlSerializerNamespaces = new XmlSerializerNamespaces();
            xmlSerializerNamespaces.Add(String.Empty, String.Empty);

            var serializer = new XmlSerializer(typeof(PlayerSettings));
            var stream = new MemoryStream();
            serializer.Serialize(stream, silverlightMediaJackSettings, xmlSerializerNamespaces);
            return CleanXmlString(stream.AsString());
        }

        /// <summary>
        /// Cleans of not desired information, such as namespaces, the serialized string received.
        /// </summary>
        /// <param name="xml">Serialized string.</param>
        /// <returns>Serialized string free of not desired information.</returns>
        private static string CleanXmlString(string xml)
        {
            const string xmlVersionRegex = @"(?'xmlversion'<\?xml version=.*\?>)";
            // eliminando <?xml version="1.0"?>
            var cleanXml = Regex.Replace(xml, xmlVersionRegex, "");

            // No need to avoid namespaces, now they are prevented

            //var namespacesRegex = @"<(?'tag'" + typeof(PlayerSettings).Name + ")(?'ns'.*)>";
            //// eliminando <PlayerSettings xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
            //cleanXml = Regex.Replace(cleanXml, namespacesRegex, "<" + typeof(PlayerSettings).Name + ">");
            return cleanXml;
        }

        /// <summary>
        /// Returns an instance of <see cref="MemoryStream"/> class storing the current <see cref="string"/> object.
        /// </summary>
        /// <remarks>
        /// This method reverts the escaping of some characters realized in <see cref="AsString(System.IO.MemoryStream)"/>.
        /// </remarks>
        /// <param name="string">Current <see cref="string"/> Object.</param>
        /// <returns><see cref="MemoryStream"/> instance storing <see cref="string"/> Object.</returns>
        public static MemoryStream AsStream(this string @string)
        {
            var stream = new MemoryStream();
            var writer = new StreamWriter(stream);
            writer.Write(@string.Replace(@"\#'", ","));
            writer.Flush();
            stream.Position = 0;
            return stream;
        }

        /// <summary>
        /// Converts the current <see cref="string"/> value to a <see cref="Uri"/> equivalent.
        /// </summary>
        /// <param name="string">Current <see cref="string"/> value.</param>
        /// <returns><see cref="Uri"/> instance created from current<see cref="string"/> value. If the <see cref="string"/> value doesn't correspond with an <see cref="Uri"/> it returns null.</returns>
        public static Uri AsUri(this string @string)
        {
            Uri result;
            return Uri.TryCreate(@string, UriKind.RelativeOrAbsolute, out result) ? result : null;
        }

        /// <summary>
        /// Converts the current <see cref="String"/> value to a <see cref="TimeSpan"/> equivalent.
        /// </summary>
        /// <param name="string">Current <see cref="string"/> value. <exception cref="BadImageFormatException">If the <see cref="string"/> value doesn't have a<see cref="TimeSpan"/> equivalent.</exception></param>
        /// <returns><see cref="TimeSpan"/> instance created from current  <see cref="string"/> value.</returns>
        public static TimeSpan AsTimeSpan(this string @string)
        {
            return XmlConvert.ToTimeSpan(@string);
        }

        /// <summary>
        /// Converts the current <see cref="TimeSpan"/> value to a <see cref="string"/> equivalent.
        /// </summary>
        /// <param name="timeSpan">Current <see cref="TimeSpan"/> value.</param>
        /// <returns>Equivalent <see cref="string"/> value.</returns>
        public static string AsString(this TimeSpan timeSpan)
        {
            return XmlConvert.ToString(timeSpan);
        }

        /// <summary>
        /// Converts the current <see cref="TimeSpan"/> value to a <see cref="string"/> equivalent.
        /// </summary>
        /// <param name="timeSpan">Current <see cref="TimeSpan"/> value.</param>
        /// <returns>Equivalent <see cref="string"/> value.</returns>
        public static string AsString(this TimeSpan? timeSpan)
        {
            return timeSpan != null ? XmlConvert.ToString((TimeSpan)timeSpan) : null;
        }

        /// <summary>
        /// Determines if the given <see cref="Uri"/> value is null or contains and empty reference.
        /// </summary>
        /// <param name="uri">Caller <see cref="Uri"/> value</param>
        /// <returns>True if it's null or contains and empty reference.</returns>
        public static bool IsNullOrEmpty(this Uri uri)
        {
            return uri == null || String.IsNullOrEmpty(uri.ToString());
        }

        /// <summary>
        /// Converts the caller <see cref="Uri"/> instance to a <see cref="string"/> equivalent.
        /// </summary>
        /// <param name="uri">Caller <see cref="Uri"/> instance.</param>
        /// <returns>Equivalent <see cref="string"/> value. If the caller <see cref="Uri"/> instance if null return an empty string.</returns>
        public static string AsString(this Uri uri)
        {
            return uri != (Uri)null ? uri.ToString() : string.Empty;
        }
    }
}
