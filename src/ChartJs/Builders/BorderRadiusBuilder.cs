using RazorKit.ChartJs.Models;

namespace RazorKit.ChartJs.Builders
{
    /// <summary>
    /// BorderRadius Configuration.
    /// </summary>
    public class BorderRadiusBuilder
    {
        private readonly BorderRadius _borderRadius;

        internal BorderRadiusBuilder(BorderRadius borderRadius)
        {
            _borderRadius = borderRadius;
        }

        /// <summary>
        /// TopLeft
        /// </summary>
        /// <param name="topLeft"></param>
        /// <returns></returns>
        public BorderRadiusBuilder TopLeft(int topLeft)
        {
            _borderRadius.TopLeft = topLeft;
            return this;
        }

        /// <summary>
        /// TopRight
        /// </summary>
        /// <param name="topRight"></param>
        /// <returns></returns>
        public BorderRadiusBuilder TopRight(int topRight)
        {
            _borderRadius.TopRight = topRight;
            return this;
        }

        /// <summary>
        /// BottomLeft
        /// </summary>
        /// <param name="bottomLeft"></param>
        /// <returns></returns>
        public BorderRadiusBuilder BottomLeft(int bottomLeft)
        {
            _borderRadius.BottomLeft = bottomLeft;
            return this;
        }

        /// <summary>
        /// BottomRight
        /// </summary>
        /// <param name="bottomRight"></param>
        /// <returns></returns>
        public BorderRadiusBuilder BottomRight(int bottomRight)
        {
            _borderRadius.BottomRight = bottomRight;
            return this;
        }
    }
}
