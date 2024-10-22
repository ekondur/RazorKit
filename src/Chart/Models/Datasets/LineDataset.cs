using HelperJS.Chart.Converters;
using Newtonsoft.Json;

namespace HelperJS.Chart.Models.Datasets
{
    class LineDataset : PointDataset
    {
        public CapStyle? BorderCapStyle { get; set; }
        public int[] BorderDash { get; set; }
        public double? BorderDashOffset { get; set; }
        public JoinStyle? BorderJoinStyle { get; set; }
        public string CubicInterpolationMode { get; set; }
        public object[] Data { get; set; }
        public bool? DrawActiveElementsOnTop { get; set; }

        [JsonConverter(typeof(StringOrBoolConverter))]
        public object Fill { get; set; }
        public CapStyle? HoverBorderCapStyle { get; set; }
        public int[] HoverBorderDash { get; set; }
        public double? HoverBorderDashOffset { get; set; }
        public JoinStyle? HoverBorderJoinStyle { get; set; }
        public string IndexAxis { get; set; }
        public object Segment { get; set; }
        public bool? ShowLine { get; set; }
        public bool? SpanGaps { get; set; }
        public string Stack { get; set; }
        public bool? Stepped { get; set; }
        public double? Tension { get; set; }
        public string XAxisID { get; set; }
        public string YAxisID { get; set; }
    }
}
