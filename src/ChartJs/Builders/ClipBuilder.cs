using RazorKit.ChartJs.Models;

namespace RazorKit.ChartJs.Builders
{
    /// <summary>
    /// Clip Configuration.
    /// </summary>
    public class ClipBuilder
    {
        private readonly Clip _clip;

        internal ClipBuilder(Clip clip)
        {
            _clip = clip;
        }

        /// <summary>
        /// Left
        /// </summary>
        /// <param name="left"></param>
        /// <returns></returns>
        public ClipBuilder Left(int left)
        {
            _clip.Left = left;
            return this;
        }

        /// <summary>
        /// Left
        /// </summary>
        /// <param name="left"></param>
        /// <returns></returns>
        public ClipBuilder Left(bool left)
        {
            _clip.Left = left;
            return this;
        }

        /// <summary>
        /// Right
        /// </summary>
        /// <param name="right"></param>
        /// <returns></returns>
        public ClipBuilder Right(int right)
        {
            _clip.Right = right;
            return this;
        }

        /// <summary>
        /// Right
        /// </summary>
        /// <param name="right"></param>
        /// <returns></returns>
        public ClipBuilder Right(bool right)
        {
            _clip.Right = right;
            return this;
        }

        /// <summary>
        /// Top
        /// </summary>
        /// <param name="top"></param>
        /// <returns></returns>
        public ClipBuilder Top(int top)
        {
            _clip.Top = top;
            return this;
        }

        /// <summary>
        /// Top
        /// </summary>
        /// <param name="top"></param>
        /// <returns></returns>
        public ClipBuilder Top(bool top)
        {
            _clip.Top = top;
            return this;
        }

        /// <summary>
        /// Bottom
        /// </summary>
        /// <param name="bottom"></param>
        /// <returns></returns>
        public ClipBuilder Bottom(int bottom)
        {
            _clip.Bottom = bottom;
            return this;
        }

        /// <summary>
        /// Bottom
        /// </summary>
        /// <param name="bottom"></param>
        /// <returns></returns>
        public ClipBuilder Bottom(bool bottom)
        {
            _clip.Bottom = bottom;
            return this;
        }
    }
}
