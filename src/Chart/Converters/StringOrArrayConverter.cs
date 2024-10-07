using Newtonsoft.Json;
using System;

namespace HelperJS.Chart.Converters
{
    internal class StringOrArrayConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            // You can add logic here to restrict the types that are handled by this converter
            return objectType == typeof(object);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value is string[] stringArray)
            {
                // Serialize string array
                writer.WriteStartArray();
                foreach (var str in stringArray)
                {
                    writer.WriteValue(str);
                }
                writer.WriteEndArray();
            }
            else if (value is string strValue)
            {
                // Serialize single string
                writer.WriteValue(strValue);
            }
            else
            {
                // Serialize as string
                writer.WriteValue(value?.ToString());
            }
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            // Deserialization logic (optional, if you need deserialization)
            if (reader.TokenType == JsonToken.String)
            {
                return reader.Value.ToString();
            }
            else if (reader.TokenType == JsonToken.StartArray)
            {
                var values = new System.Collections.Generic.List<string>();
                while (reader.Read() && reader.TokenType != JsonToken.EndArray)
                {
                    values.Add(reader.Value.ToString());
                }
                return values.ToArray();
            }
            return null;
        }
    }
}
