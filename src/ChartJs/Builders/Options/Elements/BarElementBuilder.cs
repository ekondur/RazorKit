using RazorKit.ChartJs.Models;
using System;

namespace RazorKit.ChartJs.Builders
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

        /// <summary>
        /// Skipped (excluded) border.
        /// </summary>
        /// <param name="enabled"></param>
        /// <returns></returns>
        public BarElementBuilder BorderSkipped(bool enabled)
        {
            _barElement.BorderSkipped = enabled;
            return this;
        }

        /// <summary>
        /// Skipped (excluded) border.
        /// </summary>
        /// <param name="skipped"></param>
        /// <returns></returns>
        public BarElementBuilder BorderSkipped(Skipped skipped)
        {
            _barElement.BorderSkipped = skipped;
            return this;
        }

        /// <summary>
        /// The bar border radius (in pixels). Default 0
        /// </summary>
        /// <param name="radius"></param>
        /// <returns></returns>
        public BarElementBuilder BorderRadius(int radius)
        {
            _barElement.BorderRadius = radius;
            return this;
        }

        /// <summary>
        /// The bar border radius (in pixels). { topLeft, topRight, bottomLeft, bottomRight }
        /// </summary>
        /// <returns></returns>
        public BarElementBuilder BorderRadius(Action<BorderRadiusBuilder> action)
        {
            _barElement.BorderRadius = new BorderRadius();
            var builder = new BorderRadiusBuilder((BorderRadius)_barElement.BorderRadius);
            action(builder);
            return this;
        }

        /// <summary>
        /// The amount of pixels to inflate the bar rectangle(s) when drawing is 'auto'.
        /// </summary>
        /// <returns></returns>
        public BarElementBuilder InflateAmount()
        {
            _barElement.InflateAmount = "auto";
            return this;
        }

        /// <summary>
        /// The amount of pixels to inflate the bar rectangle(s) when drawing.
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public BarElementBuilder InflateAmount(int amount)
        {
            _barElement.InflateAmount = amount;
            return this;
        }

        /// <summary>
        /// Style of the point for legend. Default is 'circle'.
        /// </summary>
        /// <param name="style"></param>
        /// <returns></returns>
        public BarElementBuilder PointStyle(PointStyle style)
        {
            _barElement.PointStyle = style;
            return this;
        }
    }
}
