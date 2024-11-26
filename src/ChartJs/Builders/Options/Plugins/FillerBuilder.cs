using RazorKit.ChartJs.Models;

namespace RazorKit.ChartJs.Builders
{
    /// <summary>
    /// Filler Configuration.
    /// </summary>
    public class FillerBuilder
    {
        private readonly Filler _filler;

        internal FillerBuilder(Filler filler)
        {
            _filler = filler;
        }

        /// <summary>
        /// Fill propagation when target is hidden.
        /// </summary>
        /// <param name="propagate"></param>
        /// <returns></returns>
        public FillerBuilder Propagate(bool propagate)
        {
            _filler.Propagate = propagate;
            return this;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="drawTime"></param>
        /// <returns></returns>
        public FillerBuilder DrawTime(DrawTime drawTime)
        {
            _filler.DrawTime = drawTime;
            return this;
        }
    }
}
