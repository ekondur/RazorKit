using HelperJS.Chart.Models;

namespace HelperJS.Chart.Builders.Datasets
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
        /// Sets the data for the RadarDatasetBuilder instance.
        /// </summary>
        /// <param name="data">An array of doubles representing the data to be set.</param>
        /// <returns>The LineDatasetBuilder instance with the set data.</returns>
        public RadarDatasetBuilder Data(params double[] data)
        {
            _radarDataset.Data = data;
            return this;
        }
    }
}
