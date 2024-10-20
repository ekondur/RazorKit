using HelperJS.Chart.Models;

namespace HelperJS.Chart.Builders
{
    /// <summary>
    /// Bar Element Configuration.
    /// </summary>
    public class BarElementBuilder : BaseElementBuilder<BarElementBuilder>
    {
        private readonly BarElement _barElement;

        internal BarElementBuilder(BarElement barElement)
            : base(barElement)
        {
            _barElement = barElement;
        }
    }
}
