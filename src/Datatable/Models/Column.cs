using Newtonsoft.Json;
using RazorKit.Datatable.Converters;
using System;

namespace RazorKit.Datatable.Models
{
    internal class Column
    {
        public string Data { get; set; }
        public string Name { get; set; }
        public string DefaultContent { get; set; }
        public bool? Orderable { get; set; }
        public bool? Searchable { get; set; }
        public string ClassName { get; set; }
        public bool? Visible { get; set; }
        public int? Width { get; set; }

        [JsonConverter(typeof(NoQuotesStringConverter))]
        public string Render { get; set; } = "data";

        internal string Title { get; set; }
        internal Type Type { get; set; }
    }
}
