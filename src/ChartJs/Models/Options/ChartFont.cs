﻿using RazorKit.ChartJs.Converters;
using Newtonsoft.Json;

namespace RazorKit.ChartJs.Models
{
    class ChartFont
    {
        public string Family { get; set; }
        public double? Size { get; set; }
        public string Style { get; set; }

        [JsonConverter(typeof(TypeConverter))]
        public object Weight { get; set; }

        [JsonConverter(typeof(TypeConverter))]
        public object LineHeight { get; set; }
    }
}
