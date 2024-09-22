using HelperJS.Chart.Builders.Line;
using HelperJS.Chart.Models;

namespace HelperJS.Chart.Builders
{
    public class ChartBuilder
    {
        internal ChartJs Chart { get; private set; } = new ChartJs();

        internal string CanvasId { get; private set; }
        protected internal bool UseCanvas { get; set; } = true;

        public LineBuilder Line(string canvasId)
        {
            Chart.Type = "line";
            return new LineBuilder { Chart = Chart, CanvasId = canvasId };
        }
    }
}
