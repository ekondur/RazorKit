using HelperJS.Chart.Converters;
using Newtonsoft.Json;

namespace HelperJS.Chart.Models
{
    public class ToolTip
    {
        public bool? Enabled { get; set; }

        [JsonConverter(typeof(NoQuotesStringConverter))]
        public string External { get; set; }

        public string Mode { get; set; }

        public bool? Intersect { get; set; }

        public string Position { get; set; }

        public Callbacks Callbacks { get; set; }

        [JsonConverter(typeof(NoQuotesStringConverter))]
        public string ItemSort { get; set; }

        [JsonConverter(typeof(NoQuotesStringConverter))]
        public string Filter { get; set; }

        public string BackgroundColor { get; set; }

        public string TitleColor { get; set; }

        public ChartFont TitleFont { get; set; }

        public TextAlign? TitleAlign { get; set; }

        public int? TitleSpacing { get; set; }

        public int? TitleMarginBottom { get; set; }

        public string BodyColor { get; set; }

        public ChartFont BodyFont { get; set; }

        public TextAlign? BodyAlign { get; set; }

        public int? BodySpacing { get; set; }

        public string FooterColor { get; set; }

        public ChartFont FooterFont { get; set; }

        public TextAlign? FooterAlign { get; set; }

        public int? FooterSpacing { get; set; }

        public int? FooterMarginTop { get; set; }

        public Padding Padding { get; set; }

        public int? CaretPadding { get; set; }

        public int? CaretSize { get; set; }

        public int? CornerRadius { get; set; }

        public string MultiKeyBackground { get; set; }

        public bool? DisplayColors { get; set; }

        public int? BoxWidth { get; set; }

        public int? BoxHeight { get; set; }

        public int? BoxPadding { get; set; }

        public bool? UsePointStyle { get; set; }

        public string BorderColor { get; set; }

        public int? BorderWidth { get; set; }

        public bool? Rtl { get; set; }

        public string TextDirection { get; set; }

        public string XAlign { get; set; }

        public string YAlign { get; set; }
    }
}