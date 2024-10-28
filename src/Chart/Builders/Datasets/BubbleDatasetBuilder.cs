using HelperJS.Chart.Models;

namespace HelperJS.Chart.Builders
{
    /// <summary>
    /// Bubble Dataset Configuration.
    /// </summary>
    public class BubbleDatasetBuilder : BaseDatasetBuilder<BubbleDatasetBuilder>
    {
        private readonly BubbleDataset _bubbleDataset;

        internal BubbleDatasetBuilder(BubbleDataset bubbleDataset) : base(bubbleDataset)
        {
            _bubbleDataset = bubbleDataset;
        }

        /// <summary>
        /// Draw the active bubbles of a dataset over the other bubbles of the dataset. Default true
        /// </summary>
        /// <param name="drawActiveElementsOnTop"></param>
        /// <returns></returns>
        public BubbleDatasetBuilder DrawActiveElementsOnTop(bool drawActiveElementsOnTop)
        {
            _bubbleDataset.DrawActiveElementsOnTop = drawActiveElementsOnTop;
            return this;
        }

        /// <summary>
        /// bubble additional radius when hovered (in pixels). Default 4
        /// </summary>
        /// <param name="radius"></param>
        /// <returns></returns>
        public BubbleDatasetBuilder HoverRadius(int radius)
        {
            _bubbleDataset.HoverRadius = radius;
            return this;
        }

        /// <summary>
        /// bubble additional radius for hit detection (in pixels). Default 1
        /// </summary>
        /// <param name="radius"></param>
        /// <returns></returns>
        public BubbleDatasetBuilder HitRadius(int radius)
        {
            _bubbleDataset.HitRadius = radius;
            return this;
        }

        /// <summary>
        /// The label for the dataset which appears in the legend and tooltips.
        /// </summary>
        /// <param name="label"></param>
        /// <returns></returns>
        public BubbleDatasetBuilder Label(string label)
        {
            _bubbleDataset.Label = label;
            return this;
        }

        /// <summary>
        /// The drawing order of dataset. Also affects order for tooltip and legend. Default 0
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public BubbleDatasetBuilder Order(int order)
        {
            _bubbleDataset.Order = order;
            return this;
        }

        /// <summary>
        /// Set point style. Default 'circle'
        /// </summary>
        /// <param name="style"></param>
        /// <returns></returns>
        public BubbleDatasetBuilder PointStyle(PointStyle style)
        {
            _bubbleDataset.PointStyle = style;
            return this;
        }

        /// <summary>
        /// Is point style enabled?
        /// </summary>
        /// <param name="enabled"></param>
        /// <returns></returns>
        public BubbleDatasetBuilder PointStyle(bool enabled)
        {
            _bubbleDataset.PointStyle = enabled;
            return this;
        }

        /// <summary>
        /// bubble rotation (in degrees). Default 0
        /// </summary>
        /// <param name="rotation"></param>
        /// <returns></returns>
        public BubbleDatasetBuilder Rotation(int rotation)
        {
            _bubbleDataset.Rotation = rotation;
            return this;
        }

        /// <summary>
        /// bubble radius (in pixels). Default 3
        /// </summary>
        /// <param name="radius"></param>
        /// <returns></returns>
        public BubbleDatasetBuilder Radius(int radius)
        {
            _bubbleDataset.Radius = radius;
            return this;
        }
    }
}
