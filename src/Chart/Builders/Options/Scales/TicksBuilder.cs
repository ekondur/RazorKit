using RazorKit.Chart.Models;
using System;

namespace RazorKit.Chart.Builders
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
            _scaleTicks.Major = new Major { Enabled = enabled };
            return this;
        }

        /// <summary>
        /// Sets the offset of the tick labels from the axis. Default 3
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
    }
}
