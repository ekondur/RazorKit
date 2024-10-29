using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace RazorKit.Chart.Converters
{
    internal class DictionaryAsPropertiesConverter<T> : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(Dictionary<string, T>);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var dictionary = (Dictionary<string, T>)value;

            writer.WriteStartObject();
            foreach (var kvp in dictionary)
            {
                writer.WritePropertyName(kvp.Key);

                if (kvp.Value is T)
                {
                    // Handle serialization for known types like int, string, and T
                    serializer.Serialize(writer, kvp.Value);
                }
            }
            writer.WriteEndObject();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var dictionary = new Dictionary<string, object>();

            while (reader.Read())
            {
                if (reader.TokenType == JsonToken.PropertyName)
                {
                    var propertyName = reader.Value.ToString();
                    reader.Read(); // Move to the value

                    if (reader.TokenType == JsonToken.Integer)
                    {
                        dictionary[propertyName] = Convert.ToInt32(reader.Value);
                    }
                    else if (reader.TokenType == JsonToken.String)
                    {
                        dictionary[propertyName] = reader.Value.ToString();
                    }
                    else if (reader.TokenType == JsonToken.StartObject)
                    {
                        // Assuming it's a T object, deserialize it
                        dictionary[propertyName] = serializer.Deserialize<T>(reader);
                    }
                    else
                    {
                        dictionary[propertyName] = serializer.Deserialize<object>(reader);
                    }
                }
                else if (reader.TokenType == JsonToken.EndObject)
                {
                    return dictionary;
                }
            }

            throw new JsonSerializationException("Unexpected end of object");
        }
    }
}
