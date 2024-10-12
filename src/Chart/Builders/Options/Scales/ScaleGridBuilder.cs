﻿using HelperJS.Chart.Models;

namespace HelperJS.Chart.Builders
{
    /// <summary>
    /// ScaleGrid Builder
    /// </summary>
    public class ScaleGridBuilder
    {
        private readonly ScaleGrid _scaleGrid;

        internal ScaleGridBuilder(Scale scale)
        {
            scale.Grid = _scaleGrid = new ScaleGrid();
        }

        /// <summary>
        /// If true, gridlines are circular (on radar and polar area charts only). Default false
        /// </summary>
        /// <param name="circular"></param>
        /// <returns></returns>
        public ScaleGridBuilder Circular(bool circular)
        {
            _scaleGrid.Circular = circular;
            return this;
        }

        /// <summary>
        /// The color of the grid lines. If specified as an array, the first color applies to the first grid line,
        /// the second to the second grid line, and so on.
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public ScaleGridBuilder Color(string color)
        {
            _scaleGrid.Color = color;
            return this;
        }

        /// <summary>
        /// If false, do not display grid lines for this axis. Default true
        /// </summary>
        /// <param name="display"></param>
        /// <returns></returns>
        public ScaleGridBuilder Display(bool display)
        {
            _scaleGrid.Display = display;
            return this;
        }

        /// <summary>
        /// If true, draw lines on the chart area inside the axis lines. 
        /// This is useful when there are multiple axes and you need to control which grid lines are drawn.
        /// Default true
        /// </summary>
        /// <param name="drawOnChartArea"></param>
        /// <returns></returns>
        public ScaleGridBuilder DrawOnChartArea(bool drawOnChartArea)
        {
            _scaleGrid.DrawOnChartArea = drawOnChartArea;
            return this;
        }

        /// <summary>
        /// If true, draw lines beside the ticks in the axis area beside the chart. Default true
        /// </summary>
        /// <param name="drawTicks"></param>
        /// <returns></returns>
        public ScaleGridBuilder DrawTicks(bool drawTicks)
        {
            _scaleGrid.DrawTicks = drawTicks;
            return this;
        }

        /// <summary>
        /// Stroke width of grid lines. Default 1
        /// </summary>
        /// <param name="width"></param>
        /// <returns></returns>
        public ScaleGridBuilder LineWidth(int width)
        {
            _scaleGrid.LineWidth = width;
            return this;
        }

        /// <summary>
        /// If true, grid lines will be shifted to be between labels. This is set to true for a bar chart by default.
        /// Default false
        /// </summary>
        /// <param name="offset"></param>
        /// <returns></returns>
        public ScaleGridBuilder Offset(bool offset)
        {
            _scaleGrid.Offset = offset;
            return this;
        }

        /// <summary>
        /// Length and spacing of the tick mark line. If not set, defaults to the grid line borderDash value.
        /// Default []
        /// </summary>
        /// <param name="borderDash"></param>
        /// <returns></returns>
        public ScaleGridBuilder TickBorderDash(params int[] borderDash)
        {
            _scaleGrid.TickBorderDash = borderDash;
            return this;
        }

        /// <summary>
        /// Offset for the line dash of the tick mark. If unset, defaults to the grid line 'borderDashOffset' value.
        /// </summary>
        /// <param name="offset"></param>
        /// <returns></returns>
        public ScaleGridBuilder TickBorderDashOffset(int offset)
        {
            _scaleGrid.TickBorderDashOffset = offset;
            return this;
        }

        /// <summary>
        /// Color of the tick line. If unset, defaults to the grid line color.
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public ScaleGridBuilder TickColor(string color)
        {
            _scaleGrid.TickColor = color;
            return this;
        }

        /// <summary>
        /// Length in pixels that the grid lines will draw into the axis area. Default 8
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
        public ScaleGridBuilder TickLength(int length)
        {
            _scaleGrid.TickLength = length;
            return this;
        }

        /// <summary>
        /// Width of the tick mark in pixels. If unset, defaults to the grid line width.
        /// </summary>
        /// <param name="width"></param>
        /// <returns></returns>
        public ScaleGridBuilder TickWidth(int width)
        {
            _scaleGrid.TickWidth = width;
            return this;
        }

        /// <summary>
        /// z-index of the gridline layer. Values less then equal are drawn under datasets, grater then 0 on top.
        /// Default -1
        /// </summary>
        /// <param name="z"></param>
        /// <returns></returns>
        public ScaleGridBuilder Z(int z)
        {
            _scaleGrid.Z = z;
            return this;
        }
    }
}