using HelperJS.Chart.Converters;
using Newtonsoft.Json;

namespace HelperJS.Chart.Models
{
    internal class LineElement : BaseElement
    {
        public double? Tension { get; set; }
        public CapStyle? BorderCapStyle { get; set; }
        public int[] BorderDash { get; set; }
        public double? BorderDashOffset { get; set; }
        public JoinStyle? BorderJoinStyle { get; set; }
        public bool? CapBezierPoints { get; set; }
        public string CubicInterpolationMode { get; set; }

        [JsonConverter(typeof(StringOrBoolConverter))]
        public object Fill { get; set; }

        public bool? Stepped { get; set; }
    }
}
