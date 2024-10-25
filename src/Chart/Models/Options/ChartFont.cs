﻿using HelperJS.Chart.Converters;
using Newtonsoft.Json;

namespace HelperJS.Chart.Models
{
    class ChartFont
    {
        public string Family { get; set; }
        public double? Size { get; set; }
        public string Style { get; set; }

        [JsonConverter(typeof(DynamicConverter))]
        public object Weight { get; set; }

        [JsonConverter(typeof(DynamicConverter))]
        public object LineHeight { get; set; }
    }
}
