using HelperJS.Chart.Converters;
using Newtonsoft.Json;

namespace HelperJS.Chart.Models
{
    internal class BarElement : BaseElement
    {
        [JsonConverter(typeof(EnumOrBoolConverter))]
        public object BorderSkipped { get; set; }

        [JsonConverter(typeof(ObjectOrtIntConverter<BorderRadius>))]
        public object BorderRadius { get; set; }

        [JsonConverter(typeof(StringOrIntConverter))]
        public object InflateAmount { get; set; }

        public PointStyle PointStyle { get; set; }
    }
}
