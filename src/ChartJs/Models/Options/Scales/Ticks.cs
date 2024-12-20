using RazorKit.ChartJs.Converters;
using Newtonsoft.Json;

namespace RazorKit.ChartJs.Models
{
    internal class Ticks
    {
        // Common tick options to all axes
        public string BackdropColor { get; set; }
        public Padding BackdropPadding { get; set; }

        [JsonConverter(typeof(NoQuotesStringConverter))]
        public string Callback { get; set; }
        public bool? Display { get; set; }
        public string Color { get; set; }
        public ChartFont Font { get; set; }
        public TicksMajor Major { get; set; }
        public int? Padding { get; set; }
        public bool? ShowLabelBackdrop { get; set; }
        public string TextStrokeColor { get; set; }
        public int? TextStrokeWidth { get; set; }
        public int? Z { get; set; }

        // Common tick options to all cartesian axes
        public TicksAlign? Align { get; set; }
        public TicksCrossAlign? CrossAlign { get; set; }
        public int? SampleSize { get; set; }
        public bool? AutoSkip { get; set; }
        public int? AutoSkipPadding { get; set; }
        public bool? IncludeBounds { get; set; }
        public int? LabelOffset { get; set; }
        public int? MaxRotation { get; set; }
        public int? MinRotation { get; set; }
        public bool? Mirror { get; set; }
        public int? MaxTicksLimit { get; set; }
    }
}
