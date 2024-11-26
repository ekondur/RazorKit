using RazorKit.ChartJs.Models;

namespace RazorKit.ChartJs.Builders
{
    /// <summary>
    /// Fill Configuration.
    /// </summary>
    public class FillBuilder
    {
        private readonly Fill _fill;

        internal FillBuilder(Fill fill)
        {
            _fill = fill;
        }

        /// <summary>
        /// Axis value.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public FillBuilder Value(int value)
        {
            _fill.Value = value;
            return this;
        }

        /// <summary>
        /// The accepted values are the same as the filling mode values, so you may use absolute and relative dataset indexes and/or boundaries.
        /// </summary>
        /// <param name="target"></param>
        /// <returns></returns>
        public FillBuilder Target(int target)
        {
            _fill.Target = target;
            return this;
        }

        /// <summary>
        /// The accepted values are the same as the filling mode values, so you may use absolute and relative dataset indexes and/or boundaries.
        /// </summary>
        /// <param name="target"></param>
        /// <returns></returns>
        public FillBuilder Target(string target)
        {
            _fill.Target = target;
            return this;
        }

        /// <summary>
        /// The accepted values are the same as the filling mode values, so you may use absolute and relative dataset indexes and/or boundaries.
        /// </summary>
        /// <param name="target"></param>
        /// <returns></returns>
        public FillBuilder Target(bool target)
        {
            _fill.Target = target;
            return this;
        }

        /// <summary>
        /// The accepted values are the same as the filling mode values, so you may use absolute and relative dataset indexes and/or boundaries.
        /// </summary>
        /// <param name="target"></param>
        /// <returns></returns>
        public FillBuilder Target(object target)
        {
            _fill.Target = target;
            return this;
        }

        /// <summary>
        /// If no color is set, the default color will be the background color of the chart.
        /// </summary>
        /// <param name="above"></param>
        /// <returns></returns>
        public FillBuilder Above(string above)
        {
            _fill.Above = above;
            return this;
        }

        /// <summary>
        /// If no color is set, the default color will be the background color of the chart.
        /// </summary>
        /// <param name="below"></param>
        /// <returns></returns>
        public FillBuilder Below(string below)
        {
            _fill.Below = below;
            return this;
        }
    }
}
