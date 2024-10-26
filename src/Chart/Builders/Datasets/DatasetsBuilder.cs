using HelperJS.Chart.Builders.Datasets;
using HelperJS.Chart.Models;

namespace HelperJS.Chart.Builders
{
    /// <summary>
    /// Datasets Configuration.
    /// </summary>
    public class DatasetsBuilder
    {
        private readonly Data _data;

        internal DatasetsBuilder(Data data)
        {
            _data = data;
        }

        /// <summary>
        /// Line Configuration.
        /// </summary>
        /// <returns></returns>
        public LineDatasetBuilder Line()
        {
            var dataset = new LineDataset { Type = "line" };
            _data.Datasets.Add(dataset);
            var builder = new LineDatasetBuilder(dataset);
            return builder;
        }

        /// <summary>
        /// Radar Configuration.
        /// </summary>
        /// <returns></returns>
        public RadarDatasetBuilder Radar()
        {
            var dataset = new RadarDataset { Type = "radar" };
            _data.Datasets.Add(dataset);
            var builder = new RadarDatasetBuilder(dataset);
            return builder;
        }
    }
}
