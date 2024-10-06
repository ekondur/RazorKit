using HelperJS.Chart.Models;
using System;

namespace HelperJS.Chart.Builders.Line
{
    /// <summary>
    /// Line Builder
    /// </summary>
    public class LineBuilder : ChartBuilder
    {
        /// <summary>
        /// Configure data.
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        public LineBuilder Data(Action<LineDataBuilder> action)
        {
            Chart.Data = new Data();
            var builder = new LineDataBuilder(Chart.Data);
            action(builder);
            return this;
        }

        /// <summary>
        /// Configure options.
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        public LineBuilder Options(Action<OptionsBuilder> action)
        {
            Chart.Options = new Options();
            var builder = new OptionsBuilder(Chart.Options);
            action(builder);
            return this;
        }
    }
}
