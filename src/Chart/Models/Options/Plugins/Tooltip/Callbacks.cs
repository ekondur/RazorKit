using RazorKit.Chart.Converters;
using Newtonsoft.Json;

namespace RazorKit.Chart.Models
{
    class Callbacks
    {
        [JsonConverter(typeof(NoQuotesStringConverter))]
        public string BeforeTitle { get; set; }

        [JsonConverter(typeof(NoQuotesStringConverter))]
        public string Title { get; set; }

        [JsonConverter(typeof(NoQuotesStringConverter))]
        public string AfterTitle { get; set; }

        [JsonConverter(typeof(NoQuotesStringConverter))]
        public string BeforeBody { get; set; }

        [JsonConverter(typeof(NoQuotesStringConverter))]
        public string BeforeLabel { get; set; }

        [JsonConverter(typeof(NoQuotesStringConverter))]
        public string Label { get; set; }

        [JsonConverter(typeof(NoQuotesStringConverter))]
        public string LabelColor { get; set; }

        [JsonConverter(typeof(NoQuotesStringConverter))]
        public string LabelTextColor { get; set; }

        [JsonConverter(typeof(NoQuotesStringConverter))]
        public string LabelPointStyle { get; set; }

        [JsonConverter(typeof(NoQuotesStringConverter))]
        public string AfterLabel { get; set; }

        [JsonConverter(typeof(NoQuotesStringConverter))]
        public string AfterBody { get; set; }

        [JsonConverter(typeof(NoQuotesStringConverter))]
        public string BeforeFooter { get; set; }

        [JsonConverter(typeof(NoQuotesStringConverter))]
        public string Footer { get; set; }

        [JsonConverter(typeof(NoQuotesStringConverter))]
        public string AfterFooter { get; set; }
    }
}
