using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace HelperJS.Chart.Converters
{
    internal class EnumOrBoolConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            // Define what types the converter can handle (e.g., only string or bool)
            return objectType == typeof(Enum) || objectType == typeof(bool);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value is Enum v)
            {
                // Use StringEnumConverter to serialize the enum
                var stringEnumConverter = new StringEnumConverter();
                stringEnumConverter.WriteJson(writer, v, serializer);
            }
            else if (value is bool b)
            {
                writer.WriteValue(b);    // Serialize as bool
            }
            else
            {
                throw new JsonSerializationException("Unexpected value type");
            }
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            // Read the JSON value and determine if it should be a string or a bool
            if (reader.TokenType == JsonToken.StartObject)
            {
                return reader.Value.ToString();
            }
            else if (reader.TokenType == JsonToken.Boolean)
            {
                return Convert.ToBoolean(reader.Value);
            }

            throw new JsonSerializationException("Unexpected token type");
        }
    }
}
