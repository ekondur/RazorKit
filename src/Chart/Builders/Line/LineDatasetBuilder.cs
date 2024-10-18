using HelperJS.Chart.Models;
using HelperJS.Chart.Models.Line;
using System;

namespace HelperJS.Chart.Builders.Line
{
    /// <summary>
    /// LineDataset Builder
    /// </summary>
    public class LineDatasetBuilder
    {
        private LineDataset _lineDataset;
        private readonly Data _data;

        internal LineDatasetBuilder(Data data)
        {
            _data = data;
        }

        #region BaseDataset

        /// <summary>
        /// The line fill color.
        /// </summary>
        /// <param name="color"></param>
        /// <returns>The LineDatasetBuilder instance.</returns>
        public LineDatasetBuilder BackgroundColor(string color)
        {
            _lineDataset.BackgroundColor = color;
            return this;
        }

        /// <summary>
        /// The line color.
        /// </summary>
        /// <param name="color"></param>
        /// <returns>The LineDatasetBuilder instance.</returns>
        public LineDatasetBuilder BorderColor(string color)
        {
            _lineDataset.BorderColor = color;
            return this;
        }

        /// <summary>
        /// The line width (in pixels). Default 3
        /// </summary>
        /// <param name="width"></param>
        /// <returns>The LineDatasetBuilder instance.</returns>
        public LineDatasetBuilder BorderWith(int width)
        {
            _lineDataset.BorderWith = width;
            return this;
        }

        /// <summary>
        /// How to clip relative to chartArea. Positive value allows overflow, negative value clips that many pixels inside chartArea.
        /// 0 = clip at chartArea. Clipping can also be configured per side: clip: {left: 5, top: false, right: -2, bottom: 0}
        /// </summary>
        /// <param name="clip"></param>
        /// <returns>The LineDatasetBuilder instance.</returns>
        public LineDatasetBuilder Clip(int clip)
        {
            _lineDataset.Clip = new Clip(clip);
            return this;
        }

        /// <summary>
        /// How to clip relative to chartArea. Positive value allows overflow, negative value clips that many pixels inside chartArea.
        /// 0 = clip at chartArea. Clipping can also be configured per side: clip: {left: 5, top: false, right: -2, bottom: 0}
        /// </summary>
        /// <param name="action"></param>
        /// <returns>The LineDatasetBuilder instance.</returns>
        public LineDatasetBuilder Clip(Action<ClipBuilder> action)
        {
            var builder = new ClipBuilder(_lineDataset);
            action(builder);
            return this;
        }

        /// <summary>
        /// Background color when hovered.
        /// </summary>
        /// <param name="color"></param>
        /// <returns>The LineDatasetBuilder instance with the set data.</returns>
        public LineDatasetBuilder HoverBackgroundColor(string color)
        {
            _lineDataset.HoverBackgroundColor = color;
            return this;
        }

        /// <summary>
        /// Border color when hovered.
        /// </summary>
        /// <param name="color"></param>
        /// <returns>The LineDatasetBuilder instance with the set data.</returns>
        public LineDatasetBuilder HoverBorderColor(string color)
        {
            _lineDataset.HoverBorderColor = color;
            return this;
        }

        /// <summary>
        /// The line width (in pixels) when hovered.
        /// </summary>
        /// <param name="width"></param>
        /// <returns>The LineDatasetBuilder instance with the set data.</returns>
        public LineDatasetBuilder HoverBorderWidth(int width)
        {
            _lineDataset.HoverBorderWidth = width;
            return this;
        }

        /// <summary>
        /// How to parse the dataset. The parsing can be disabled by specifying parsing: false at chart options or dataset. 
        /// If parsing is disabled, data must be sorted and in the formats the associated chart type and scales use internally.
        /// </summary>
        /// <param name="enabled"></param>
        /// <returns></returns>
        public LineDatasetBuilder Parsing(bool enabled)
        {
            _lineDataset.Parsing = enabled;
            return this;
        }

        /// <summary>
        /// Parsing with key.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public LineDatasetBuilder Parsing(string key)
        {
            _lineDataset.Parsing = new Parsing { Key = key };
            return this;
        }

        /// <summary>
        /// Parsing with x and y axis keys.
        /// </summary>
        /// <param name="xAxisKey"></param>
        /// <param name="yAxisKey"></param>
        /// <returns></returns>
        public LineDatasetBuilder Parsing(string xAxisKey, string yAxisKey)
        {
            _lineDataset.Parsing = new Parsing { XAxisKey = xAxisKey, YAxisKey = yAxisKey };
            return this;
        }

        /// <summary>
        /// Configure the visibility of the dataset. Using hidden: true will hide the dataset from being rendered in the Chart.
        /// </summary>
        /// <param name="hidden"></param>
        /// <returns></returns>
        public LineDatasetBuilder Hidden(bool hidden)
        {
            _lineDataset.Hidden = hidden;
            return this;
        }
        #endregion

        #region LinneerDataset

        /// <summary>
        /// Add a new dataset.
        /// </summary>
        /// <param name="label">The label for the dataset which appears in the legend and tooltips.</param>
        /// <returns>The LineDatasetBuilder instance.</returns>
        public LineDatasetBuilder Add(string label)
        {
            _lineDataset = new LineDataset { Label = label };

            _data.Datasets.Add(_lineDataset);

            return this;
        }

        /// <summary>
        /// The drawing order of dataset. Also affects order for stacking, tooltip and legend.
        /// </summary>
        /// <param name="order"></param>
        /// <returns>The LineDatasetBuilder instance with the set data.</returns>
        public LineDatasetBuilder Order(int order)
        {
            _lineDataset.Order = order;
            return this;
        }

        /// <summary>
        /// Style of the point.
        /// </summary>
        /// <param name="pointStyle"></param>
        /// <returns>The LineDatasetBuilder instance with the set data.</returns>
        public LineDatasetBuilder PointStyle(PointStyle pointStyle)
        {
            _lineDataset.PointStyle = pointStyle;
            return this;
        }

        #endregion

        #region PointDataset

        /// <summary>
        /// The fill color for points.
        /// </summary>
        /// <param name="color"></param>
        /// <returns>The LineDatasetBuilder instance with the set data.</returns>
        public LineDatasetBuilder PointBackgroundColor(string color)
        {
            _lineDataset.PointBackgroundColor = color;
            return this;
        }

        /// <summary>
        /// The border color for points.
        /// </summary>
        /// <param name="color"></param>
        /// <returns>The LineDatasetBuilder instance with the set data.</returns>
        public LineDatasetBuilder PointBorderColor(string color)
        {
            _lineDataset.PointBorderColor = color;
            return this;
        }

        /// <summary>
        /// The width of the point border in pixels. Default 1
        /// </summary>
        /// <param name="width"></param>
        /// <returns>The LineDatasetBuilder instance with the set data.</returns>
        public LineDatasetBuilder PointBorderWidth(int width)
        {
            _lineDataset.PointBorderWidth = width;
            return this;
        }

        /// <summary>
        /// The pixel size of the non-displayed point that reacts to mouse events. Default 1
        /// </summary>
        /// <param name="radius"></param>
        /// <returns>The LineDatasetBuilder instance with the set data.</returns>
        public LineDatasetBuilder PointHitRadius(int radius)
        {
            _lineDataset.PointHitRadius = radius;
            return this;
        }

        /// <summary>
        /// Point background color when hovered.
        /// </summary>
        /// <param name="color"></param>
        /// <returns>The LineDatasetBuilder instance with the set data.</returns>
        public LineDatasetBuilder PointHoverBackgroundColor(string color)
        {
            _lineDataset.PointHoverBackgroundColor = color;
            return this;
        }

        /// <summary>
        /// Point border color when hovered.
        /// </summary>
        /// <param name="color"></param>
        /// <returns>The LineDatasetBuilder instance with the set data.</returns>
        public LineDatasetBuilder PointHoverBorderColor(string color)
        {
            _lineDataset.PointHoverBorderColor = color;
            return this;
        }

        /// <summary>
        /// Border width of point when hovered. Default 1
        /// </summary>
        /// <param name="width"></param>
        /// <returns>The LineDatasetBuilder instance with the set data.</returns>
        public LineDatasetBuilder PointHoverBorderWidth(int width)
        {
            _lineDataset.PointHoverBorderWidth = width;
            return this;
        }

        /// <summary>
        /// The radius of the point when hovered. Default 4
        /// </summary>
        /// <param name="radius"></param>
        /// <returns>The LineDatasetBuilder instance with the set data.</returns>
        public LineDatasetBuilder PointHoverRadius(int radius)
        {
            _lineDataset.PointHoverRadius = radius;
            return this;
        }

        /// <summary>
        /// The radius of the point shape. If set to 0, the point is not rendered. Default 3
        /// </summary>
        /// <param name="radius"></param>
        /// <returns>The LineDatasetBuilder instance with the set data.</returns>
        public LineDatasetBuilder PointRadius(int radius)
        {
            _lineDataset.PointRadius = radius;
            return this;
        }

        /// <summary>
        /// The rotation of the point in degrees. Default 0
        /// </summary>
        /// <param name="rotation"></param>
        /// <returns>The LineDatasetBuilder instance with the set data.</returns>
        public LineDatasetBuilder PointRotation(int rotation)
        {
            _lineDataset.PointRotation = rotation;
            return this;
        }

        #endregion

        /// <summary>
        /// Sets the data for the LineDatasetBuilder instance.
        /// </summary>
        /// <param name="data">An array of doubles representing the data to be set.</param>
        /// <returns>The LineDatasetBuilder instance with the set data.</returns>
        public LineDatasetBuilder Data(params object[] data)
        {
            _lineDataset.Data = data;
            return this;
        }

        /// <summary>
        /// Cap style of the line.
        /// </summary>
        /// <param name="capStyle"></param>
        /// <returns>The LineDatasetBuilder instance.</returns>
        public LineDatasetBuilder BorderCapStyle(CapStyle capStyle)
        {
            _lineDataset.BorderCapStyle = capStyle;
            return this;
        }

        /// <summary>
        /// Length and spacing of dashes.
        /// </summary>
        /// <param name="borderDash"></param>
        /// <returns>The LineDatasetBuilder instance.</returns>
        public LineDatasetBuilder BorderDash(params int[] borderDash)
        {
            _lineDataset.BorderDash = borderDash;
            return this;
        }

        /// <summary>
        /// Offset for line dashes. Default 0.0
        /// </summary>
        /// <param name="borderDashOffset"></param>
        /// <returns>The LineDatasetBuilder instance.</returns>
        public LineDatasetBuilder BorderDashOffset(double borderDashOffset)
        {
            _lineDataset.BorderDashOffset = borderDashOffset;
            return this;
        }

        /// <summary>
        /// Line joint style.
        /// </summary>
        /// <param name="borderJoinStyle"></param>
        /// <returns>The LineDatasetBuilder instance.</returns>
        public LineDatasetBuilder BorderJoinStyle(JoinStyle borderJoinStyle)
        {
            _lineDataset.BorderJoinStyle = borderJoinStyle;
            return this;
        }

        /// <summary>
        /// The following interpolation modes are supported, 'default' and 'monotone'.
        /// </summary>
        /// <param name="cubicInterpolationMode"></param>
        /// <returns>The LineDatasetBuilder instance.</returns>
        public LineDatasetBuilder CubicInterpolationMode(string cubicInterpolationMode)
        {
            _lineDataset.CubicInterpolationMode = cubicInterpolationMode;
            return this;
        }

        /// <summary>
        /// Draw the active points of a dataset over the other points of the dataset.
        /// </summary>
        /// <param name="drawActiveElementsOnTop"></param>
        /// <returns>The LineDatasetBuilder instance.</returns>
        public LineDatasetBuilder DrawActiveElementsOnTop(bool drawActiveElementsOnTop)
        {
            _lineDataset.DrawActiveElementsOnTop = drawActiveElementsOnTop;
            return this;
        }

        /// <summary>
        /// How to fill the area under the line.
        /// </summary>
        /// <param name="fill"></param>
        /// <returns>The LineDatasetBuilder instance with the set data.</returns>
        public LineDatasetBuilder Fill(bool fill)
        {
            _lineDataset.Fill = fill;
            return this;
        }

        /// <summary>
        /// Border cap style when hovered.
        /// </summary>
        /// <param name="capStyle"></param>
        /// <returns>The LineDatasetBuilder instance with the set data.</returns>

        public LineDatasetBuilder HoverBorderCapStyle(CapStyle capStyle)
        {
            _lineDataset.HoverBorderCapStyle = capStyle;
            return this;
        }

        /// <summary>
        /// Length and spacing of dashes when hovered.
        /// </summary>
        /// <param name="hoverBorderDash"></param>
        /// <returns>The LineDatasetBuilder instance with the set data.</returns>
        public LineDatasetBuilder HoverBorderDash(params int[] hoverBorderDash)
        {
            _lineDataset.HoverBorderDash = hoverBorderDash;
            return this;
        }

        /// <summary>
        /// Offset for line dashes when hovered.
        /// </summary>
        /// <param name="hoverBorderDashOffset"></param>
        /// <returns>The LineDatasetBuilder instance with the set data.</returns>
        public LineDatasetBuilder HoverBorderDashOffset(double hoverBorderDashOffset)
        {
            _lineDataset.HoverBorderDashOffset = hoverBorderDashOffset;
            return this;
        }

        /// <summary>
        /// Line joint style when hovered.
        /// </summary>
        /// <param name="hoverBorderJoinStyle"></param>
        /// <returns>The LineDatasetBuilder instance with the set data.</returns>
        public LineDatasetBuilder HoverBorderJoinStyle(JoinStyle hoverBorderJoinStyle)
        {
            _lineDataset.HoverBorderJoinStyle = hoverBorderJoinStyle;
            return this;
        }

        /// <summary>
        /// The base axis of the dataset. 'x' for horizontal lines and 'y' for vertical lines.
        /// </summary>
        /// <param name="indexAxis"></param>
        /// <returns>The LineDatasetBuilder instance with the set data.</returns>
        public LineDatasetBuilder IndexAxis(string indexAxis)
        {
            _lineDataset.IndexAxis = indexAxis;
            return this;
        }

        /// <summary>
        /// Line segment styles can be overridden by scriptable options in the segment object.
        /// </summary>
        /// <param name="segment"></param>
        /// <returns>The LineDatasetBuilder instance with the set data.</returns>
        public LineDatasetBuilder Segment(object segment)
        {
            _lineDataset.Segment = segment;
            return this;
        }

        /// <summary>
        /// If false, the line is not drawn for this dataset.
        /// </summary>
        /// <param name="showLine"></param>
        /// <returns>The LineDatasetBuilder instance with the set data.</returns>
        public LineDatasetBuilder ShowLine(bool showLine)
        {
            _lineDataset.ShowLine = showLine;
            return this;
        }

        /// <summary>
        /// If true, lines will be drawn between points with no or null data. If false, points with null data will create a break in the line.
        /// Can also be a number specifying the maximum gap length to span. The unit of the value depends on the scale used.
        /// </summary>
        /// <param name="spanGaps"></param>
        /// <returns>The LineDatasetBuilder instance with the set data.</returns>
        public LineDatasetBuilder SpanGaps(bool spanGaps)
        {
            _lineDataset.SpanGaps = spanGaps;
            return this;
        }

        /// <summary>
        /// The ID of the group to which this dataset belongs to (when stacked, each group will be a separate stack).
        /// </summary>
        /// <param name="stack"></param>
        /// <returns>The LineDatasetBuilder instance with the set data.</returns>
        public LineDatasetBuilder Stack(string stack)
        {
            _lineDataset.Stack = stack;
            return this;
        }

        /// <summary>
        /// If the stepped value is set to anything other than false, 'tension' will be ignored.
        /// </summary>
        /// <param name="stepped"></param>
        /// <returns>The LineDatasetBuilder instance with the set data.</returns>
        public LineDatasetBuilder Stepped(bool stepped)
        {
            _lineDataset.Stepped = stepped;
            return this;
        }

        /// <summary>
        /// Bezier curve tension of the line. Set to 0 to draw straightlines. This option is ignored if monotone cubic interpolation is used.
        /// </summary>
        /// <param name="tension"></param>
        /// <returns>The LineDatasetBuilder instance with the set data.</returns>
        public LineDatasetBuilder Tension(double tension)
        {
            _lineDataset.Tension = tension;
            return this;
        }

        /// <summary>
        /// The ID of the x-axis to plot this dataset on.
        /// </summary>
        /// <param name="xAxisID"></param>
        /// <returns>The LineDatasetBuilder instance with the set data.</returns>
        public LineDatasetBuilder XAxisID(string xAxisID)
        {
            _lineDataset.XAxisID = xAxisID;
            return this;
        }

        /// <summary>
        /// The ID of the y-axis to plot this dataset on.
        /// </summary>
        /// <param name="yAxisID"></param>
        /// <returns>The LineDatasetBuilder instance with the set data.</returns>
        public LineDatasetBuilder YAxisID(string yAxisID)
        {
            _lineDataset.YAxisID = yAxisID;
            return this;
        }
    }
}
