using HelperJS.Chart.Models;

namespace HelperJS.Chart.Builders
{
    public class LegendTitleBuilder
    {
        private readonly ChartJs _chart;
        private readonly LegendTitle _legendTitle;

        public LegendTitleBuilder(ChartJs chart)
        {
            _chart = chart;
            _chart.Options.Plugins.Legend.Title = _legendTitle = new LegendTitle();
        }
    }
}
