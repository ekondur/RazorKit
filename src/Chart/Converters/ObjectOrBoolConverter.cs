using Newtonsoft.Json;
using System;

namespace HelperJS.Chart.Converters
{
    internal class ObjectOrBoolConverter<T> : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            // Can convert if the type is either T or bool
            return objectType == typeof(T) || objectType == typeof(bool);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            // If the JSON token is boolean, return the boolean value
            if (reader.TokenType == JsonToken.Boolean)
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
            // Write the value as boolean if it is a bool
            if (value is bool boolValue)
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
