using HelperJS.Chart.Models;
using System;

namespace HelperJS.Chart.Builders
{
    /// <summary>
    /// LegendTitle Builder
    /// </summary>
    public class LegendTitleBuilder
    {
        private readonly LegendTitle _legendTitle;

        internal LegendTitleBuilder(LegendTitle legendTitle)
        {
            _legendTitle = legendTitle;
        }

        /// <summary>
        /// Color of text.
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public LegendTitleBuilder Color(string color)
        {
            _legendTitle.Color = color;
            return this;
        }

        /// <summary>
        /// Is the legend title displayed.
        /// </summary>
        /// <param name="display"></param>
        /// <returns></returns>
        public LegendTitleBuilder Display(bool display)
        {
            _legendTitle.Display = display;
            return this;
        }

        /// <summary>
        /// Configure font.
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        public LegendTitleBuilder Font(Action<FontBuilder> action)
        {
            _legendTitle.Font = new ChartFont();
            var builder = new FontBuilder(_legendTitle.Font);
            action(builder);
            return this;
        }

        /// <summary>
        /// Padding around the title.
        /// </summary>
        /// <param name="padding"></param>
        /// <returns></returns>
        public LegendTitleBuilder Padding(int padding)
        {
            _legendTitle.Padding = new Padding(padding);
            return this;
        }

        /// <summary>
        /// Configure padding around the title.
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        public LegendTitleBuilder Padding(Action<PaddingBuilder> action)
        {
            _legendTitle.Padding = new Padding();
            var builder = new PaddingBuilder(_legendTitle.Padding);
            action(builder);
            return this;
        }

        /// <summary>
        /// The string title.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public LegendTitleBuilder Text(string text)
        {
            _legendTitle.Text = text;
            return this;
        }
    }
}
