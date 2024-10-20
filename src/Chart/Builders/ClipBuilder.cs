using HelperJS.Chart.Models;

namespace HelperJS.Chart.Builders
{
    /// <summary>
    /// Clip Builder
    /// </summary>
    public class ClipBuilder
    {
        private readonly BaseDataset _dataset;
        private readonly Clip _clip;

        internal ClipBuilder(BaseDataset dataset)
        {
            _dataset = dataset;
            _dataset.Clip = _clip = new Clip();
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
        /// Bottom
        /// </summary>
        /// <param name="bottom"></param>
        /// <returns></returns>
        public ClipBuilder Bottom(int bottom)
        {
            _clip.Bottom = bottom;
            return this;
        }
    }
}
