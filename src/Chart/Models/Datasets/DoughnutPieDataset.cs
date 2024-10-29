using RazorKit.Chart.Converters;
using Newtonsoft.Json;

namespace RazorKit.Chart.Models
{
    internal class DoughnutPieDataset : ArcDataset
    {
        public int? Circumference { get; set; }
        public int? HoverOffset { get; set; }

        [JsonConverter(typeof(IntOrArrayConverter))]
        public object Offset { get; set; }
        public int? Rotation { get; set; }
        public int? Spacing { get; set; }
        public int? Weight { get; set; }
    }
}
