using HelperJS.Chart.Models;
using System;

namespace HelperJS.Chart.Builders
{
    /// <summary>
    /// Legend Builder
    /// </summary>
    public class LegendBuilder
    {
        private readonly ChartJs _chart;
        private readonly Legend _legend;

        internal LegendBuilder(ChartJs chart)
        {
            _chart = chart;
            _chart.Options.Plugins.Legend = _legend = new Legend();
        }

        /// <summary>
        /// Is the legend shown? default true.
        /// </summary>
        /// <param name="display"></param>
        /// <returns></returns>
        public LegendBuilder Display(bool display)
        {
            _legend.Display = display;
            return this;
        }

        /// <summary>
        /// Position of the legend.
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public LegendBuilder Position(LegendPosition position)
        {
            _legend.Position = position;
            return this;
        }

        /// <summary>
        /// Alignment of the legend.
        /// </summary>
        /// <param name="align"></param>
        /// <returns></returns>
        public LegendBuilder Align(Align align)
        {
            _legend.Align = align;
            return this;
        }

        /// <summary>
        /// Maximum height of the legend, in pixels.
        /// </summary>
        /// <param name="maxHeight"></param>
        /// <returns></returns>
        public LegendBuilder MaxHeight(int maxHeight)
        {
            _legend.MaxHeight = maxHeight;
            return this;
        }

        /// <summary>
        /// Maximum width of the legend, in pixels.
        /// </summary>
        /// <param name="maxWidth"></param>
        /// <returns></returns>
        public LegendBuilder MaxWidth(int maxWidth)
        {
            _legend.MaxWidth = maxWidth;
            return this;
        }

        /// <summary>
        /// Marks that this box should take the full width/height of the canvas (moving other boxes). 
        /// This is unlikely to need to be changed in day-to-day use. default true.
        /// </summary>
        /// <param name="fullSize"></param>
        /// <returns></returns>
        public LegendBuilder FullSize(bool fullSize)
        {
            _legend.FullSize = fullSize;
            return this;
        }

        /// <summary>
        /// A callback that is called when a click event is registered on a label item.
        /// Arguments: [event, legendItem, legend].
        /// </summary>
        /// <param name="onClick"></param>
        /// <returns></returns>
        public LegendBuilder OnClick(string onClick)
        {
            _legend.OnClick = onClick;
            return this;
        }

        /// <summary>
        /// A callback that is called when a 'mousemove' event is registered on top of a label item.
        /// Arguments: [event, legendItem, legend].
        /// </summary>
        /// <param name="onHover"></param>
        /// <returns></returns>
        public LegendBuilder OnHover(string onHover)
        {
            _legend.OnHover = onHover;
            return this;
        }

        /// <summary>
        /// A callback that is called when a 'mousemove' event is registered outside of a previously hovered label item. 
        /// Arguments: [event, legendItem, legend].
        /// </summary>
        /// <param name="onLeave"></param>
        /// <returns></returns>
        public LegendBuilder OnLeave(string onLeave)
        {
            _legend.OnLeave = onLeave;
            return this;
        }

        /// <summary>
        /// Legend will show datasets in reverse order. default false.
        /// </summary>
        /// <param name="reverse"></param>
        /// <returns></returns>
        public LegendBuilder Reverse(bool reverse)
        {
            _legend.Reverse = reverse;
            return this;       
        }

        /// <summary>
        /// Configure legend label.
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        public LegendBuilder Labels(Action<LegendLabelsBuilder> action)
        {
            var builder = new LegendLabelsBuilder(_chart);
            action(builder);
            return this;
        }

        /// <summary>
        /// 'true' for rendering the legends from right to left.
        /// </summary>
        /// <param name="rtl"></param>
        /// <returns></returns>
        public LegendBuilder Rtl(bool rtl)
        {
            _legend.Rtl = rtl;
            return this;
        }

        /// <summary>
        /// This will force the text direction 'rtl' or 'ltr' on the canvas for rendering the legend,
        /// regardless of the css specified on the canvas.
        /// </summary>
        /// <param name="textDirection"></param>
        /// <returns></returns>
        public LegendBuilder TextDirection(string textDirection)
        {
            _legend.TextDirection = textDirection;
            return this;
        }

        /// <summary>
        /// Configure legend title.
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        public LegendBuilder Title(Action<LegendTitleBuilder> action)
        {
            var builder = new LegendTitleBuilder(_chart);
            action(builder);
            return this;
        }
    }
}
