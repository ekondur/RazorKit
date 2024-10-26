﻿using HelperJS.Chart.Builders.Datasets;
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
        /// Add a Line Chart.
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
        /// Add a Radar Chart.
        /// </summary>
        /// <returns></returns>
        public RadarDatasetBuilder Radar()
        {
            var dataset = new RadarDataset { Type = "radar" };
            _data.Datasets.Add(dataset);
            var builder = new RadarDatasetBuilder(dataset);
            return builder;
        }

        /// <summary>
        /// Add a Bar Chart.
        /// </summary>
        /// <returns></returns>
        public BarDatasetBuilder Bar()
        {
            var dataset = new BarDataset { Type = "bar" };
            _data.Datasets.Add(dataset);
            var builder = new BarDatasetBuilder(dataset);
            return builder;
        }
    }
}
