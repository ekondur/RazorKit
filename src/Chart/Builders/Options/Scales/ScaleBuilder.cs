using HelperJS.Chart.Models;
using System;
using System.Collections.Generic;

namespace HelperJS.Chart.Builders
{
    /// <summary>
    /// Scale Builder
    /// </summary>
    public class ScaleBuilder
    {
        private readonly Options _options;
        private readonly Scale _scale;

        internal ScaleBuilder(Options options, string id)
        {
            _options = options;
            _scale = new Scale();
            if (_options.Scales == null)
            {
                _options.Scales = new Dictionary<string, Scale>();
            }
            _options.Scales.Add(id, _scale);
        }

        #region Linear Axis specific options
        /// <summary>
        /// if true, scale will include 0 if it is not already included.
        /// </summary>
        /// <param name="beginAtZero"></param>
        /// <returns></returns>
        public ScaleBuilder BeginAtZero(bool beginAtZero)
        {
            _scale.BeginAtZero = beginAtZero;
            return this;
        }

        /// <summary>
        /// Percentage (string ending with %) for added room in the scale range above and below data.
        /// </summary>
        /// <param name="grace"></param>
        /// <returns></returns>
        public ScaleBuilder Grace(string grace)
        {
            _scale.Grace = grace;
            return this;
        }
        #endregion

        #region Common options to all cartesian axes
        /// <summary>
        /// Amount (number) for added room in the scale range above and below data.
        /// </summary>
        /// <param name="grace"></param>
        /// <returns></returns>
        public ScaleBuilder Grace(int grace)
        {
            _scale.Grace = grace;
            return this;
        }

        /// <summary>
        /// Determines the scale bounds. Default 'ticks'
        /// </summary>
        /// <param name="bounds"></param>
        /// <returns></returns>
        public ScaleBuilder Bounds(Bounds bounds)
        {
            _scale.Bounds = bounds;
            return this;
        }

        /// <summary>
        /// If true, clip the dataset drawing against the size of the scale instead of chart area.
        /// Default true
        /// </summary>
        /// <param name="clip"></param>
        /// <returns></returns>
        public ScaleBuilder Clip(bool clip)
        {
            _scale.Clip = clip;
            return this;
        }

        /// <summary>
        /// Position of the axis.
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public ScaleBuilder Position(AxisPosition position)
        {
            _scale.Position = position;
            return this;
        }

        /// <summary>
        /// Stack group. Axes at the same position with same stack are stacked.
        /// </summary>
        /// <param name="stack"></param>
        /// <returns></returns>
        public ScaleBuilder Stack(string stack)
        {
            _scale.Stack = stack;
            return this;
        }

        /// <summary>
        /// Weight of the scale in stack group. Used to determine the amount of allocated space for the scale within the group.
        /// Default 1
        /// </summary>
        /// <param name="weight"></param>
        /// <returns></returns>
        public ScaleBuilder StackWeight(int weight)
        {
            _scale.StackWeight = weight;
            return this;
        }

        /// <summary>
        /// Which type of axis this is. Possible values are: 'x', 'y'. 
        /// If not set, this is inferred from the first character of the ID which should be 'x' or 'y'.
        /// </summary>
        /// <param name="axis"></param>
        /// <returns></returns>
        public ScaleBuilder Axis(string axis)
        {
            _scale.Axis = axis;
            return this;
        }

        /// <summary>
        /// If true, extra space is added to the both edges and the axis is scaled to fit into the chart area.
        /// This is set to true for a bar chart by default, for others false.
        /// </summary>
        /// <param name="offset"></param>
        /// <returns></returns>
        public ScaleBuilder Offset(bool offset)
        {
            _scale.Offset = offset;
            return this;
        }

        /// <summary>
        /// Scale title configuration.
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        public ScaleBuilder Title(Action<ScaleTitleBuilder> action)
        {
            var builder = new ScaleTitleBuilder(_scale);
            action(builder);
            return this;
        }
        #endregion
    }
}
