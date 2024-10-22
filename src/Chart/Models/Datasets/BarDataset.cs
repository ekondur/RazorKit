using HelperJS.Chart.Converters;
using Newtonsoft.Json;

namespace HelperJS.Chart.Models
{
    internal class BarDataset : BaseDataset
    {
        public int? Base { get; set; }
        public double? BarPercentage { get; set; }

        [JsonConverter(typeof(StringOrIntConverter))]
        public object BarThickness { get; set; }

        [JsonConverter(typeof(StringOrBoolConverter))]
        public object BorderSkipped { get; set; }

        [JsonConverter(typeof(ObjectOrBoolConverter<BorderWidth>))]
        public new object BorderWidth { get; set; }
    }
}
