using HelperJS.Chart.Converters;
using Newtonsoft.Json;

namespace HelperJS.Chart.Models
{
    internal class Fill
    {
        public int? Value { get; set; }

        [JsonConverter(typeof(TypeConverter))]
        public object Target { get; set; }
        public string Above { get; set; }
        public string Below { get; set; }
    }
}
