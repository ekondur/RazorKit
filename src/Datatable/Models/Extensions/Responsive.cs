using Newtonsoft.Json;
using RazorKit.Datatable.Converters;
using System.Collections.Generic;

namespace RazorKit.Datatable.Models
{
    internal class Responsive
    {
        public string Orthogonal { get; set; }
        public IList<Breakpoint> Breakpoints { get; set; }

        [JsonConverter(typeof(ObjectOrTypeConverter<Details>))]
        public object Details { get; set; }
    }

    internal class Breakpoint
    {
        public string Name { get; set; }
        public string Width { get; set; }
    }

    internal class Details
    {
        public DetailType Type { get; set; }
        public int? Target { get; set; }

        [JsonConverter(typeof(NoQuotesStringConverter))]
        public string Display { get; set; }

        [JsonConverter(typeof(NoQuotesStringConverter))]
        public string Renderer { get; set; }
    }
}
