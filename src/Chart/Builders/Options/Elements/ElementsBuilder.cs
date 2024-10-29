using RazorKit.Chart.Models;

namespace RazorKit.Chart.Builders
{
    /// <summary>
    /// Elements Configuration
    /// </summary>
    public class ElementsBuilder
    {
        private readonly Elements _elements;

        internal ElementsBuilder(Elements elements)
        {
            _elements = elements;
        }

        /// <summary>
        /// Point Element Configuration.
        /// </summary>
        /// <returns></returns>
        public PointElementBuilder Point()
        {
            _elements.Point = new PointElement();
            var builder = new PointElementBuilder(_elements.Point);
            return builder;
        }

        /// <summary>
        /// Line Element Configuration.
        /// </summary>
        /// <returns></returns>
        public LineElementBuilder Line()
        {
            _elements.Line = new LineElement();
            var builder = new LineElementBuilder(_elements.Line);
            return builder;
        }

        /// <summary>
        /// Bar Element Configuration.
        /// </summary>
        /// <returns></returns>
        public BarElementBuilder Bar()
        {
            _elements.Bar = new BarElement();
            var builder = new BarElementBuilder(_elements.Bar);
            return builder;
        }

        /// <summary>
        /// Arc Element Configuration.
        /// </summary>
        /// <returns></returns>
        public ArcElementBuilder Arc()
        {
            _elements.Arc = new ArcElement();
            var builder = new ArcElementBuilder(_elements.Arc);
            return builder;
        }
    }
}
