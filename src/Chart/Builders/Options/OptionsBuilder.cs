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
        /// Configure layout
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
