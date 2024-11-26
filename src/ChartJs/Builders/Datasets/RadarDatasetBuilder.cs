using RazorKit.ChartJs.Models;

namespace RazorKit.ChartJs.Builders.Datasets
{
    /// <summary>
    /// Radar Dataset Configuration
    /// </summary>
    public class RadarDatasetBuilder : PointDatasetBuilder<RadarDatasetBuilder>
    {
        private readonly RadarDataset _radarDataset;

        internal RadarDatasetBuilder(RadarDataset radarDataset) 
            : base(radarDataset)
        {
            _radarDataset = radarDataset;
        }

        /// <summary>
        /// Sets the data for the Radar Dataset.
        /// </summary>
        /// <param name="data">An array of doubles representing the data to be set.</param>
        /// <returns></returns>
        public RadarDatasetBuilder Data(params double[] data)
        {
            _radarDataset.Data = data;
            return this;
        }
    }
}
