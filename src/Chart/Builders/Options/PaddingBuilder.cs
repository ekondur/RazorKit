using HelperJS.Chart.Models;

namespace HelperJS.Chart.Builders
{
    public class PaddingBuilder
    {
        private readonly ChartJs _chart;
        private readonly Padding _padding;

        public PaddingBuilder(ChartJs chart)
        {
            _chart = chart;
            _padding = _chart.Options.Plugins.Tooltip.Padding = new Padding();
        }

        /// <summary>
        /// Left
        /// </summary>
        /// <param name="left"></param>
        /// <returns></returns>
        public PaddingBuilder Left(int left)
        {
            _padding.Left = left;
            return this;
        }

        /// <summary>
        /// Right
        /// </summary>
        /// <param name="right"></param>
        /// <returns></returns>
        public PaddingBuilder Right(int right)
        {
            _padding.Right = right;
            return this;
        }

        /// <summary>
        /// Top
        /// </summary>
        /// <param name="top"></param>
        /// <returns></returns>
        public PaddingBuilder Top(int top)
        {
            _padding.Top = top;
            return this;
        }

        /// <summary>
        /// Bottom
        /// </summary>
        /// <param name="bottom"></param>
        /// <returns></returns>
        public PaddingBuilder Bottom(int bottom)
        {
            _padding.Bottom = bottom;
            return this;
        }
    }
}
