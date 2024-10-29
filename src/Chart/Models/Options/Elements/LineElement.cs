﻿using RazorKit.Chart.Converters;
using Newtonsoft.Json;

namespace RazorKit.Chart.Models
{
    internal class LineElement : BaseElement
    {
        public double? Tension { get; set; }
        public CapStyle? BorderCapStyle { get; set; }
        public int[] BorderDash { get; set; }
        public double? BorderDashOffset { get; set; }
        public JoinStyle? BorderJoinStyle { get; set; }
        public bool? CapBezierPoints { get; set; }
        public string CubicInterpolationMode { get; set; }

        [JsonConverter(typeof(TypeConverter))]
        public object Fill { get; set; }

        public bool? Stepped { get; set; }
    }
}
