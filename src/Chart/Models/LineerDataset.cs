using HelperJS.Chart.Converters;
using Newtonsoft.Json;

namespace HelperJS.Chart.Models
{
    class LineerDataset : BaseDataset
    {
        public string Label { get; set; }
        public int? Order { get; set; }

        [JsonConverter(typeof(EnumOrBoolConverter))]
        public object PointStyle { get; set; }
    }
}
