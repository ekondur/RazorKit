using HelperJS.Chart.Converters;
using Newtonsoft.Json;

namespace HelperJS.Chart.Models
{
    internal class BarElement : BaseElement
    {
        [JsonConverter(typeof(StringOrBoolConverter))]
        public object BorderSkipped { get; set; }

        [JsonConverter(typeof(ObjectIntConverter<BorderRadius>))]
        public object BorderRadius { get; set; }

        [JsonConverter(typeof(StringOrIntConverter))]
        public object InflateAmount { get; set; }

        [JsonConverter(typeof(StringOrBoolConverter))]
        public object PointStyle { get; set; }
    }
}
