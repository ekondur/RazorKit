using RazorKit.Chart.Converters;
using Newtonsoft.Json;

namespace RazorKit.Chart.Models
{
    class Labels
    {
        public int? BoxWidth { get; set; }
        public int? BoxHeight { get; set; }
        public string Color { get; set; }
        public ChartFont Font { get; set; }
        public int? Padding { get; set; }

        [JsonConverter(typeof(NoQuotesStringConverter))]
        public string GenerateLabels { get; set; }

        [JsonConverter(typeof(NoQuotesStringConverter))]
        public string Filter { get; set; }

        [JsonConverter(typeof(NoQuotesStringConverter))]
        public string Sort { get; set; }

        public PointStyle? PointStyle { get; set; }
        public TextAlign? TextAlign { get; set; }
        public bool? UsePointStyle { get; set; }
        public int? PointStyleWidth { get; set; }
        public bool? UseBorderRadius { get; set; }
        public double? BorderRadius { get; set; }
    }
}
