using Newtonsoft.Json;
using RazorKit.ChartJs.Converters;

namespace RazorKit.ChartJs.Models
{
    class LineDataset : PointDataset
    {
        public InterpolationMode CubicInterpolationMode { get; set; }
        public bool? DrawActiveElementsOnTop { get; set; }
        public IndexAxis IndexAxis { get; set; }

        [JsonConverter(typeof(NoQuotesStringConverter))]
        public string Segment { get; set; }
        public bool? ShowLine { get; set; }
        public string Stack { get; set; }
        public object Stepped { get; set; }
        public string XAxisID { get; set; }
        public string YAxisID { get; set; }
    }
}