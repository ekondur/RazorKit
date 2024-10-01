﻿using HelperJS.Chart.Models;
using System;

namespace HelperJS.Chart.Builders
{
    public class LegendTitleBuilder
    {
        private readonly ChartJs _chart;
        private readonly LegendTitle _legendTitle;

        public LegendTitleBuilder(ChartJs chart)
        {
            _chart = chart;
            _chart.Options.Plugins.Legend.Title = _legendTitle = new LegendTitle();
        }

        /// <summary>
        /// Color of text.
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public LegendTitleBuilder Color(string color)
        {
            _legendTitle.Color = color;
            return this;
        }

        /// <summary>
        /// Is the legend title displayed.
        /// </summary>
        /// <param name="display"></param>
        /// <returns></returns>
        public LegendTitleBuilder Display(bool display)
        {
            _legendTitle.Display = display;
            return this;
        }

        /// <summary>
        /// Configure font.
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        public LegendTitleBuilder Font(Action<FontBuilder> action)
        {
            var builder = new FontBuilder(_chart, FontSource.LegendTitle);
            action(builder);
            return this;
        }

        /// <summary>
        /// Padding around the title.
        /// </summary>
        /// <param name="padding"></param>
        /// <returns></returns>
        public LegendTitleBuilder Padding(double padding)
        {
            _legendTitle.Padding = padding;
            return this;
        }

        /// <summary>
        /// The string title.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public LegendTitleBuilder Text(string text)
        {
            _legendTitle.Text = text;
            return this;
        }
    }
}
