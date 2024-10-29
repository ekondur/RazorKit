using RazorKit.Chart.Models;

namespace RazorKit.Chart.Builders
{
    /// <summary>
    /// Polar Area Dataset Configuration.
    /// </summary>
    public class PolarAreaDatasetBuilder : ArcDatasetBuilder<PolarAreaDatasetBuilder>
    {
        private readonly PolarAreaDataset _dataset;

        internal PolarAreaDatasetBuilder(PolarAreaDataset dataset) : base(dataset)
        {
            _dataset = dataset;
        }

        /// <summary>
        /// By default the Arc is curved. If circular: false the Arc will be flat.
        /// </summary>
        /// <param name="circular"></param>
        /// <returns></returns>
        public PolarAreaDatasetBuilder Circular(bool circular)
        {
            _dataset.Circular = circular;
            return this;
        }
    }
}
