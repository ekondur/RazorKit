using HelperJS.Chart.Converters;
using Newtonsoft.Json;

namespace HelperJS.Chart.Models
{
    class Scale
    {
        // Common options to all axes
        public string Type { get; set; }
        public bool? AlignToPixels { get; set; }
        public string BackgroundColor { get; set; }
        public ScaleBorder Border { get; set; }

        [JsonConverter(typeof(StringOrBoolConverter))]
        public object Display { get; set; }
        public ScaleGrid Grid { get; set; }

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
