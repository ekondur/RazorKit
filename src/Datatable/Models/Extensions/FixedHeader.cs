using Newtonsoft.Json;
using RazorKit.Datatable.Converters;

namespace RazorKit.Datatable.Models
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
