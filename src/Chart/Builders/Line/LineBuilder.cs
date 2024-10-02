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
            var builder = new LineDataBuilder(Chart);
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
            var builder = new OptionsBuilder(Chart);
            action(builder);
            return this;
        }
    }
}
