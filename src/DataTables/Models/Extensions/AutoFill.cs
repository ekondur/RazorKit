using Newtonsoft.Json;
using RazorKit.DataTables.Converters;

namespace RazorKit.DataTables.Models
{
    internal class AutoFill
    {
        public bool? AlwaysAsk { get; set; }
        public string Columns { get; set; }
        public bool? Enable { get; set; }
        public string Focus { get; set; }
        public bool? Horizontal { get; set; }
        public bool? Update { get; set; }
        public bool? Vertical { get; set; }

        [JsonConverter(typeof(NoQuotesStringConverter))]
        public string Editor { get; set; }
    }
}
