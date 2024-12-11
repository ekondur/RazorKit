using RazorKit.ChartJs.Converters;
using Newtonsoft.Json;

namespace RazorKit.ChartJs.Models
{
    class BaseDataset
    {
        public object Data { get; set; }
        public string Label { get; set; }
        public string Type { get; set; }

        [JsonConverter(typeof(StringOrArrayConverter))]
        public object BackgroundColor { get; set; }

        [JsonConverter(typeof(StringOrArrayConverter))]
        public object BorderColor { get; set; }
        public int? BorderWidth { get; set; }

        [JsonConverter(typeof(ObjectOrTypeConverter<Clip>))]
        public object Clip { get; set; }
        public string HoverBackgroundColor { get; set; }
        public string HoverBorderColor { get; set; }
        public int? HoverBorderWidth { get; set; }

        [JsonConverter(typeof(ObjectOrTypeConverter<Parsing>))]
        public object Parsing { get; set; }
        public bool? Hidden { get; set; }
    }
}
