using RazorKit.ChartJs.Models;

namespace RazorKit.ChartJs.Builders
{
    /// <summary>
    /// Scale Callback Configuration
    /// </summary>
    public class ScaleCallbackBuilder
    {
        private readonly Scale _scale;

        internal ScaleCallbackBuilder(Scale scale)
        {
            _scale = scale;
        }

        /// <summary>
        /// Callback called before the update process starts.
        /// </summary>
        /// <param name="functionName"></param>
        /// <returns></returns>
        public ScaleCallbackBuilder BeforeUpdate(string functionName)
        {
            _scale.BeforeUpdate = functionName;
            return this;
        }

        /// <summary>
        /// Callback that runs at the end of the update process.
        /// </summary>
        /// <param name="functionName"></param>
        /// <returns></returns>
        public ScaleCallbackBuilder AfterUpdate(string functionName)
        {
            _scale.AfterUpdate = functionName;
            return this;
        }

        /// <summary>
        /// Callback that runs before dimensions are set.
        /// </summary>
        /// <param name="functionName"></param>
        /// <returns></returns>
        public ScaleCallbackBuilder BeforeSetDimensions(string functionName)
        {
            _scale.BeforeSetDimensions = functionName;
            return this;
        }

        /// <summary>
        /// Callback that runs after dimensions are set.
        /// </summary>
        /// <param name="functionName"></param>
        /// <returns></returns>
        public ScaleCallbackBuilder AfterSetDimensions(string functionName)
        {
            _scale.AfterSetDimensions = functionName;
            return this;
        }

        /// <summary>
        /// Callback that runs before data limits are determined.
        /// </summary>
        /// <param name="functionName"></param>
        /// <returns></returns>
        public ScaleCallbackBuilder BeforeDataLimits(string functionName)
        {
            _scale.BeforeDataLimits = functionName;
            return this;
        }

        /// <summary>
        /// Callback that runs after data limits are determined.
        /// </summary>
        /// <param name="functionName"></param>
        /// <returns></returns>
        public ScaleCallbackBuilder AfterDataLimits(string functionName)
        {
            _scale.AfterDataLimits = functionName;
            return this;
        }

        /// <summary>
        /// Callback that runs before ticks are created.
        /// </summary>
        /// <param name="functionName"></param>
        /// <returns></returns>
        public ScaleCallbackBuilder BeforeBuildTicks(string functionName)
        {
            _scale.BeforeBuildTicks = functionName;
            return this;
        }

        /// <summary>
        /// Callback that runs after ticks are created. Useful for filtering ticks.
        /// </summary>
        /// <param name="functionName"></param>
        /// <returns></returns>
        public ScaleCallbackBuilder AfterBuildTicks(string functionName)
        {
            _scale.AfterBuildTicks = functionName;
            return this;
        }

        /// <summary>
        /// Callback that runs before ticks are converted into strings.
        /// </summary>
        /// <param name="functionName"></param>
        /// <returns></returns>
        public ScaleCallbackBuilder BeforeTickToLabelConversion(string functionName)
        {
            _scale.BeforeTickToLabelConversion = functionName;
            return this;
        }

        /// <summary>
        /// Callback that runs after ticks are converted into strings.
        /// </summary>
        /// <param name="functionName"></param>
        /// <returns></returns>
        public ScaleCallbackBuilder AfterTickToLabelConversion(string functionName)
        {
            _scale.AfterTickToLabelConversion = functionName;
            return this;
        }

        /// <summary>
        /// Callback that runs before tick rotation is determined.
        /// </summary>
        /// <param name="functionName"></param>
        /// <returns></returns>
        public ScaleCallbackBuilder BeforeCalculateLabelRotation(string functionName)
        {
            _scale.BeforeCalculateLabelRotation = functionName;
            return this;
        }

        /// <summary>
        /// Callback that runs after tick rotation is determined.
        /// </summary>
        /// <param name="functionName"></param>
        /// <returns></returns>
        public ScaleCallbackBuilder AfterCalculateLabelRotation(string functionName)
        {
            _scale.AfterCalculateLabelRotation = functionName;
            return this;
        }

        /// <summary>
        /// Callback that runs before the scale fits to the canvas.
        /// </summary>
        /// <param name="functionName"></param>
        /// <returns></returns>
        public ScaleCallbackBuilder BeforeFit(string functionName)
        {
            _scale.BeforeFit = functionName;
            return this;
        }

        /// <summary>
        /// Callback that runs after the scale fits to the canvas.
        /// </summary>
        /// <param name="functionName"></param>
        /// <returns></returns>
        public ScaleCallbackBuilder AfterFit(string functionName)
        {
            _scale.AfterFit = functionName;
            return this;
        }
    }
}
