using RazorKit.ChartJs.Models;
using System.Collections.Generic;

namespace RazorKit.ChartJs.Builders
{
    /// <summary>
    /// Bubble Dataset Configuration.
    /// </summary>
    public class BubbleDatasetBuilder : BaseDatasetBuilder<BubbleDatasetBuilder>
    {
        private readonly BubbleDataset _dataset;

        internal BubbleDatasetBuilder(BubbleDataset dataset) : base(dataset)
        {
            _dataset = dataset;
        }

        /// <summary>
        /// Sets the data for the Dataset.
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public BubbleDatasetBuilder Data(IList<object> data)
        {
            _dataset.Data = data;
            return this;
        }

        /// <summary>
        /// Draw the active bubbles of a dataset over the other bubbles of the dataset. Default true
        /// </summary>
        /// <param name="drawActiveElementsOnTop"></param>
        /// <returns></returns>
        public BubbleDatasetBuilder DrawActiveElementsOnTop(bool drawActiveElementsOnTop)
        {
            _dataset.DrawActiveElementsOnTop = drawActiveElementsOnTop;
            return this;
        }

        /// <summary>
        /// bubble additional radius when hovered (in pixels). Default 4
        /// </summary>
        /// <param name="radius"></param>
        /// <returns></returns>
        public BubbleDatasetBuilder HoverRadius(int radius)
        {
            _dataset.HoverRadius = radius;
            return this;
        }

        /// <summary>
        /// bubble additional radius for hit detection (in pixels). Default 1
        /// </summary>
        /// <param name="radius"></param>
        /// <returns></returns>
        public BubbleDatasetBuilder HitRadius(int radius)
        {
            _dataset.HitRadius = radius;
            return this;
        }

        /// <summary>
        /// The drawing order of dataset. Also affects order for tooltip and legend. Default 0
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public BubbleDatasetBuilder Order(int order)
        {
            _dataset.Order = order;
            return this;
        }

        /// <summary>
        /// Set point style. Default 'circle'
        /// </summary>
        /// <param name="style"></param>
        /// <returns></returns>
        public BubbleDatasetBuilder PointStyle(PointStyle style)
        {
            _dataset.PointStyle = style;
            return this;
        }

        /// <summary>
        /// Is point style enabled?
        /// </summary>
        /// <param name="enabled"></param>
        /// <returns></returns>
        public BubbleDatasetBuilder PointStyle(bool enabled)
        {
            _dataset.PointStyle = enabled;
            return this;
        }

        /// <summary>
        /// bubble rotation (in degrees). Default 0
        /// </summary>
        /// <param name="rotation"></param>
        /// <returns></returns>
        public BubbleDatasetBuilder Rotation(int rotation)
        {
            _dataset.Rotation = rotation;
            return this;
        }

        /// <summary>
        /// bubble radius (in pixels). Default 3
        /// </summary>
        /// <param name="radius"></param>
        /// <returns></returns>
        public BubbleDatasetBuilder Radius(int radius)
        {
            _dataset.Radius = radius;
            return this;
        }
    }
}
