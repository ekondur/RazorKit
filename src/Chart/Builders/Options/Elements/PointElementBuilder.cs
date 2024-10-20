using HelperJS.Chart.Models;

namespace HelperJS.Chart.Builders
{
    /// <summary>
    /// Point Element Configuration.
    /// </summary>
    public class PointElementBuilder : BaseElementBuilder<PointElementBuilder>
    {
        private readonly PointElement _pointElement;

        internal PointElementBuilder(PointElement pointElement) 
            : base(pointElement)
        {
            _pointElement = pointElement;
        }

        /// <summary>
        /// Point radius.
        /// </summary>
        /// <param name="radius"></param>
        /// <returns></returns>
        public PointElementBuilder Radius(int radius)
        {
            _pointElement.Radius = radius;
            return this;
        }

        /// <summary>
        /// Is point style enabled.
        /// </summary>
        /// <param name="enabled"></param>
        /// <returns></returns>
        public PointElementBuilder PointStyle(bool enabled)
        {
            _pointElement.PointStyle = enabled;
            return this;
        }

        /// <summary>
        /// Point style.
        /// </summary>
        /// <param name="style"></param>
        /// <returns></returns>
        public PointElementBuilder PointStyle(PointStyle style)
        {
            _pointElement.PointStyle = style;
            return this;
        }

        /// <summary>
        /// Point rotation (in degrees). Default 0
        /// </summary>
        /// <param name="rotation"></param>
        /// <returns></returns>
        public PointElementBuilder Rotation(int rotation)
        {
            _pointElement.Rotation = rotation;
            return this;
        }

        /// <summary>
        /// Extra radius added to point radius for hit detection. Default 1
        /// </summary>
        /// <param name="radius"></param>
        /// <returns></returns>
        public PointElementBuilder HitRadius(int radius)
        {
            _pointElement.HitRadius = radius;
            return this;
        }

        /// <summary>
        /// Point radius when hovered.. Default 4
        /// </summary>
        /// <param name="radius"></param>
        /// <returns></returns>
        public PointElementBuilder HoverRadius(int radius)
        {
            _pointElement.HoverRadius = radius;
            return this;
        }

        /// <summary>
        /// Stroke width when hovered. Default 1
        /// </summary>
        /// <param name="width"></param>
        /// <returns></returns>
        public PointElementBuilder HoverBorderWidth(int width)
        {
            _pointElement.HoverBorderWidth = width;
            return this;
        }
    }
}
