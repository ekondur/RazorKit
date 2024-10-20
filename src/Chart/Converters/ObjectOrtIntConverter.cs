using Newtonsoft.Json;
using System;

namespace HelperJS.Chart.Converters
{
    internal class ObjectOrtIntConverter<T> : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            // Can convert if the type is either T or bool
            return objectType == typeof(T) || objectType == typeof(int);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            // If the JSON token is integer, return the integer value
            if (reader.TokenType == JsonToken.Integer)
            {
                return (bool)reader.Value;
            }

            // Otherwise, deserialize as type T
            if (reader.TokenType == JsonToken.String || reader.TokenType == JsonToken.StartObject)
            {
                return serializer.Deserialize<T>(reader);
            }

            throw new JsonSerializationException($"Unexpected token {reader.TokenType} when parsing.");
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            // Write the value as integer if it is a integer
            if (value is int boolValue)
            {
                writer.WriteValue(boolValue);
            }
            // Otherwise, serialize it as type T
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
