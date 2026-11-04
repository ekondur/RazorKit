using System;
using Newtonsoft.Json;

namespace RazorKit.TomSelect
{
    /// <summary>An explicitly trusted JavaScript expression (function, reference, or regular expression).</summary>
    [JsonConverter(typeof(JavaScriptConverter))]
    public sealed class JavaScript
    {
        /// <summary>Creates an expression. Never pass user input as executable JavaScript.</summary>
        public JavaScript(string expression)
        {
            if (string.IsNullOrWhiteSpace(expression)) throw new ArgumentException("An expression is required.", nameof(expression));
            // Raw code must not terminate the surrounding HTML script element.
            if (expression.IndexOf("</script", StringComparison.OrdinalIgnoreCase) >= 0 ||
                expression.IndexOf("<!--", StringComparison.Ordinal) >= 0)
                throw new ArgumentException("Escape HTML script delimiters in JavaScript expressions.", nameof(expression));
            Expression = expression;
        }

        /// <summary>The trusted expression.</summary>
        public string Expression { get; }
    }

    internal sealed class JavaScriptConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType) => objectType == typeof(JavaScript);
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) => writer.WriteRawValue(((JavaScript)value).Expression);
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) => throw new NotSupportedException();
        public override bool CanRead => false;
    }

    internal static class ScriptJson
    {
        internal static string Serialize(object value) => JsonConvert.SerializeObject(value, new JsonSerializerSettings
        {
            StringEscapeHandling = StringEscapeHandling.EscapeHtml
        });
    }
}
