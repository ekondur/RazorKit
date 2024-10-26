using HelperJS.Chart.Models;

namespace HelperJS.Chart.Builders
{
    /// <summary>
    /// PointDataset Configuration
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class PointDatasetBuilder<T> : BaseDatasetBuilder<T> where T : PointDatasetBuilder<T>
    {
        private readonly PointDataset _pointDataset;

        internal PointDatasetBuilder(PointDataset pointDataset)
            : base(pointDataset)
        {
            _pointDataset = pointDataset;
        }

        /// <summary>
        /// Cap style of the line.
        /// </summary>
        /// <param name="capStyle"></param>
        /// <returns>The LineDatasetBuilder instance.</returns>
        public T BorderCapStyle(CapStyle capStyle)
        {
            _pointDataset.BorderCapStyle = capStyle;
            return (T)this;
        }

        /// <summary>
        /// Length and spacing of dashes.
        /// </summary>
        /// <param name="borderDash"></param>
        /// <returns>The LineDatasetBuilder instance.</returns>
        public T BorderDash(params int[] borderDash)
        {
            _pointDataset.BorderDash = borderDash;
            return (T)this;
        }

        /// <summary>
        /// Offset for line dashes. Default 0.0
        /// </summary>
        /// <param name="borderDashOffset"></param>
        /// <returns>The LineDatasetBuilder instance.</returns>
        public T BorderDashOffset(double borderDashOffset)
        {
            _pointDataset.BorderDashOffset = borderDashOffset;
            return (T)this;
        }

        /// <summary>
        /// Line joint style.
        /// </summary>
        /// <param name="borderJoinStyle"></param>
        /// <returns>The LineDatasetBuilder instance.</returns>
        public T BorderJoinStyle(JoinStyle borderJoinStyle)
        {
            _pointDataset.BorderJoinStyle = borderJoinStyle;
            return (T)this;
        }

        /// <summary>
        /// Border cap style when hovered.
        /// </summary>
        /// <param name="capStyle"></param>
        /// <returns>The LineDatasetBuilder instance with the set data.</returns>
        public T HoverBorderCapStyle(CapStyle capStyle)
        {
            _pointDataset.HoverBorderCapStyle = capStyle;
            return (T)this;
        }

        /// <summary>
        /// Length and spacing of dashes when hovered.
        /// </summary>
        /// <param name="hoverBorderDash"></param>
        /// <returns>The LineDatasetBuilder instance with the set data.</returns>
        public T HoverBorderDash(params int[] hoverBorderDash)
        {
            _pointDataset.HoverBorderDash = hoverBorderDash;
            return (T)this;
        }

        /// <summary>
        /// Offset for line dashes when hovered.
        /// </summary>
        /// <param name="hoverBorderDashOffset"></param>
        /// <returns>The LineDatasetBuilder instance with the set data.</returns>
        public T HoverBorderDashOffset(double hoverBorderDashOffset)
        {
            _pointDataset.HoverBorderDashOffset = hoverBorderDashOffset;
            return (T)this;
        }

        /// <summary>
        /// Line joint style when hovered.
        /// </summary>
        /// <param name="hoverBorderJoinStyle"></param>
        /// <returns>The LineDatasetBuilder instance with the set data.</returns>
        public T HoverBorderJoinStyle(JoinStyle hoverBorderJoinStyle)
        {
            _pointDataset.HoverBorderJoinStyle = hoverBorderJoinStyle;
            return (T)this;
        }

        /// <summary>
        /// How to fill the area under the line. Default false
        /// </summary>
        /// <param name="fill"></param>
        /// <returns>The LineDatasetBuilder instance with the set data.</returns>
        public T Fill(bool fill)
        {
            _pointDataset.Fill = fill;
            return (T)this;
        }

        /// <summary>
        /// How to fill the area under the line.
        /// </summary>
        /// <param name="fill"></param>
        /// <returns>The LineDatasetBuilder instance with the set data.</returns>
        public T Fill(string fill)
        {
            _pointDataset.Fill = fill;
            return (T)this;
        }

        /// <summary>
        /// Add a new dataset.
        /// </summary>
        /// <param name="label">The label for the dataset which appears in the legend and tooltips.</param>
        /// <returns>The LineDatasetBuilder instance.</returns>
        public T Label(string label)
        {
            _pointDataset.Label = label;
            return (T)this;
        }

        /// <summary>
        /// The drawing order of dataset. Also affects order for stacking, tooltip and legend.
        /// </summary>
        /// <param name="order"></param>
        /// <returns>The LineDatasetBuilder instance with the set data.</returns>
        public T Order(int order)
        {
            _pointDataset.Order = order;
            return (T)this;
        }

        /// <summary>
        /// The fill color for points.
        /// </summary>
        /// <param name="color"></param>
        /// <returns>The PointDatasetBuilder instance with the set data.</returns>
        public T PointBackgroundColor(string color)
        {
            _pointDataset.PointBackgroundColor = color;
            return (T)this;
        }

        /// <summary>
        /// The border color for points.
        /// </summary>
        /// <param name="color"></param>
        /// <returns>The PointDatasetBuilder instance with the set data.</returns>
        public T PointBorderColor(string color)
        {
            _pointDataset.PointBorderColor = color;
            return (T)this;
        }

        /// <summary>
        /// The width of the point border in pixels. Default 1
        /// </summary>
        /// <param name="width"></param>
        /// <returns>The PointDatasetBuilder instance with the set data.</returns>
        public T PointBorderWidth(int width)
        {
            _pointDataset.PointBorderWidth = width;
            return (T)this;
        }

        /// <summary>
        /// The pixel size of the non-displayed point that reacts to mouse events. Default 1
        /// </summary>
        /// <param name="radius"></param>
        /// <returns>The PointDatasetBuilder instance with the set data.</returns>
        public T PointHitRadius(int radius)
        {
            _pointDataset.PointHitRadius = radius;
            return (T)this;
        }

        /// <summary>
        /// Point background color when hovered.
        /// </summary>
        /// <param name="color"></param>
        /// <returns>The PointDatasetBuilder instance with the set data.</returns>
        public T PointHoverBackgroundColor(string color)
        {
            _pointDataset.PointHoverBackgroundColor = color;
            return (T)this;
        }

        /// <summary>
        /// Point border color when hovered.
        /// </summary>
        /// <param name="color"></param>
        /// <returns>The PointDatasetBuilder instance with the set data.</returns>
        public T PointHoverBorderColor(string color)
        {
            _pointDataset.PointHoverBorderColor = color;
            return (T)this;
        }

        /// <summary>
        /// Border width of point when hovered. Default 1
        /// </summary>
        /// <param name="width"></param>
        /// <returns>The PointDatasetBuilder instance with the set data.</returns>
        public T PointHoverBorderWidth(int width)
        {
            _pointDataset.PointHoverBorderWidth = width;
            return (T)this;
        }

        /// <summary>
        /// The radius of the point when hovered. Default 4
        /// </summary>
        /// <param name="radius"></param>
        /// <returns>The PointDatasetBuilder instance with the set data.</returns>
        public T PointHoverRadius(int radius)
        {
            _pointDataset.PointHoverRadius = radius;
            return (T)this;
        }

        /// <summary>
        /// The radius of the point shape. If set to 0, the point is not rendered. Default 3
        /// </summary>
        /// <param name="radius"></param>
        /// <returns>The PointDatasetBuilder instance with the set data.</returns>
        public T PointRadius(int radius)
        {
            _pointDataset.PointRadius = radius;
            return (T)this;
        }

        /// <summary>
        /// The rotation of the point in degrees. Default 0
        /// </summary>
        /// <param name="rotation"></param>
        /// <returns>The PointDatasetBuilder instance with the set data.</returns>
        public T PointRotation(int rotation)
        {
            _pointDataset.PointRotation = rotation;
            return (T)this;
        }


        /// <summary>
        /// Is style of the point enabled?
        /// </summary>
        /// <param name="enabled"></param>
        /// <returns>The LineDatasetBuilder instance with the set data.</returns>
        public T PointStyle(bool enabled)
        {
            _pointDataset.PointStyle = enabled;
            return (T)this;
        }

        /// <summary>
        /// Style of the point.
        /// </summary>
        /// <param name="pointStyle"></param>
        /// <returns>The LineDatasetBuilder instance with the set data.</returns>
        public T PointStyle(PointStyle pointStyle)
        {
            _pointDataset.PointStyle = pointStyle;
            return (T)this;
        }

        /// <summary>
        /// If true, lines will be drawn between points with no or null data. If false, points with null data will create a break in the line.
        /// Can also be a number specifying the maximum gap length to span. The unit of the value depends on the scale used.
        /// </summary>
        /// <param name="spanGaps"></param>
        /// <returns>The LineDatasetBuilder instance with the set data.</returns>
        public T SpanGaps(bool spanGaps)
        {
            _pointDataset.SpanGaps = spanGaps;
            return (T)this;
        }

        /// <summary>
        /// Bezier curve tension of the line. Set to 0 to draw straightlines. This option is ignored if monotone cubic interpolation is used.
        /// </summary>
        /// <param name="tension"></param>
        /// <returns>The LineDatasetBuilder instance with the set data.</returns>
        public T Tension(double tension)
        {
            _pointDataset.Tension = tension;
            return (T)this;
        }
    }
}
