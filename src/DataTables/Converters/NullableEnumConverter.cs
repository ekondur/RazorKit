using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

internal class NullableEnumConverter<T> : JsonConverter where T : Enum
{
    private readonly T _nullValue;

    public NullableEnumConverter(T specificValue)
    {
        _nullValue = specificValue;
    }

    public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
    {
        if (value.Equals(_nullValue))
        {
            writer.WriteRawValue("null");
        }
        else
        {
            var stringEnumConverter = new StringEnumConverter();
            stringEnumConverter.WriteJson(writer, value, serializer);
        }
    }

    public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
    {
        return Enum.Parse(typeof(T), reader.Value.ToString());
    }

    public override bool CanConvert(Type objectType)
    {
        return objectType == typeof(T);
    }
}
