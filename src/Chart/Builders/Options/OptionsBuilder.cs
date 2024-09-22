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

        public OptionsBuilder Plugins(Action<PluginsBuilder> action)
        {
            var builder = new PluginsBuilder(_chart);
            action(builder);
            return this;
        }
    }
}
