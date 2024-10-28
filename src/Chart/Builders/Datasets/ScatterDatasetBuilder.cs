using HelperJS.Chart.Models;

namespace HelperJS.Chart.Builders
{
    /// <summary>
    /// Scatter Dataset Configuration.
    /// </summary>
    public class ScatterDatasetBuilder : PointDatasetBuilder<ScatterDatasetBuilder>
    {
        private readonly ScatterDataset _dataset;

        internal ScatterDatasetBuilder(ScatterDataset dataset) : base(dataset)
        {
            _dataset = dataset;
        }
    }
}
