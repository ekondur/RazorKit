using HelperJS.Chart.Models;
using HelperJS.Chart.Models.Line;

namespace HelperJS.Chart.Builders
{
    /// <summary>
    /// Datasets Configuration.
    /// </summary>
    public class DatasetsBuilder
    {
        private readonly ChartJs _chart;

        internal DatasetsBuilder(ChartJs chart)
        {
            _chart = chart;
        }

        /// <summary>
        /// Line Configuration.
        /// </summary>
        /// <returns></returns>
        public LineDatasetBuilder Line()
        {
            _chart.Type = "line";
            var lineDataset = new LineDataset();
            _chart.Data.Datasets.Add(lineDataset);
            var builder = new LineDatasetBuilder(lineDataset);
            return builder;
        }
    }
}
