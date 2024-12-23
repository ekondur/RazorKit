using RazorKit.ChartJs.Models;

namespace RazorKit.ChartJs.Builders
{
    /// <summary>
    /// Font Builder
    /// </summary>
    public class FontBuilder
    {
        private readonly ChartFont _font;

        internal FontBuilder(ChartFont font)
        {
            _font = font;
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
        public FontBuilder Weight(FontWeight weight)
        {
            _font.Weight = weight.ToString().ToLower();
            return this;
        }

        /// <summary>
        /// Default font weight (boldness).
        /// </summary>
        /// <param name="weight"></param>
        /// <returns></returns>
        public FontBuilder Weight(int weight)
        {
            _font.Weight = weight;
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
            _font.LineHeight = lineHeight;
            return this;
        }
    }
}
