using HelperJS.Chart.Converters;
using Newtonsoft.Json;

namespace HelperJS.Chart.Models
{
    class BaseDataset
    {
        public string Type { get; set; }
        public string BackgroundColor { get; set; }
        public string BorderColor { get; set; }
        public int? BorderWidth { get; set; }
        public Clip Clip { get; set; }
        public string HoverBackgroundColor { get; set; }
        public string HoverBorderColor { get; set; }
        public int? HoverBorderWidth { get; set; }

        [JsonConverter(typeof(ObjectOrBoolConverter<Parsing>))]
        public object Parsing { get; set; }
        public bool? Hidden { get; set; }
    }
}
