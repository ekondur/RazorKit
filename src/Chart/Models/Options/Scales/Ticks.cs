using RazorKit.Chart.Converters;
using Newtonsoft.Json;

namespace RazorKit.Chart.Models
{
    internal class Ticks
    {
        public string BackdropColor { get; set; }
        public Padding BackdropPadding { get; set; }

        [JsonConverter(typeof(NoQuotesStringConverter))]
        public string Callback { get; set; }
        public bool? Display { get; set; }
        public string Color { get; set; }
        public ChartFont Font { get; set; }
        public Major Major { get; set; }
        public int? Padding { get; set; }
        public bool? ShowLabelBackdrop { get; set; }
        public string TextStrokeColor { get; set; }
        public int? TextStrokeWidth { get; set; }
        public int? Z { get; set; }
    }
}
