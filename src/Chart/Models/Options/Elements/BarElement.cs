using RazorKit.Chart.Converters;
using Newtonsoft.Json;

namespace RazorKit.Chart.Models
{
    internal class BarElement : BaseElement
    {
        [JsonConverter(typeof(EnumOrTypeConverter<Skipped>))]
        public object BorderSkipped { get; set; }

        [JsonConverter(typeof(ObjectOrTypeConverter<BorderRadius>))]
        public object BorderRadius { get; set; }

        [JsonConverter(typeof(TypeConverter))]
        public object InflateAmount { get; set; }

        public PointStyle PointStyle { get; set; }
    }
}
