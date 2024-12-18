using RazorKit.ChartJs.Converters;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace RazorKit.ChartJs.Models
{
    class Options
    {
        public bool? Responsive { get; set; }
        public bool? MaintainAspectRatio { get; set; }
        public int? AspectRatio { get; set; }

        [JsonConverter(typeof(NoQuotesStringConverter))]
        public string OnResize { get; set; }

        [JsonConverter(typeof(NoQuotesStringConverter))]
        public string OnHover { get; set; }

        [JsonConverter(typeof(NoQuotesStringConverter))]
        public string OnClick { get; set; }

        public ChartEvent[] Events { get; set; }
        public int? ResizeDelay { get; set; }
        public string Locale { get; set; }
        public object Parsing { get; set; }
        public Animation Animation { get; set; }
        public Plugins Plugins { get; set; }
        public Layout Layout { get; set; }
        public Interaction Interaction { get; set; }
        public Elements Elements { get; set; }
        public Dictionary<string, Scale> Scales { get; set; }
        public Dictionary<string, Animation> Animations { get; set; }
    }
}
