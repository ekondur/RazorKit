using Newtonsoft.Json;
using RazorKit.DataTables.Converters;

namespace RazorKit.DataTables.Models
{
    internal class Select
    {
        public string ClassName { get; set; }
        public bool? Blurable { get; set; }
        public string HeaderCheckbox { get; set; }
        public bool? Info { get; set; }
        public SelectItems? Items { get; set; }
        public string Selector { get; set; }
        public SelectStyle? Style { get; set; }
        public bool? Toggleable { get; set; }

        [JsonConverter(typeof(NoQuotesStringConverter))]
        public string Selectable { get; set; }
    }
}
