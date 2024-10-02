using HelperJS.Chart.Models;
using System;

namespace HelperJS.Chart.Builders
{
    public class OptionsBuilder
    {
        private readonly ChartJs _chart;
        private readonly Options _options;

        public OptionsBuilder(ChartJs chart)
        {
            _chart = chart;
            _chart.Options = _options = new Options();
        }

        /// <summary>
        /// Resizes the chart canvas when its container does. Default true
        /// </summary>
        /// <param name="responsive"></param>
        /// <returns></returns>
        public OptionsBuilder Responsive(bool responsive)
        {
            _options.Responsive = responsive;
            return this;
        }

        /// <summary>
        /// Maintain the original canvas aspect ratio (width / height) when resizing. Default true
        /// </summary>
        /// <param name="maintainAspectRatio"></param>
        /// <returns></returns>
        public OptionsBuilder MaintainAspectRatio(bool maintainAspectRatio)
        {
            _options.MaintainAspectRatio = maintainAspectRatio;
            return this;
        }

        /// <summary>
        /// Canvas aspect ratio (i.e. width / height, a value of 1 representing a square canvas).
        /// Note that this option is ignored if the height is explicitly defined either as attribute or via the style.
        /// The default value varies by chart type; Radial charts (doughnut, pie, polarArea, radar) default to 1 and others default to 2.
        /// </summary>
        /// <param name="aspectRatio"></param>
        /// <returns></returns>
        public OptionsBuilder AspectRatio(int aspectRatio)
        {
            _options.AspectRatio = aspectRatio;
            return this;
        }

        /// <summary>
        /// Called when a resize occurs. Gets passed two arguments: the chart instance and the new size.
        /// </summary>
        /// <param name="onResize"></param>
        /// <returns></returns>
        public OptionsBuilder OnResize(string onResize)
        {
            _options.OnResize = onResize;
            return this;
        }

        /// <summary>
        /// Delay the resize update by the given amount of milliseconds.
        /// This can ease the resize process by debouncing the update of the elements.
        /// Default 0
        /// </summary>
        /// <param name="delay"></param>
        /// <returns></returns>
        public OptionsBuilder ResizeDelay(int delay)
        {
            _options.ResizeDelay = delay;
            return this;
        }

        /// <summary>
        /// Set a language code.
        /// </summary>
        /// <param name="locale"></param>
        /// <returns></returns>
        public OptionsBuilder Locale(string locale)
        {
            _options.Locale = locale;
            return this;
        }

        /// <summary>
        /// Configure plugins.
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        public OptionsBuilder Plugins(Action<PluginsBuilder> action)
        {
            var builder = new PluginsBuilder(_chart);
            action(builder);
            return this;
        }

        /// <summary>
        /// Configure layout.
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        public OptionsBuilder Layout(Action<LayoutBuilder> action)
        {
            var builder = new LayoutBuilder(_chart);
            action(builder);
            return this;
        }
    }
}
