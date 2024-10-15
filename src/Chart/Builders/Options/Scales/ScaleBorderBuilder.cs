using HelperJS.Chart.Models;

namespace HelperJS.Chart.Builders
{
    /// <summary>
    /// ScaleBorder Builder
    /// </summary>
    public class ScaleBorderBuilder
    {
        private readonly ScaleBorder _scaleBorder;

        internal ScaleBorderBuilder(Scale scale)
        {
            scale.Border = _scaleBorder = new ScaleBorder();
        }

        /// <summary>
        /// If true, draw a border at the edge between the axis and the chart area.
        /// Default true
        /// </summary>
        /// <param name="display"></param>
        /// <returns></returns>
        public ScaleBorderBuilder Display(bool display)
        {
            _scaleBorder.Display = display;
            return this;
        }

        /// <summary>
        /// The color of the border line.
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public ScaleBorderBuilder Color(string color)
        {
            _scaleBorder.Color = color;
            return this;
        }

        /// <summary>
        /// The width of the border line. Default 1
        /// </summary>
        /// <param name="width"></param>
        /// <returns></returns>
        public ScaleBorderBuilder Width(int width)
        {
            _scaleBorder.Width = width;
            return this;
        }

        /// <summary>
        /// Length and spacing of dashes on grid lines. Default []
        /// </summary>
        /// <param name="dash"></param>
        /// <returns></returns>
        public ScaleBorderBuilder Dash(params int[] dash)
        {
            _scaleBorder.Dash = dash;
            return this;
        }

        /// <summary>
        /// Offset for line dashes. Default 0.0
        /// </summary>
        /// <param name="dashOffset"></param>
        /// <returns></returns>
        public ScaleBorderBuilder DashOffset(double dashOffset)
        {
            _scaleBorder.DashOffset = dashOffset;
            return this;
        }

        /// <summary>
        /// z-index of the border layer. Values less than equal 0 are drawn under datasets, grater than 0 on top.
        /// Default 0
        /// </summary>
        /// <param name="z"></param>
        /// <returns></returns>
        public ScaleBorderBuilder Z(int z)
        {
            _scaleBorder.Z = z;
            return this;
        }
    }
}
