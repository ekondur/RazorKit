using HelperJS.Chart.Converters;
using Newtonsoft.Json;

namespace HelperJS.Chart.Models
{
    class Scale
    {
        // Linear Axis specific options
        public bool? BeginAtZero { get; set; }

        [JsonConverter(typeof(StringOrIntConverter))]
        public object Grace { get; set; }

        // Common options to all cartesian axes
        public Bounds? Bounds { get; set; }
        public bool? Clip { get; set; }
        public AxisPosition? Position { get; set; }
        public string Stack { get; set; }
        public int? StackWeight { get; set; }
        public string Axis { get; set; }
        public bool? Offset { get; set; }
        public ScaleTitle Title { get; set; }
    }
}
