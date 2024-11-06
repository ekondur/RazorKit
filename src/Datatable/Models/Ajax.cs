using Newtonsoft.Json;
using RazorKit.Datatable.Converters;

namespace RazorKit.Datatable.Models
{
    internal class AjaxSource
    {
        public string Url { get; set; }
        public string Type { get; set; }
        internal Convention Convention { get; set; }

        [JsonConverter(typeof(NoQuotesStringConverter))]
        public string Data { get; set; }
    }
}
