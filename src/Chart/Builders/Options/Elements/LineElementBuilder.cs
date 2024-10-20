using HelperJS.Chart.Models;

namespace HelperJS.Chart.Builders
{
    /// <summary>
    /// Line Element Configuration
    /// </summary>
    public class LineElementBuilder : BaseElementBuilder<LineElementBuilder>
    {
        private readonly LineElement _lineElement;

        internal LineElementBuilder(LineElement lineElement)
            : base(lineElement)
        {
            _lineElement = lineElement;
        }
    }
}
