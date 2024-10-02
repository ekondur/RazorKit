using HelperJS.Chart.Converters;
using Newtonsoft.Json;

namespace HelperJS.Chart.Models
{
    class Options
    {
        public bool? Responsive { get; set; }
        public bool? MaintainAspectRatio { get; set; }
        public int? AspectRatio { get; set; }

        [JsonConverter(typeof(NoQuotesStringConverter))]
        public string OnResize { get; set; }

        public int? ResizeDelay { get; set; }
        public string Locale { get; set; }
        public Animation Animation { get; set; }
        public Scales Scales { get; set; }
        public Plugins Plugins { get; set; }
        public Layout Layout { get; set; }
        public Interaction Interaction { get; set; }
    }
}
