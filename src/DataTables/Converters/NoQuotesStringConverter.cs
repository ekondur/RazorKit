using Newtonsoft.Json;
using System;

namespace RazorKit.DataTables.Converters
{
    internal class NoQuotesStringConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(string);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            // Write the string value without quotes
            writer.WriteRawValue(value.ToString());
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            // Read the string value as usual
            return reader.Value?.ToString();
        }
    }
}
