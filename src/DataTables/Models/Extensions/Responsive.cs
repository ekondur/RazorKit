﻿using Newtonsoft.Json;
using RazorKit.DataTables.Converters;
using System.Collections.Generic;

namespace RazorKit.DataTables.Models
{
    internal class Responsive
    {
        public string Orthogonal { get; set; }
        public IList<Breakpoint> Breakpoints { get; set; }
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
