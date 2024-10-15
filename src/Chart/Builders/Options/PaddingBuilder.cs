using HelperJS.Chart.Models;

namespace HelperJS.Chart.Builders
{
    /// <summary>
    /// Padding Builder
    /// </summary>
    public class PaddingBuilder
    {
        private readonly Padding _padding;

        internal PaddingBuilder(Padding padding) 
        {
            _padding = padding;
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

        /// <summary>
        /// This is a shorthand for defining left and right to the same values
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public PaddingBuilder X(int x)
        {
            _padding.Left = x;
            _padding.Right = x;
            return this;
        }

        /// <summary>
        /// This is a shorthand for defining top and bottom to the same values
        /// </summary>
        /// <param name="y"></param>
        /// <returns></returns>
        public PaddingBuilder Y(int y)
        {
            _padding.Top = y;
            _padding.Bottom = y;
            return this;
        }
    }
}
