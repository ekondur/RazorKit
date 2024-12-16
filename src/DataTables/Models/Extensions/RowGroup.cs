using Newtonsoft.Json;
using RazorKit.DataTables.Converters;

namespace RazorKit.DataTables.Models
{
    internal class RowGroup
    {
        public string ClassName { get; set; }
        public object DataSrc { get; set; }
        public string EmptyDataGroup { get; set; }
        public bool? Enable { get; set; }
        public string EndClassName { get; set; }
        public string StartClassName { get; set; }

        [JsonConverter(typeof(NoQuotesStringConverter))]
        public string EndRender { get; set; }

        [JsonConverter(typeof(NoQuotesStringConverter))]
        public string StartRender { get; set; }
    }
}
