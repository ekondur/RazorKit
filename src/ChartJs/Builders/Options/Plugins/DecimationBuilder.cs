using RazorKit.ChartJs.Models;

namespace RazorKit.ChartJs.Builders
{
    /// <summary>
    /// Decimal Configuration
    /// </summary>
    public class DecimationBuilder
    {
        private readonly Decimation _decimation;

        internal DecimationBuilder(Decimation decimation)
        {
            _decimation = decimation;
        }

        /// <summary>
        /// Is decimation enabled?
        /// </summary>
        /// <param name="enabled"></param>
        /// <returns></returns>
        public DecimationBuilder Enabled(bool enabled)
        {
            _decimation.Enabled = enabled;
            return this;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="algorithm"></param>
        /// <returns></returns>
        public DecimationBuilder Algorithm(Algorithm algorithm)
        {
            _decimation.Algorithm = algorithm;
            return this;
        }

        /// <summary>
        /// If the 'lttb' algorithm is used, this is the number of samples in the output dataset. 
        /// Defaults to the canvas width to pick 1 sample per pixel.
        /// </summary>
        /// <param name="samples"></param>
        /// <returns></returns>
        public DecimationBuilder Samples(int samples)
        {
            _decimation.Samples = samples;
            return this;
        }

        /// <summary>
        /// If the number of samples in the current axis range is above this value, the decimation will be triggered. 
        /// Defaults to 4 times the canvas width.
        /// The number of point after decimation can be higher than the threshold value.
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns></returns>
        public DecimationBuilder Threshold(int threshold)
        {
            _decimation.Threshold = threshold;
            return this;
        }
    }
}
