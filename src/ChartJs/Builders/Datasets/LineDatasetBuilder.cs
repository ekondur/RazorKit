using RazorKit.ChartJs.Models;

namespace RazorKit.ChartJs.Builders
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
