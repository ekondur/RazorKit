using HelperJS.Chart.Models;

namespace HelperJS.Chart.Builders
{
    /// <summary>
    /// Padding Builder
    /// </summary>
    public class PaddingBuilder
    {
        private readonly ChartJs _chart;
        private readonly Padding _padding;

        internal PaddingBuilder(ChartJs chart, PaddingSource source)
        {
            _chart = chart;

            switch (source)
            {
                case PaddingSource.Layout:
                    _padding = _chart.Options.Layout.Padding = new Padding();
                    break;
                case PaddingSource.Tooltip:
                    _padding = _chart.Options.Plugins.Tooltip.Padding = new Padding();
                    break;
                case PaddingSource.Title:
                    _padding = _chart.Options.Plugins.Title.Padding = new Padding();
                    break;
                case PaddingSource.LegendTitle:
                    _padding = _chart.Options.Plugins.Legend.Title.Padding = new Padding();
                    break;
            }
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
