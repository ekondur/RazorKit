using RazorKit.ChartJs.Models;
using System;

namespace RazorKit.ChartJs.Builders
{
    /// <summary>
    /// Ticks Builder
    /// </summary>
    public class TicksBuilder
    {
        private readonly Ticks _scaleTicks;

        internal TicksBuilder(Scale scale)
        {
            scale.Ticks = _scaleTicks = new Ticks();
        }

        #region Common tick options to all axes
        /// <summary>
        /// Color of label backdrops.
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public TicksBuilder BackdropColor(string color)
        {
            _scaleTicks.BackdropColor = color;
            return this;
        }

        /// <summary>
        /// Padding of label backdrop. Default 2
        /// </summary>
        /// <param name="padding"></param>
        /// <returns></returns>
        public TicksBuilder BackdropPadding(int padding)
        {
            _scaleTicks.BackdropPadding = new Padding(padding);
            return this;
        }

        /// <summary>
        /// Padding Configuration.
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        public TicksBuilder BackdropPadding(Action<PaddingBuilder> action)
        {
            _scaleTicks.BackdropPadding = new Padding();
            var builder = new PaddingBuilder(_scaleTicks.BackdropPadding);
            action(builder);
            return this;
        }

        /// <summary>
        /// Returns the string representation of the tick value as it should be displayed on the chart.
        /// </summary>
        /// <param name="callback">function name</param>
        /// <returns></returns>
        public TicksBuilder Callback(string callback)
        {
            _scaleTicks.Callback = callback;
            return this;
        }

        /// <summary>
        /// If true, show tick labels. Default true
        /// </summary>
        /// <param name="display"></param>
        /// <returns></returns>
        public TicksBuilder Display(bool display)
        {
            _scaleTicks.Display = display;
            return this;
        }

        /// <summary>
        /// Color of ticks.
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public TicksBuilder Color(string color)
        {
            _scaleTicks.Color = color;
            return this;
        }

        /// <summary>
        /// Font Configuration.
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        public TicksBuilder Font(Action<FontBuilder> action)
        {
            _scaleTicks.Font = new ChartFont();
            var builder = new FontBuilder(_scaleTicks.Font);
            action(builder);
            return this;
        }

        /// <summary>
        /// If true, major ticks are generated. 
        /// A major tick will affect autoskipping and major will be defined on ticks in the scriptable options context.
        /// Default false
        /// </summary>
        /// <param name="enabled"></param>
        /// <returns></returns>
        public TicksBuilder Major(bool enabled)
        {
            _scaleTicks.Major = new TicksMajor { Enabled = enabled };
            return this;
        }

        /// <summary>
        /// Sets the offset of the tick labels from the axis. Default 3 for all axes 0 for cartesian axes.
        /// </summary>
        /// <param name="padding"></param>
        /// <returns></returns>
        public TicksBuilder Padding(int padding)
        {
            _scaleTicks.Padding = padding;
            return this;
        }

        /// <summary>
        /// If true, draw a background behind the tick labels.
        /// Default is true for radial scale, false otherwise.
        /// </summary>
        /// <param name="show"></param>
        /// <returns></returns>
        public TicksBuilder ShowLabelBackdrop(bool show)
        {
            _scaleTicks.ShowLabelBackdrop = show;
            return this;
        }

        /// <summary>
        /// The color of the stroke around the text.
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public TicksBuilder TextStrokeColor(string color)
        {
            _scaleTicks.TextStrokeColor = color;
            return this;
        }

        /// <summary>
        /// Stroke width around the text. Default 0
        /// </summary>
        /// <param name="width"></param>
        /// <returns></returns>
        public TicksBuilder TextStrokeWidth(int width)
        {
            _scaleTicks.TextStrokeWidth = width;
            return this;
        }

        /// <summary>
        /// z-index of tick layer. Useful when ticks are drawn on chart area. 
        /// Values less than equal 0 are drawn under datasets, grater than 0 on top
        /// </summary>
        /// <param name="z"></param>
        /// <returns></returns>
        public TicksBuilder Z(int z)
        {
            _scaleTicks.Z = z;
            return this;
        }
        #endregion

        #region Common tick options to all cartesian axes
        /// <summary>
        /// The tick alignment along the axis. 'inner' alignment means align 'start' for first tick and 'end' for the last tick of horizontal axis.
        /// Default 'center'
        /// </summary>
        /// <param name="align"></param>
        /// <returns></returns>
        public TicksBuilder Align(TicksAlign align)
        {
            _scaleTicks.Align = align;
            return this;
        }

        /// <summary>
        /// The tick alignment perpendicular to the axis. Default 'near'
        /// </summary>
        /// <param name="align"></param>
        /// <returns></returns>
        public TicksBuilder CrossAlign(TicksCrossAlign align)
        {
            _scaleTicks.CrossAlign = align;
            return this;
        }

        /// <summary>
        /// The number of ticks to examine when deciding how many labels will fit. 
        /// Setting a smaller value will be faster, but may be less accurate when there is large variability in label length.
        /// Default ticks.length
        /// </summary>
        /// <param name="size"></param>
        /// <returns></returns>
        public TicksBuilder SampleSize(int size)
        {
            _scaleTicks.SampleSize = size;
            return this;
        }

        /// <summary>
        /// If true, automatically calculates how many labels can be shown and hides labels accordingly. 
        /// Labels will be rotated up to maxRotation before skipping any. Turn autoSkip off to show all labels no matter what.
        /// Default true
        /// </summary>
        /// <param name="autoSkip"></param>
        /// <returns></returns>
        public TicksBuilder AutoSkip(bool autoSkip)
        {
            _scaleTicks.AutoSkip = autoSkip;
            return this;
        }

        /// <summary>
        /// Padding between the ticks on the horizontal axis when autoSkip is enabled. Default 3
        /// </summary>
        /// <param name="padding"></param>
        /// <returns></returns>
        public TicksBuilder AutoSkipPadding(int padding)
        {
            _scaleTicks.AutoSkipPadding = padding;
            return this;
        }

        /// <summary>
        /// Should the defined min and max values be presented as ticks even if they are not "nice". Default true
        /// </summary>
        /// <param name="includeBounds"></param>
        /// <returns></returns>
        public TicksBuilder IncludeBounds(bool includeBounds)
        {
            _scaleTicks.IncludeBounds = includeBounds;
            return this;
        }

        /// <summary>
        /// Distance in pixels to offset the label from the centre point of the tick (in the x-direction for the x-axis, and the y-direction for the y-axis). 
        /// Note: this can cause labels at the edges to be cropped by the edge of the canvas. Default 0
        /// </summary>
        /// <param name="offset"></param>
        /// <returns></returns>
        public TicksBuilder LabelOffset(int offset)
        {
            _scaleTicks.LabelOffset = offset;
            return this;
        }

        /// <summary>
        /// Maximum rotation for tick labels when rotating to condense labels. Note: Rotation doesn't occur until necessary. Note: Only applicable to horizontal scales.
        /// Default 50
        /// </summary>
        /// <param name="maxRotation"></param>
        /// <returns></returns>
        public TicksBuilder MaxRotation(int maxRotation)
        {
            _scaleTicks.MaxRotation = maxRotation;
            return this;
        }

        /// <summary>
        /// Minimum rotation for tick labels. Note: Only applicable to horizontal scales. Default 0
        /// </summary>
        /// <param name="minRotation"></param>
        /// <returns></returns>
        public TicksBuilder MinRotation(int minRotation)
        {
            _scaleTicks.MinRotation = minRotation;
            return this;
        }

        /// <summary>
        /// Flips tick labels around axis, displaying the labels inside the chart instead of outside. Note: Only applicable to vertical scales.
        /// Default false
        /// </summary>
        /// <param name="mirror"></param>
        /// <returns></returns>
        public TicksBuilder Mirror(bool mirror)
        {
            _scaleTicks.Mirror = mirror;
            return this;
        }

        /// <summary>
        /// Maximum number of ticks and gridlines to show. Default 11
        /// </summary>
        /// <param name="maxTicksLimit"></param>
        /// <returns></returns>
        public TicksBuilder MaxTicksLimit(int maxTicksLimit)
        {
            _scaleTicks.MaxTicksLimit = maxTicksLimit;
            return this;
        }

        #endregion
    }
}
