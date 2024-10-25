using HelperJS.Chart.Converters;
using Newtonsoft.Json;

namespace HelperJS.Chart.Models
{
    internal class PointElement : BaseElement
    {
        public int? Radius { get; set; }

        [JsonConverter(typeof(DynamicConverter<PointStyle>))]
        public object PointStyle { get; set; }
        public int? Rotation { get; set; }
        public int? HitRadius { get; set; }
        public int? HoverRadius { get; set; }
        public int? HoverBorderWidth { get; set; }
    }
}
