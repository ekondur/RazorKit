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

        public PluginsBuilder Title(Action<TitleBuilder> action)
        {
            var builder = new TitleBuilder(_chart, BuilderSource.Title);
            action(builder);
            return this;
        }

        public PluginsBuilder Subtitle(Action<TitleBuilder> action)
        {
            var builder = new TitleBuilder(_chart, BuilderSource.Subtitle);
            action(builder);
            return this;
        }

        public PluginsBuilder Legend(Action<LegendBuilder> action)
        {
            var builder = new LegendBuilder(_chart);
            action(builder);
            return this;
        }
    }
}
