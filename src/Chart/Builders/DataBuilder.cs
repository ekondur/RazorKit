using HelperJS.Chart.Models;
using System;

namespace HelperJS.Chart.Builders
{
    /// <summary>
    /// Data Configuration.
    /// </summary>
    public class DataBuilder
    {
        private readonly ChartJs _chart;

        internal DataBuilder(ChartJs chart)
        {
            _chart = chart;
        }

        /// <summary>
        /// Assigns labels to represent data.
        /// </summary>
        /// <param name="labels">An array of labels to assign.</param>
        /// <returns>Returns the LineDataBuilder object with assigned labels.</returns>
        public DataBuilder Labels(params string[] labels)
        {
            _chart.Data.Labels = labels;
            return this;
        }

        /// <summary>
        /// Configure datasets.
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        public DataBuilder Datasets(Action<DatasetsBuilder> action)
        {
            var builder = new DatasetsBuilder(_chart);
            action(builder);
            return this;
        }
    }
}
