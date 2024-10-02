using HelperJS.Chart.Models;
using System;

namespace HelperJS.Chart.Builders
{
    public class PluginsBuilder
    {
        private readonly ChartJs _chart;
        private readonly Plugins _plugins;

        public PluginsBuilder(ChartJs chart)
        {
            _chart = chart;
            _chart.Options.Plugins = _plugins = new Plugins();
        }

        /// <summary>
        /// The chart title defines text to draw at the top of the chart.
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        public PluginsBuilder Title(Action<TitleBuilder> action)
        {
            var builder = new TitleBuilder(_chart, FontSource.Title);
            action(builder);
            return this;
        }

        /// <summary>
        /// Subtitle is a second title placed under the main title, by default. 
        /// It has exactly the same configuration options with the main title.
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        public PluginsBuilder Subtitle(Action<TitleBuilder> action)
        {
            var builder = new TitleBuilder(_chart, FontSource.Subtitle);
            action(builder);
            return this;
        }

        /// <summary>
        /// The chart legend displays data about the datasets that are appearing on the chart.
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        public PluginsBuilder Legend(Action<LegendBuilder> action)
        {
            var builder = new LegendBuilder(_chart);
            action(builder);
            return this;
        }

        /// <summary>
        /// Configure Tooltip.
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        public PluginsBuilder Tooltip(Action<TooltipBuilder> action)
        {
            var builder = new TooltipBuilder(_chart);
            action(builder);
            return this;
        }
    }
}
