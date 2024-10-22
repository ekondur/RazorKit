using HelperJS.Chart.Models;
using HelperJS.Chart.Models.Datasets;

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
            var lineDataset = new LineDataset { Type = "line" };
            _data.Datasets.Add(lineDataset);
            var builder = new LineDatasetBuilder(lineDataset);
            return builder;
        }
    }
}
