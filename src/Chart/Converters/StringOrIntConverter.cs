using Newtonsoft.Json;
using System;

namespace HelperJS.Chart.Converters
{
    internal class StringOrIntConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(object);  // It allows both int and string
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value is int intValue)
            {
                writer.WriteValue(intValue);
            }
            else if (value is string stringValue)
            {
                writer.WriteValue(stringValue);
            }
            else
            {
                throw new JsonSerializationException("Unsupported type");
            }
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Integer)
            {
                return Convert.ToInt32(reader.Value);
            }
            else if (reader.TokenType == JsonToken.String)
            {
                return reader.Value.ToString();
            }

            throw new JsonSerializationException("Unexpected token type");
        }
    }
}
