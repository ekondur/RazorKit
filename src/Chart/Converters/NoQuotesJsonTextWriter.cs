using Newtonsoft.Json;
using System.IO;

namespace RazorKit.Chart.Converters
{
    internal class NoQuotesJsonTextWriter : JsonTextWriter
    {
        public NoQuotesJsonTextWriter(TextWriter writer) : base(writer)
        {
        }

        public override void WritePropertyName(string name)
        {
            base.WriteRawValue(name); // Write without quotes
        }
    }
}
