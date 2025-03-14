﻿using RazorKit.ChartJs.Converters;
using Newtonsoft.Json;

namespace RazorKit.ChartJs.Models
{
    internal class BarDataset : BaseDataset
    {
        public int? Base { get; set; }
        public double? BarPercentage { get; set; }
        public object BarThickness { get; set; }

        [JsonConverter(typeof(EnumOrTypeConverter<Skipped>))]
        public object BorderSkipped { get; set; }

        public new object BorderWidth { get; set; }
        public object BorderRadius { get; set; }
        public double? CategoryPercentage { get; set; }
        public bool? Grouped { get; set; }
        public int? HoverBorderRadius { get; set; }
        public IndexAxis? IndexAxis { get; set; }
        public int? Order { get; set; }
        public object PointStyle { get; set; }
        public bool? SkipNull { get; set; }
        public string Stack { get; set; }
        public string XAxisID { get; set; }
        public string YAxisID { get; set; }
    }
}
