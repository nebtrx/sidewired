using System;
using Newtonsoft.Json;
using Sidewired.Core.Domain;

namespace Sidewired.Core.Serialization
{
    public class ColorStringConverter : JsonConverter
    {
        #region Overrides of JsonConverter

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var colorStringObject = value is ColorString ? (ColorString)value : new ColorString();
            serializer.Serialize(writer, colorStringObject.ToString());
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            return new ColorString(reader.Value as string);
        }

        public override bool CanConvert(Type objectType)
        {
            return typeof(ColorString).IsAssignableFrom(objectType);
        }

        #endregion
    }
}
