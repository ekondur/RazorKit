using RazorKit.ChartJs.Converters;
using Newtonsoft.Json;

namespace RazorKit.ChartJs.Models
{
    partial class Scale
    {
        [JsonConverter(typeof(NoQuotesStringConverter))]
        public string BeforeUpdate { get; set; }

        [JsonConverter(typeof(NoQuotesStringConverter))]
        public string AfterUpdate { get; set; }

        [JsonConverter(typeof(NoQuotesStringConverter))]
        public string BeforeSetDimensions { get; set; }

        [JsonConverter(typeof(NoQuotesStringConverter))]
        public string AfterSetDimensions { get; set; }

        [JsonConverter(typeof(NoQuotesStringConverter))]
        public string BeforeDataLimits { get; set; }

        [JsonConverter(typeof(NoQuotesStringConverter))]
        public string AfterDataLimits { get; set; }

        [JsonConverter(typeof(NoQuotesStringConverter))]
        public string BeforeBuildTicks { get; set; }

        [JsonConverter(typeof(NoQuotesStringConverter))]
        public string AfterBuildTicks { get; set; }

        [JsonConverter(typeof(NoQuotesStringConverter))]
        public string BeforeTickToLabelConversion { get; set; }

        [JsonConverter(typeof(NoQuotesStringConverter))]
        public string AfterTickToLabelConversion { get; set; }

        [JsonConverter(typeof(NoQuotesStringConverter))]
        public string BeforeCalculateLabelRotation { get; set; }

        [JsonConverter(typeof(NoQuotesStringConverter))]
        public string AfterCalculateLabelRotation { get; set; }

        [JsonConverter(typeof(NoQuotesStringConverter))]
        public string BeforeFit { get; set; }

        [JsonConverter(typeof(NoQuotesStringConverter))]
        public string AfterFit { get; set; }
    }
}
