using HelperJS.Chart.Builders.Line;
using HelperJS.Chart.Models;

namespace HelperJS.Chart.Builders
{
    public class ChartBuilder
    {
        internal ChartJs Chart { get; private set; } = new ChartJs();

        internal string CanvasId { get; private set; }
        internal bool UseCanvas { get; set; }

        /// <summary>
        /// Configure line chart. if 'useCanvas' is disabled, the canvas element should be also defined.
        /// </summary>
        /// <param name="canvasId"></param>
        /// <param name="useCanvas"></param>
        /// <returns></returns>
        public LineBuilder Line(string canvasId, bool useCanvas)
        {
            Chart.Type = "line";
            return new LineBuilder { Chart = Chart, CanvasId = canvasId, UseCanvas = useCanvas };
        }

        /// <summary>
        /// Configure line chart
        /// </summary>
        /// <param name="canvasId"></param>
        /// <returns></returns>
        public LineBuilder Line(string canvasId)
        {
            return Line(canvasId, true);
        }
    }
}
