using HelperJS.Chart.Models;
using System;

namespace HelperJS.Chart.Builders
{
    /// <summary>
    /// ScaleTitle Builder
    /// </summary>
    public class ScaleTitleBuilder
    {
        private readonly ScaleTitle _scaleTitle;

        internal ScaleTitleBuilder(Scale scale)
        {
            scale.Title = _scaleTitle = new ScaleTitle();
        }

        /// <summary>
        /// If true, display the axis title. Default false
        /// </summary>
        /// <param name="display"></param>
        /// <returns></returns>
        public ScaleTitleBuilder Display(bool display)
        {
            _scaleTitle.Display = display;
            return this;
        }

        /// <summary>
        /// Alignment of the axis title. Possible options are 'start', 'center' and 'end'.
        /// Default 'center'
        /// </summary>
        /// <param name="align"></param>
        /// <returns></returns>
        public ScaleTitleBuilder Align(Align align)
        {
            _scaleTitle.Align = align;
            return this;
        }

        /// <summary>
        /// The text for the title. (i.e. "# of People" or "Response Choices").
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public ScaleTitleBuilder Text(string text)
        {
            _scaleTitle.Text = text;
            return this;
        }

        /// <summary>
        /// The text for the title(s).
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public ScaleTitleBuilder Text(params string[] text)
        {
            _scaleTitle.Text = text;
            return this;
        }

        /// <summary>
        /// Color of label.
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public ScaleTitleBuilder Color(string color)
        {
            _scaleTitle.Color = color;
            return this;
        }

        /// <summary>
        /// Configure Font.
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        public ScaleTitleBuilder Font(Action<FontBuilder> action)
        {
            _scaleTitle.Font = new ChartFont();
            var builder = new FontBuilder(_scaleTitle.Font);
            action(builder);
            return this;
        }

        /// <summary>
        /// Padding to apply around scale labels. Only top, bottom and y are implemented.
        /// Default 4
        /// </summary>
        /// <param name="padding"></param>
        /// <returns></returns>
        public ScaleTitleBuilder Padding(int padding)
        {
            _scaleTitle.Padding = new Padding(padding);
            return this;
        }

        /// <summary>
        /// Configure Padding.
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        public ScaleTitleBuilder Padding(Action<PaddingBuilder> action)
        {
            _scaleTitle.Padding = new Padding();
            var builder = new PaddingBuilder(_scaleTitle.Padding);
            action(builder);
            return this;
        }
    }
}
