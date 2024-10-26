using HelperJS.Chart.Models;

namespace HelperJS.Chart.Builders
{
    /// <summary>
    /// LineDataset Builder
    /// </summary>
    public class LineDatasetBuilder : PointDatasetBuilder<LineDatasetBuilder>
    {
        private LineDataset _lineDataset;

        internal LineDatasetBuilder(LineDataset lineDataset)
            : base(lineDataset)
        {
            _lineDataset = lineDataset;
        }

        /// <summary>
        /// Add a new dataset.
        /// </summary>
        /// <param name="label">The label for the dataset which appears in the legend and tooltips.</param>
        /// <returns>The LineDatasetBuilder instance.</returns>
        public LineDatasetBuilder Label(string label)
        {
            _lineDataset.Label = label;
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
        /// Is style of the point enabled?
        /// </summary>
        /// <param name="enabled"></param>
        /// <returns>The LineDatasetBuilder instance with the set data.</returns>
        public LineDatasetBuilder PointStyle(bool enabled)
        {
            _lineDataset.PointStyle = enabled;
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
        /// How to fill the area under the line. Default false
        /// </summary>
        /// <param name="fill"></param>
        /// <returns>The LineDatasetBuilder instance with the set data.</returns>
        public LineDatasetBuilder Fill(bool fill)
        {
            _lineDataset.Fill = fill;
            return this;
        }

        /// <summary>
        /// How to fill the area under the line.
        /// </summary>
        /// <param name="fill"></param>
        /// <returns>The LineDatasetBuilder instance with the set data.</returns>
        public LineDatasetBuilder Fill(string fill)
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
