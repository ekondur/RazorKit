﻿using HelperJS.Chart.Models;
using System;

namespace HelperJS.Chart.Builders
{
    /// <summary>
    /// Plugins Builder
    /// </summary>
    public class PluginsBuilder
    {
        private readonly Plugins _plugins;

        internal PluginsBuilder(Plugins plugins)
        {
            _plugins = plugins;
        }

        /// <summary>
        /// The chart title defines text to draw at the top of the chart.
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        public PluginsBuilder Title(Action<TitleBuilder> action)
        {
            _plugins.Title = new Title();
            var builder = new TitleBuilder(_plugins.Title);
            action(builder);
            return this;
        }

        /// <summary>
        /// Subtitle is a second title placed under the main title, by default. 
        /// It has exactly the same configuration options with the main title.
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        public PluginsBuilder Subtitle(Action<TitleBuilder> action)
        {
            _plugins.Subtitle = new Title();
            var builder = new TitleBuilder(_plugins.Subtitle);
            action(builder);
            return this;
        }

        /// <summary>
        /// The chart legend displays data about the datasets that are appearing on the chart.
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        public PluginsBuilder Legend(Action<LegendBuilder> action)
        {
            _plugins.Legend = new Legend();
            var builder = new LegendBuilder(_plugins.Legend);
            action(builder);
            return this;
        }

        /// <summary>
        /// Configure Tooltip.
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        public PluginsBuilder Tooltip(Action<TooltipBuilder> action)
        {
            _plugins.Tooltip = new ToolTip();
            var builder = new TooltipBuilder(_plugins.Tooltip);
            action(builder);
            return this;
        }

        /// <summary>
        /// Configure Colors.
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        public PluginsBuilder Colors(Action<ColorsBuilder> action)
        {
            _plugins.Colors = new Colors();
            var builder = new ColorsBuilder(_plugins.Colors);
            action(builder);
            return this;
        }
    }
}
