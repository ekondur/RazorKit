﻿using RazorKit.ChartJs.Converters;
using Newtonsoft.Json;

namespace RazorKit.ChartJs.Models
{
    class Animation
    {
        public int? Duration { get; set; }
        public Easing? Easing { get; set; }
        public int? Delay { get; set; }
        public bool? Loop { get; set; }

        [JsonConverter(typeof(NoQuotesStringConverter))]
        public string OnProgress { get; set; }

        [JsonConverter(typeof(NoQuotesStringConverter))]
        public string OnComplete { get; set; }

        [JsonConverter(typeof(TypeConverter))]
        public object From { get; set; }

        [JsonConverter(typeof(TypeConverter))]
        public object To { get; set; }
    }
}