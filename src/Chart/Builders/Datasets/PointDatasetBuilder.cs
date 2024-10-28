using HelperJS.Chart.Models;
using System;

namespace HelperJS.Chart.Builders
{
    /// <summary>
    /// PointDataset Configuration
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class PointDatasetBuilder<T> : BaseDatasetBuilder<T> where T : PointDatasetBuilder<T>
    {
        private readonly PointDataset _dataset;

        internal PointDatasetBuilder(PointDataset dataset) : base(dataset)
        {
            _dataset = dataset;
        }

        /// <summary>
        /// Cap style of the line.
        /// </summary>
        /// <param name="capStyle"></param>
        /// <returns>The LineDatasetBuilder instance.</returns>
        public T BorderCapStyle(CapStyle capStyle)
        {
            _dataset.BorderCapStyle = capStyle;
            return (T)this;
        }

        /// <summary>
        /// Length and spacing of dashes.
        /// </summary>
        /// <param name="borderDash"></param>
        /// <returns>The LineDatasetBuilder instance.</returns>
        public T BorderDash(params int[] borderDash)
        {
            _dataset.BorderDash = borderDash;
            return (T)this;
        }

        /// <summary>
        /// Offset for line dashes. Default 0.0
        /// </summary>
        /// <param name="borderDashOffset"></param>
        /// <returns>The LineDatasetBuilder instance.</returns>
        public T BorderDashOffset(double borderDashOffset)
        {
            _dataset.BorderDashOffset = borderDashOffset;
            return (T)this;
        }

        /// <summary>
        /// Line joint style.
        /// </summary>
        /// <param name="borderJoinStyle"></param>
        /// <returns>The LineDatasetBuilder instance.</returns>
        public T BorderJoinStyle(JoinStyle borderJoinStyle)
        {
            _dataset.BorderJoinStyle = borderJoinStyle;
            return (T)this;
        }

        /// <summary>
        /// Border cap style when hovered.
        /// </summary>
        /// <param name="capStyle"></param>
        /// <returns>The LineDatasetBuilder instance with the set data.</returns>
        public T HoverBorderCapStyle(CapStyle capStyle)
        {
            _dataset.HoverBorderCapStyle = capStyle;
            return (T)this;
        }

        /// <summary>
        /// Length and spacing of dashes when hovered.
        /// </summary>
        /// <param name="hoverBorderDash"></param>
        /// <returns>The LineDatasetBuilder instance with the set data.</returns>
        public T HoverBorderDash(params int[] hoverBorderDash)
        {
            _dataset.HoverBorderDash = hoverBorderDash;
            return (T)this;
        }

        /// <summary>
        /// Offset for line dashes when hovered.
        /// </summary>
        /// <param name="hoverBorderDashOffset"></param>
        /// <returns>The LineDatasetBuilder instance with the set data.</returns>
        public T HoverBorderDashOffset(double hoverBorderDashOffset)
        {
            _dataset.HoverBorderDashOffset = hoverBorderDashOffset;
            return (T)this;
        }

        /// <summary>
        /// Line joint style when hovered.
        /// </summary>
        /// <param name="hoverBorderJoinStyle"></param>
        /// <returns>The LineDatasetBuilder instance with the set data.</returns>
        public T HoverBorderJoinStyle(JoinStyle hoverBorderJoinStyle)
        {
            _dataset.HoverBorderJoinStyle = hoverBorderJoinStyle;
            return (T)this;
        }

        /// <summary>
        /// How to fill the area under the line. Default false
        /// </summary>
        /// <param name="fill"></param>
        /// <returns>The LineDatasetBuilder instance with the set data.</returns>
        public T Fill(bool fill)
        {
            _dataset.Fill = fill;
            return (T)this;
        }

        /// <summary>
        /// How to fill the area under the line.
        /// </summary>
        /// <param name="fill"></param>
        /// <returns>The LineDatasetBuilder instance with the set data.</returns>
        public T Fill(string fill)
        {
            _dataset.Fill = fill;
            return (T)this;
        }

        /// <summary>
        /// Fill Confgiuration for Area Charts.
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        public T Fill(Action<FillBuilder> action)
        {
            _dataset.Fill = new Fill();
            var builder = new FillBuilder((Fill)_dataset.Fill);
            action(builder);
            return (T)this;
        }

        /// <summary>
        /// The drawing order of dataset. Also affects order for stacking, tooltip and legend.
        /// </summary>
        /// <param name="order"></param>
        /// <returns>The LineDatasetBuilder instance with the set data.</returns>
        public T Order(int order)
        {
            _dataset.Order = order;
            return (T)this;
        }

        /// <summary>
        /// The fill color for points.
        /// </summary>
        /// <param name="color"></param>
        /// <returns>The PointDatasetBuilder instance with the set data.</returns>
        public T PointBackgroundColor(string color)
        {
            _dataset.PointBackgroundColor = color;
            return (T)this;
        }

        /// <summary>
        /// The border color for points.
        /// </summary>
        /// <param name="color"></param>
        /// <returns>The PointDatasetBuilder instance with the set data.</returns>
        public T PointBorderColor(string color)
        {
            _dataset.PointBorderColor = color;
            return (T)this;
        }

        /// <summary>
        /// The width of the point border in pixels. Default 1
        /// </summary>
        /// <param name="width"></param>
        /// <returns>The PointDatasetBuilder instance with the set data.</returns>
        public T PointBorderWidth(int width)
        {
            _dataset.PointBorderWidth = width;
            return (T)this;
        }

        /// <summary>
        /// The pixel size of the non-displayed point that reacts to mouse events. Default 1
        /// </summary>
        /// <param name="radius"></param>
        /// <returns>The PointDatasetBuilder instance with the set data.</returns>
        public T PointHitRadius(int radius)
        {
            _dataset.PointHitRadius = radius;
            return (T)this;
        }

        /// <summary>
        /// Point background color when hovered.
        /// </summary>
        /// <param name="color"></param>
        /// <returns>The PointDatasetBuilder instance with the set data.</returns>
        public T PointHoverBackgroundColor(string color)
        {
            _dataset.PointHoverBackgroundColor = color;
            return (T)this;
        }

        /// <summary>
        /// Point border color when hovered.
        /// </summary>
        /// <param name="color"></param>
        /// <returns>The PointDatasetBuilder instance with the set data.</returns>
        public T PointHoverBorderColor(string color)
        {
            _dataset.PointHoverBorderColor = color;
            return (T)this;
        }

        /// <summary>
        /// Border width of point when hovered. Default 1
        /// </summary>
        /// <param name="width"></param>
        /// <returns>The PointDatasetBuilder instance with the set data.</returns>
        public T PointHoverBorderWidth(int width)
        {
            _dataset.PointHoverBorderWidth = width;
            return (T)this;
        }

        /// <summary>
        /// The radius of the point when hovered. Default 4
        /// </summary>
        /// <param name="radius"></param>
        /// <returns>The PointDatasetBuilder instance with the set data.</returns>
        public T PointHoverRadius(int radius)
        {
            _dataset.PointHoverRadius = radius;
            return (T)this;
        }

        /// <summary>
        /// The radius of the point shape. If set to 0, the point is not rendered. Default 3
        /// </summary>
        /// <param name="radius"></param>
        /// <returns>The PointDatasetBuilder instance with the set data.</returns>
        public T PointRadius(int radius)
        {
            _dataset.PointRadius = radius;
            return (T)this;
        }

        /// <summary>
        /// The rotation of the point in degrees. Default 0
        /// </summary>
        /// <param name="rotation"></param>
        /// <returns>The PointDatasetBuilder instance with the set data.</returns>
        public T PointRotation(int rotation)
        {
            _dataset.PointRotation = rotation;
            return (T)this;
        }


        /// <summary>
        /// Is style of the point enabled?
        /// </summary>
        /// <param name="enabled"></param>
        /// <returns>The LineDatasetBuilder instance with the set data.</returns>
        public T PointStyle(bool enabled)
        {
            _dataset.PointStyle = enabled;
            return (T)this;
        }

        /// <summary>
        /// Style of the point.
        /// </summary>
        /// <param name="pointStyle"></param>
        /// <returns>The LineDatasetBuilder instance with the set data.</returns>
        public T PointStyle(PointStyle pointStyle)
        {
            _dataset.PointStyle = pointStyle;
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
            _dataset.SpanGaps = spanGaps;
            return (T)this;
        }

        /// <summary>
        /// Bezier curve tension of the line. Set to 0 to draw straightlines. This option is ignored if monotone cubic interpolation is used.
        /// </summary>
        /// <param name="tension"></param>
        /// <returns>The LineDatasetBuilder instance with the set data.</returns>
        public T Tension(double tension)
        {
            _dataset.Tension = tension;
            return (T)this;
        }
    }
}
