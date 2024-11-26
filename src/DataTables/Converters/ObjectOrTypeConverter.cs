using Newtonsoft.Json;
using System;

namespace RazorKit.DataTables.Converters
{
    internal class ObjectOrTypeConverter<T> : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(T) || objectType == typeof(bool) || objectType == typeof(int) || objectType == typeof(string);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Boolean)
            {
                return (bool)reader.Value;
            }
            else if (reader.TokenType == JsonToken.Integer)
            {
                return (int)reader.Value;
            }
            else if (reader.TokenType == JsonToken.String)
            {
                return reader.Value.ToString();
            }
            else if (reader.TokenType == JsonToken.StartObject)
            {
                return serializer.Deserialize<T>(reader);
            }

            throw new JsonSerializationException($"Unexpected token {reader.TokenType} when parsing.");
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value is bool boolValue)
            {
                writer.WriteValue(boolValue);
            }
            else if (value is int intValue)
            {
                writer.WriteValue(intValue);
            }
            else if (value is string strValue)
            {
                writer.WriteValue(strValue);
            }
            else if (value is T tValue)
            {
                serializer.Serialize(writer, tValue);
            }
            else
            {
                throw new JsonSerializationException("Unexpected value type.");
            }
        }
    }
}
