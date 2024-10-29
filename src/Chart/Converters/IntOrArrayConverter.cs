using Newtonsoft.Json;
using System;

namespace RazorKit.Chart.Converters
{
    internal class IntOrArrayConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            // You can add logic here to restrict the types that are handled by this converter
            return objectType == typeof(object);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value is int[] intArray)
            {
                // Serialize int array
                writer.WriteStartArray();
                foreach (var str in intArray)
                {
                    writer.WriteValue(str);
                }
                writer.WriteEndArray();
            }
            else if (value is int intValue)
            {
                // Serialize single int
                writer.WriteValue(intValue);
            }
            else
            {
                // Serialize as int
                writer.WriteValue(value);
            }
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            // Deserialization logic (optional, if you need deserialization)
            if (reader.TokenType == JsonToken.Integer)
            {
                return Convert.ToInt32(reader.Value);
            }
            else if (reader.TokenType == JsonToken.StartArray)
            {
                var values = new System.Collections.Generic.List<int>();
                while (reader.Read() && reader.TokenType != JsonToken.EndArray)
                {
                    values.Add(Convert.ToInt32(reader.Value));
                }
                return values.ToArray();
            }
            return null;
        }
    }
}
