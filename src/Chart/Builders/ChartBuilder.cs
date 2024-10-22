using HelperJS.Chart.Models;
using System;

namespace HelperJS.Chart.Builders
{
    /// <summary>
    /// Chart Builder
    /// </summary>
    public class ChartBuilder
    {
        internal ChartJs Chart { get; private set; }
        internal string CanvasId { get; private set; }
        internal bool UseCanvas { get; private set; }

        internal ChartBuilder(string canvasId)
        {
            CanvasId = canvasId;
            UseCanvas = true;
            Chart = new ChartJs();
        }

        internal ChartBuilder(string canvasId, bool useCanvas)
        {
            CanvasId = canvasId;
            UseCanvas = useCanvas;
            Chart = new ChartJs();
        }

        /// <summary>
        /// Configure data.
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        public ChartBuilder Data(Action<DataBuilder> action)
        {
            Chart.Data = new Data();
            var builder = new DataBuilder(Chart.Data);
            action(builder);
            return this;
        }

        /// <summary>
        /// Configure options.
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        public ChartBuilder Options(Action<OptionsBuilder> action)
        {
            Chart.Options = new Options();
            var builder = new OptionsBuilder(Chart.Options);
            action(builder);
            return this;
        }
    }
}
