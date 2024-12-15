using RazorKit.ChartJs.Models;

namespace RazorKit.ChartJs.Builders
{
    /// <summary>
    /// BorderWidth Configuration.
    /// </summary>
    public class BorderWidthBuilder
    {
        private readonly BorderWidth _borderWidth;

        internal BorderWidthBuilder(BorderWidth borderWidth)
        {
            _borderWidth = borderWidth;
        }

        /// <summary>
        /// Left
        /// </summary>
        /// <param name="left"></param>
        /// <returns></returns>
        public BorderWidthBuilder Left(int left)
        {
            _borderWidth.Left = left;
            return this;
        }

        /// <summary>
        /// Right
        /// </summary>
        /// <param name="right"></param>
        /// <returns></returns>
        public BorderWidthBuilder Right(int right)
        {
            _borderWidth.Right = right;
            return this;
        }

        /// <summary>
        /// Top
        /// </summary>
        /// <param name="top"></param>
        /// <returns></returns>
        public BorderWidthBuilder Top(int top)
        {
            _borderWidth.Top = top;
            return this;
        }

        /// <summary>
        /// Bottom
        /// </summary>
        /// <param name="bottom"></param>
        /// <returns></returns>
        public BorderWidthBuilder Bottom(int bottom)
        {
            _borderWidth.Bottom = bottom;
            return this;
        }
    }
}
