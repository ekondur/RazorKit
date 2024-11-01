using Newtonsoft.Json;
using RazorKit.Datatable.Converters;

namespace RazorKit.Datatable.Models
{
    internal class RowReorder
    {
        public bool? Cancelable { get; set; }
        public string DataSrc { get; set; }

        [JsonConverter(typeof(NoQuotesStringConverter))]
        public string Editor { get; set; }
        public bool? Enable { get; set; }
        public FormOptions FormOptions { get; set; }
        public string Selector { get; set; }
        public bool? SnapX { get; set; }
        public bool? Update { get; set; }
    }

    internal class FormOptions
    {
        public string Submit { get; set; }
    }
}
