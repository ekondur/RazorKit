using HelperJS.Chart.Converters;
using Newtonsoft.Json;

namespace HelperJS.Chart.Models
{
    class PointDataset : BaseDataset
    {
        public CapStyle? BorderCapStyle { get; set; }
        public int[] BorderDash { get; set; }
        public double? BorderDashOffset { get; set; }
        public JoinStyle? BorderJoinStyle { get; set; }
        public CapStyle? HoverBorderCapStyle { get; set; }
        public int[] HoverBorderDash { get; set; }
        public double? HoverBorderDashOffset { get; set; }
        public JoinStyle? HoverBorderJoinStyle { get; set; }

        [JsonConverter(typeof(TypeConverter))]
        public object Fill { get; set; }
        public string Label { get; set; }
        public int? Order { get; set; }
        public double? Tension { get; set; }
        public string PointBackgroundColor { get; set; }
        public string PointBorderColor { get; set; }
        public int? PointBorderWidth { get; set; }
        public int? PointHitRadius { get; set; }
        public string PointHoverBackgroundColor { get; set; }
        public string PointHoverBorderColor { get; set; }
        public int? PointHoverBorderWidth { get; set; }
        public int? PointHoverRadius { get; set; }
        public int? PointRadius { get; set; }
        public int? PointRotation { get; set; }

        [JsonConverter(typeof(EnumOrTypeConverter<PointStyle>))]
        public object PointStyle { get; set; }
        public bool? SpanGaps { get; set; }
    }
}
