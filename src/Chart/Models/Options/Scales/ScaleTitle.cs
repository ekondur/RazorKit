using RazorKit.Chart.Converters;
using Newtonsoft.Json;

namespace RazorKit.Chart.Models
{
    internal class ScaleTitle
    {
        public bool? Display { get; set; }
        public Align? Align { get; set; }

        [JsonConverter(typeof(StringOrArrayConverter))]
        public object Text { get; set; }

        public string Color { get; set; }
        public ChartFont Font { get; set; }
        public Padding Padding { get; set; }
    }
}
