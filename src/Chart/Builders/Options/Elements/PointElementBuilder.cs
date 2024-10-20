using HelperJS.Chart.Models;

namespace HelperJS.Chart.Builders
{
    /// <summary>
    /// Point Element Configuration.
    /// </summary>
    public class PointElementBuilder : BaseElementBuilder<PointElementBuilder>
    {
        private readonly PointElement _pointElement;

        internal PointElementBuilder(PointElement pointElement) 
            : base(pointElement)
        {
            _pointElement = pointElement;
        }

        /// <summary>
        /// Point radius.
        /// </summary>
        /// <param name="radius"></param>
        /// <returns></returns>
        public PointElementBuilder Radius(int radius)
        {
            _pointElement.Radius = radius;
            return this;
        }
    }
}
