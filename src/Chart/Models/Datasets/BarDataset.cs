using HelperJS.Chart.Converters;
using Newtonsoft.Json;

namespace HelperJS.Chart.Models
{
    internal class BarDataset : BaseDataset
    {
        public int? Base { get; set; }
        public double? BarPercentage { get; set; }

        [JsonConverter(typeof(DynamicConverter))]
        public object BarThickness { get; set; }

        [JsonConverter(typeof(DynamicConverter))]
        public object BorderSkipped { get; set; }

        [JsonConverter(typeof(ObjectOrBoolConverter<BorderWidth>))]
        public new object BorderWidth { get; set; }
    }
}
