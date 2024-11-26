using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace RazorKit.ChartJs.Converters
{
    internal class EnumOrTypeConverter<TEnum> : JsonConverter where TEnum : struct, Enum
    {
        public override bool CanConvert(Type objectType)
        {
            // Define what types the converter can handle (e.g., only string or bool)
            return objectType == typeof(string) ||
                objectType == typeof(bool) ||
                objectType == typeof(int) ||
                objectType == typeof(TEnum);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value is Enum e)
            {
                // Use StringEnumConverter to serialize the enum
                var stringEnumConverter = new StringEnumConverter();
                stringEnumConverter.WriteJson(writer, e, serializer);
            }
            if (value is string s)
            {
                writer.WriteValue(s);  // Serialize as string
            }
            else if (value is bool b)
            {
                writer.WriteValue(b);    // Serialize as bool
            }
            else if (value is int i)
            {
                writer.WriteValue(i);    // Serialize as int
            }
            else
            {
                throw new JsonSerializationException("Unexpected value type");
            }
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            // Read the JSON value and determine if it should be a string or a bool
            if (reader.TokenType == JsonToken.String)
            {
                return reader.Value.ToString();
            }
            else if (reader.TokenType == JsonToken.Boolean)
            {
                return Convert.ToBoolean(reader.Value);
            }
            else if (reader.TokenType == JsonToken.Integer)
            {
                return Convert.ToInt32(reader.Value);
            }
            else if (reader.TokenType == JsonToken.String && Enum.TryParse<TEnum>(reader.Value.ToString(), out var enumValue))
            {
                return enumValue;
            }

            throw new JsonSerializationException("Unexpected token type");
        }

    }
}
