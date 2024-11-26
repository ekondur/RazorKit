using RazorKit.ChartJs.Models;

namespace RazorKit.ChartJs.Builders
{
    /// <summary>
    /// Colors Builder
    /// </summary>
    public class ColorsBuilder
    {
        private readonly Colors _colors;

        internal ColorsBuilder(Colors colors)
        {
            _colors = colors;
        }

        /// <summary>
        /// If you don't have any preference for colors, you can use the built-in Colors plugin.
        /// It will cycle through a palette of seven Chart.js brand colors. Default true
        /// </summary>
        /// <param name="enabled"></param>
        /// <returns></returns>
        public ColorsBuilder Enabled(bool enabled)
        {
            _colors.Enabled = enabled;
            return this;
        }

        /// <summary>
        /// By default, the colors plugin only works when you initialize the chart without any colors for the border or background specified.
        /// If you want to force the colors plugin to always color your datasets, for example,
        /// when using dynamic datasets at runtime you will need to set the forceOverride option to true.
        /// </summary>
        /// <param name="forceOverride"></param>
        /// <returns></returns>
        public ColorsBuilder ForceOverride(bool forceOverride)
        {
            _colors.ForceOverride = forceOverride;
            return this;
        }
    }
}
