using HelperJS.Chart.Models;

namespace HelperJS.Chart.Builders
{
    /// <summary>
    /// PointDataset Configuration
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class PointDatasetBuilder<T> : BaseDatasetBuilder<T> where T : PointDatasetBuilder<T>
    {
        private readonly PointDataset _pointDataset;

        internal PointDatasetBuilder(PointDataset pointDataset)
            : base(pointDataset)
        {
            _pointDataset = pointDataset;
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
    }
}
