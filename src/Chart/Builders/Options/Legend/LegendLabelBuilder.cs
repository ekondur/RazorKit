using HelperJS.Chart.Models;

namespace HelperJS.Chart.Builders
{
    public class LegendLabelBuilder
    {
        private readonly ChartJs _chart;
        private readonly LegendLabel _legendLabel;

        public LegendLabelBuilder(ChartJs chart)
        {
            _chart = chart;
            _chart.Options.Plugins.Legend.Labels = _legendLabel = new LegendLabel();
        }


    }
}
