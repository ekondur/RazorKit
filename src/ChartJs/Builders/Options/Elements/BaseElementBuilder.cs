using RazorKit.ChartJs.Models;

namespace RazorKit.ChartJs.Builders
{
    /// <summary>
    /// Element Configuration.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class BaseElementBuilder<T> where T : BaseElementBuilder<T>
    {
        private readonly BaseElement _baseElement;

        internal BaseElementBuilder(BaseElement baseElement)
        {
            _baseElement = baseElement;
        }

        /// <summary>
        /// Fill color.
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public T BackgroundColor(string color)
        {
            _baseElement.BackgroundColor = color;
            return (T)this;
        }

        /// <summary>
        /// Fill colors.
        /// </summary>
        /// <param name="colors"></param>
        /// <returns></returns>
        public T BackgroundColors(params string[] colors)
        {
            _baseElement.BackgroundColor = colors;
            return (T)this;
        }

        /// <summary>
        /// Stroke width.
        /// </summary>
        /// <param name="width"></param>
        /// <returns></returns>
        public T BorderWidth(int width)
        {
            _baseElement.BorderWidth = width;
            return (T)this;
        }

        /// <summary>
        /// Stroke color.
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public T BorderColor(string color)
        {
            _baseElement.BorderColor = color;
            return (T)this;
        }

        /// <summary>
        /// Stroke colors.
        /// </summary>
        /// <param name="colors"></param>
        /// <returns></returns>
        public T BorderColors(params string[] colors)
        {
            _baseElement.BorderColor = colors;
            return (T)this;
        }
    }
}
