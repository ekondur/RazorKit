using HelperJS.Chart.Models;
using System;

namespace HelperJS.Chart.Builders
{
    public class TitleBuilder
    {
        private readonly ChartJs _chart;
        private readonly Title _title;
        private readonly bool _isSubtitle;

        public TitleBuilder(ChartJs chart, bool isSubtitle)
        {
            _chart = chart;
            _isSubtitle = isSubtitle;

            if (isSubtitle)
            {
                _chart.Options.Plugins.Subtitle = _title = new Title();
            }
            else
            {
                _chart.Options.Plugins.Title = _title = new Title();
            }
        }

        /// <summary>
        /// Alignment of the title. default 'center'
        /// </summary>
        /// <param name="align"></param>
        /// <returns></returns>
        public TitleBuilder Align(Align align)
        {
            _title.Align = align;
            return this;
        }

        /// <summary>
        /// Color of text.
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public TitleBuilder Color(string color)
        {
            _title.Color = color;
            return this;
        }

        /// <summary>
        /// Is the title shown? default 'false'
        /// </summary>
        /// <param name="display"></param>
        /// <returns></returns>
        public TitleBuilder Display(bool display)
        {
            _title.Display = display;
            return this;
        }

        /// <summary>
        /// Marks that this box should take the full width/height of the canvas. 
        /// If false, the box is sized and placed above/beside the chart area.
        /// default 'false'.
        /// </summary>
        /// <param name="fullSize"></param>
        /// <returns></returns>
        public TitleBuilder FullSize(bool fullSize)
        {
            _title.FullSize = fullSize;
            return this;
        }

        /// <summary>
        /// Position of title. default 'top'
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public TitleBuilder Position(TitlePosition position)
        {
            _title.Position = position;
            return this;
        }

        /// <summary>
        /// Font builder
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        public TitleBuilder Font(Action<FontBuilder> action)
        {
            var builder = new FontBuilder(_chart, _isSubtitle);
            action(builder);
            return this;
        }

        public TitleBuilder Padding(int padding)
        {
            _title.Padding = padding;
            return this;
        }

        public TitleBuilder Text(params string[] text)
        {
            _title.Text = text;
            return this;
        }
    }
}
