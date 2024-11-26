using Newtonsoft.Json;
using RazorKit.DataTables.Converters;

namespace RazorKit.DataTables.Models
{
    internal class KeyTable
    {
        public bool? Blurable { get; set; }
        public string ClassName { get; set; }
        public bool? Clipboard { get; set; }
        public string ClipboardOrthogonal { get; set; }
        public string Columns { get; set; }
        public bool? EditOnFocus { get; set; }

        [JsonConverter(typeof(NoQuotesStringConverter))]
        public string Editor { get; set; }
        public string Focus { get; set; }
        public int[] Keys { get; set; }
        public int? TabIndex { get; set; }
    }
}
