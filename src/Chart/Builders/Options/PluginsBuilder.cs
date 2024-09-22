using HelperJS.Chart.Models;
using System;

namespace HelperJS.Chart.Builders
{
    public class PluginsBuilder
    {
        private readonly ChartJs _chart;

        public PluginsBuilder(ChartJs chart)
        {
            _chart = chart;
            _chart.Options.Plugins = new Plugins();
        }

        public PluginsBuilder Title(Action<TitleBuilder> action)
        {
            var builder = new TitleBuilder(_chart, false);
            action(builder);
            return this;
        }

        public PluginsBuilder Subtitle(Action<TitleBuilder> action)
        {
            var builder = new TitleBuilder(_chart, true);
            action(builder);
            return this;
        }
    }
}
