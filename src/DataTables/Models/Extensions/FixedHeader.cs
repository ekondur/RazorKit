using Newtonsoft.Json;
using RazorKit.DataTables.Converters;

namespace RazorKit.DataTables.Models
{
    internal class FixedHeader
    {
        public bool? Header { get; set; }
        public bool? Footer { get; set; }

        [JsonConverter(typeof(NoQuotesStringConverter))]
        public string HeaderOffset { get; set; }

        [JsonConverter(typeof(NoQuotesStringConverter))]
        public string FooterOffset { get; set; }
    }
}
