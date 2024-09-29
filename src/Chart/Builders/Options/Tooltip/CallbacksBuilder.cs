using HelperJS.Chart.Models;

namespace HelperJS.Chart.Builders
{
    public class CallbacksBuilder
    {
        private readonly ChartJs _chart;
        private readonly Callbacks _callbacks;

        public CallbacksBuilder(ChartJs chart)
        {
            _chart = chart;
            _chart.Options.Plugins.Tooltip.Callbacks = _callbacks = new Callbacks();
        }
    }
}
