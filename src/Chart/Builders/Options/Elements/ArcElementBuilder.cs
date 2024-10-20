using HelperJS.Chart.Models;

namespace HelperJS.Chart.Builders
{
    /// <summary>
    /// Arc Element Configuration.
    /// </summary>
    public class ArcElementBuilder : BaseElementBuilder<ArcElementBuilder>
    {
        private readonly ArcElement _arcElement;

        internal ArcElementBuilder(ArcElement arcElement)
            : base(arcElement)
        {
            _arcElement = arcElement;
        }
    }
}
