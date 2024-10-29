using RazorKit.Chart.Models;
using System;
using System.Collections.Generic;

namespace RazorKit.Chart.Builders
{
    /// <summary>
    /// Scale Builder
    /// </summary>
    public class ScaleBuilder
    {
        private readonly Scale _scale;

        internal ScaleBuilder(Options options, string id)
        {
            _scale = new Scale();
            if (options.Scales == null)
            {
                options.Scales = new Dictionary<string, Scale>();
            }
            options.Scales.Add(id, _scale);
        }

        #region Common options to all axes
        /// <summary>
        /// Type of scale being employed. Custom scales can be created and registered with a string key. 
        /// This allows changing the type of an axis for a chart.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public ScaleBuilder Type(string type)
        {
            _scale.Type = type;
            return this;
        }

        /// <summary>
        /// Align pixel values to device pixels. Default false
        /// </summary>
        /// <param name="alignToPixels"></param>
        /// <returns></returns>
        public ScaleBuilder AlignToPixels(bool alignToPixels)
        {
            _scale.AlignToPixels = alignToPixels;
            return this;
        }

        /// <summary>
        /// Background color of the scale area.
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public ScaleBuilder BackgroundColor(string color)
        {
            _scale.BackgroundColor = color;
            return this;
        }

        /// <summary>
        /// Border configuration.
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        public ScaleBuilder Border(Action<ScaleBorderBuilder> action)
        {
            var builder = new ScaleBorderBuilder(_scale);
            action(builder);
            return this;
        }

        /// <summary>
        /// Controls the axis global visibility (visible when true, hidden when false).
        /// Default true
        /// </summary>
        /// <param name="display"></param>
        /// <returns></returns>
        public ScaleBuilder Display(bool display)
        {
            _scale.Display = display;
            return this;
        }

        /// <summary>
        /// When display: 'auto', the axis is visible only if at least one associated dataset is visible.
        /// </summary>
        /// <param name="display"></param>
        /// <returns></returns>
        public ScaleBuilder Display(string display)
        {
            _scale.Display = display;
            return this;
        }

        /// <summary>
        /// Grid line configuration.
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        public ScaleBuilder Grid(Action<GridBuilder> action)
        {
            var builder = new GridBuilder(_scale);
            action(builder);
            return this;
        }

        /// <summary>
        /// User defined minimum number for the scale, overrides minimum value from data.
        /// </summary>
        /// <param name="min"></param>
        /// <returns></returns>
        public ScaleBuilder Min(int min)
        {
            _scale.Min = min;
            return this;
        }

        /// <summary>
        /// User defined maximum number for the scale, overrides maximum value from data.
        /// </summary>
        /// <param name="max"></param>
        /// <returns></returns>
        public ScaleBuilder Max(int max)
        {
            _scale.Max = max;
            return this;
        }

        /// <summary>
        /// Reverse the scale. Default false
        /// </summary>
        /// <param name="reverse"></param>
        /// <returns></returns>
        public ScaleBuilder Reverse(bool reverse)
        {
            _scale.Reverse = reverse;
            return this;
        }

        /// <summary>
        /// Should the data be stacked.
        /// </summary>
        /// <param name="stacked"></param>
        /// <returns></returns>
        public ScaleBuilder Stacked(bool stacked)
        {
            _scale.Stacked = stacked;
            return this;
        }

        /// <summary>
        /// For some charts, you might want to stack positive and negative values together. 
        /// That can be achieved by specifying stacked: 'single'.
        /// </summary>
        /// <param name="stacked"></param>
        /// <returns></returns>
        public ScaleBuilder Stacked(string stacked)
        {
            _scale.Stacked = stacked;
            return this;
        }

        /// <summary>
        /// Adjustment used when calculating the maximum data value.
        /// </summary>
        /// <param name="suggestedMax"></param>
        /// <returns></returns>
        public ScaleBuilder SuggestedMax (int suggestedMax)
        {
            _scale.SuggestedMax = suggestedMax;
            return this;
        }

        /// <summary>
        /// Adjustment used when calculating the minimum data value.
        /// </summary>
        /// <param name="suggestedMin"></param>
        /// <returns></returns>
        public ScaleBuilder SuggestedMin(int suggestedMin)
        {
            _scale.SuggestedMin = suggestedMin;
            return this;
        }

        /// <summary>
        /// Tick configuration.
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        public ScaleBuilder Ticks(Action<TicksBuilder> action)
        {
            var builder = new TicksBuilder(_scale);
            action(builder);
            return this;
        }

        /// <summary>
        /// The weight used to sort the axis. Higher weights are further away from the chart area.
        /// Default 0
        /// </summary>
        /// <param name="weight"></param>
        /// <returns></returns>
        public ScaleBuilder Weight(int  weight)
        {
            _scale.Weight = weight;
            return this;
        }

        /// <summary>
        /// There are a number of config callbacks that can be used to change parameters in the scale at different points in the update process. 
        /// The options are supplied at the top level of the axis options.
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        public ScaleBuilder Callbacks(Action<ScaleCallbackBuilder> action)
        {
            var builder = new ScaleCallbackBuilder(_scale);
            action(builder);
            return this;
        }
        #endregion

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
