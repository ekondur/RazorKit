using RazorKit.DataTables.Models;
using System;
using System.Collections.Generic;

namespace RazorKit.DataTables.Builders
{
    /// <summary>
    /// Layout options configuration
    /// </summary>
    public class LayoutOptionsBuilder
    {
        private readonly LayoutOptions _options;
        public LayoutOptionsBuilder(LayoutOptions options)
        {
            _options = options;
        }
        /// <summary>
        /// Configure the search input. Configure filtering behavior with DatatableBuilder.Search.
        /// </summary>
        /// <param name="action">Search input configuration.</param>
        /// <returns>The layout options builder.</returns>
        public LayoutOptionsBuilder Search(Action<LayoutSearchOptionsBuilder> action)
        {
            _options.Search = new LayoutSearchOptions();
            var builder = new LayoutSearchOptionsBuilder(_options.Search);
            action(builder);
            return this;
        }
        public LayoutOptionsBuilder Buttons(params string[] buttons)
        {
            if (_options.Buttons == null)
                _options.Buttons = new List<object>();

            _options.Buttons.Add(buttons);
            return this;
        }
        public LayoutOptionsBuilder Button(Action<ButtonBuilder> action)
        {
            if (_options.Buttons == null)
                _options.Buttons = new List<object>();

            var builder = new ButtonBuilder(_options.Buttons);
            action(builder);
            return this;
        }
    }
}
