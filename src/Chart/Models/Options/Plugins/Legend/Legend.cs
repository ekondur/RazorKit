using HelperJS.Chart.Converters;
using Newtonsoft.Json;

namespace HelperJS.Chart.Models
{
    public class Legend
    {
        public bool? Display { get; set; }
        public LegendPosition Position { get; set; }
        public Align Align { get; set; }
        public int? MaxHeight { get; set; }
        public int? MaxWidth { get; set; }
        public bool? FullSize { get; set; }

        [JsonConverter(typeof(NoQuotesStringConverter))]
        public string OnClick { get; set; }

        [JsonConverter(typeof(NoQuotesStringConverter))]
        public string OnHover { get; set; }

        [JsonConverter(typeof(NoQuotesStringConverter))]
        public string OnLeave { get; set; }

        public bool? Reverse { get; set; }
        public LegendLabels Labels { get; set; }
        public bool? Rtl { get; set; }
        public string TextDirection { get; set; }
        public LegendTitle Title { get; set; }
    }
}