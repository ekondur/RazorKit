using RazorKit.ChartJs.Models;
using System;

namespace RazorKit.ChartJs.Builders
{
    /// <summary>
    /// Layout Builder
    /// </summary>
    public class LayoutBuilder
    {
        private readonly Layout _layout;

        internal LayoutBuilder(Layout layout)
        {
            _layout = layout;
        }

        /// <summary>
        /// Apply automatic padding so visible elements are completely drawn.
        /// default true, scriptable no
        /// </summary>
        /// <param name="autoPadding"></param>
        /// <returns></returns>
        public LayoutBuilder AutoPadding(bool autoPadding)
        {
            _layout.AutoPadding = autoPadding;
            return this;
        }

        /// <summary>
        /// The padding to add inside the chart.
        /// default 0, scriptable yes
        /// </summary>
        /// <param name="padding"></param>
        /// <returns></returns>
        public LayoutBuilder Padding(int padding)
        {
            _layout.Padding = new Padding(padding);
            return this;
        }

        /// <summary>
        /// Padding Configuration.
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        public LayoutBuilder Padding(Action<PaddingBuilder> action)
        {
            _layout.Padding = new Padding();
            var builder = new PaddingBuilder(_layout.Padding);
            action(builder);
            return this;
        }
    }
}
