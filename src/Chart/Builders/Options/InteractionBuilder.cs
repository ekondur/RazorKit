using HelperJS.Chart.Models;

namespace HelperJS.Chart.Builders
{
    /// <summary>
    /// Interaction Builder
    /// </summary>
    public class InteractionBuilder
    {
        private readonly ChartJs _chart;
        private readonly Interaction _interaction;

        internal InteractionBuilder(ChartJs chart)
        {
            _chart = chart;
            _chart.Options.Interaction = _interaction = new Interaction();
        }

        /// <summary>
        /// Sets which elements appear in the interaction. Default 'nearest'
        /// </summary>
        /// <param name="mode"></param>
        /// <returns></returns>
        public InteractionBuilder Mode(Mode mode)
        {
            _interaction.Mode = mode;
            return this;
        }

        /// <summary>
        /// if true, the interaction mode only applies when the mouse position intersects an item on the chart.
        /// Default true
        /// </summary>
        /// <param name="intersect"></param>
        /// <returns></returns>
        public InteractionBuilder Intersect(bool intersect)
        {
            _interaction.Intersect = intersect;
            return this;
        }

        /// <summary>
        /// Can be set to 'x', 'y', 'xy' or 'r' to define which directions are used in calculating distances.
        /// Defaults to 'x' for 'index' mode and 'xy' in dataset and 'nearest' modes.
        /// </summary>
        /// <param name="axis"></param>
        /// <returns></returns>
        public InteractionBuilder Axis(Axis axis)
        {
            _interaction.Axis = axis;
            return this;
        }

        /// <summary>
        /// if true, the invisible points that are outside of the chart area will also be included when evaluating interactions.
        /// Default false
        /// </summary>
        /// <param name="includeInvisible"></param>
        /// <returns></returns>
        public InteractionBuilder IncludeInvisible(bool includeInvisible)
        {
            _interaction.IncludeInvisible = includeInvisible;
            return this;
        }
    }
}
