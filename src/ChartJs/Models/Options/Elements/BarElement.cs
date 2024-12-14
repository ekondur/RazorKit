using RazorKit.ChartJs.Converters;
using Newtonsoft.Json;

namespace RazorKit.ChartJs.Models
{
    internal class BarElement : BaseElement
    {
        [JsonConverter(typeof(EnumOrTypeConverter<Skipped>))]
        public object BorderSkipped { get; set; }

        public object BorderRadius { get; set; }
        public object InflateAmount { get; set; }
        public PointStyle? PointStyle { get; set; }
    }
}
