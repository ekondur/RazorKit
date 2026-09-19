using RazorKit.DataTables.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public LayoutOptionsBuilder Search(Action<SearchOptionsBuilder> action)
        {
            _options.Search = new SearchOptions();
            var builder = new SearchOptionsBuilder(_options.Search);
            action(builder);
            return this;
        }
        public LayoutOptionsBuilder Buttons(params string[] buttons)
        {
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
