using HelperJS.Chart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperJS.Chart.Builders
{
    public class LayoutBuilder
    {
        private readonly ChartJs _chart;
        private readonly Layout _layout;

        public LayoutBuilder(ChartJs chart)
        {
            _chart = chart;
            _chart.Options.Layout = _layout = new Layout();
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
        /// Configure padding.
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        public LayoutBuilder Padding(Action<PaddingBuilder> action)
        {
            var builder = new PaddingBuilder(_chart, PaddingSource.Layout);
            action(builder);
            return this;
        }
    }
}
