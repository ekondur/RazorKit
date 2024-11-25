using Newtonsoft.Json;
using RazorKit.Datatable.Converters;
using System;

namespace RazorKit.Datatable.Models
{
    internal class Column
    {
        public string Data { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string DefaultContent { get; set; }
        public bool? Orderable { get; set; }
        public bool? Searchable { get; set; }
        public string ClassName { get; set; }
        public bool? Visible { get; set; }
        public string Width { get; set; }
        public string ContentPadding { get; set; }
        public string Footer { get; set; }
        public ColumnType? Type { get; set; }
        public int? ResponsivePriority { get; set; }

        [JsonConverter(typeof(NoQuotesStringConverter))]
        public string Render { get; set; }

        [JsonConverter(typeof(NoQuotesStringConverter))]
        public string CreatedCell { get; set; }
    }
}
