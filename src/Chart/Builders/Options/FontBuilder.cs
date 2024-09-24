using HelperJS.Chart.Models;

namespace HelperJS.Chart.Builders
{
    /// <summary>
    /// Font Builder class
    /// </summary>
    public class FontBuilder
    {
        private readonly ChartJs _chart;
        private readonly ChartFont _font;

        /// <summary>
        /// Font Builder
        /// </summary>
        /// <param name="chart"></param>
        /// <param name="source"></param>
        public FontBuilder(ChartJs chart, BuilderSource source)
        {
            _chart = chart;

            switch (source)
            {
                case BuilderSource.Title:
                    _font = _chart.Options.Plugins.Title.Font = new ChartFont();
                    break;
                case BuilderSource.Subtitle:
                    _font = _chart.Options.Plugins.Subtitle.Font = new ChartFont();
                    break;
                case BuilderSource.LegendTitle:
                    _font = _chart.Options.Plugins.Legend.Title.Font = new ChartFont();
                    break;
                case BuilderSource.LegendLabels:
                    _font = _chart.Options.Plugins.Legend.Labels.Font = new ChartFont();
                    break;
            }
        }

        /// <summary>
        /// Default font family for all text, follows CSS font-family options.
        /// </summary>
        /// <param name="family"></param>
        /// <returns></returns>
        public FontBuilder Family(string family)
        {
            _font.Family = family;
            return this;
        }

        /// <summary>
        /// Default font size (in px) for text. Does not apply to radialLinear scale point labels.
        /// </summary>
        /// <param name="size"></param>
        /// <returns></returns>
        public FontBuilder Size(double size)
        {
            _font.Size = size;
            return this;
        }

        /// <summary>
        /// Default font style. Does not apply to tooltip title or footer.
        /// Does not apply to chart title. Follows CSS font-style options (i.e. normal, italic, oblique, initial, inherit).
        /// </summary>
        /// <param name="style"></param>
        /// <returns></returns>
        public FontBuilder Style(string style)
        {
            _font.Style = style;
            return this;
        }

        /// <summary>
        /// Default font weight (boldness).
        /// </summary>
        /// <param name="weight"></param>
        /// <returns></returns>
        public FontBuilder Weight(Weight weight)
        {
            _font.Weight = weight.ToString().ToLower();
            return this;
        }

        /// <summary>
        /// Default font weight (boldness).
        /// </summary>
        /// <param name="weight"></param>
        /// <returns></returns>
        public FontBuilder Weight(double weight)
        {
            _font.Weight = weight.ToString();
            return this;
        }

        /// <summary>
        /// Height of an individual line of text.
        /// </summary>
        /// <param name="lineHeight"></param>
        /// <returns></returns>
        public FontBuilder LineHeight(string lineHeight)
        {
            _font.LineHeight = lineHeight;
            return this;
        }

        /// <summary>
        /// Height of an individual line of text.
        /// </summary>
        /// <param name="lineHeight"></param>
        /// <returns></returns>
        public FontBuilder LineHeight(double lineHeight)
        {
            _font.LineHeight = lineHeight.ToString();
            return this;
        }
    }
}
