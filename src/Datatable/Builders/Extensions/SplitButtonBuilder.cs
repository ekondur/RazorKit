using RazorKit.Datatable.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorKit.Datatable.Builders
{
    /// <summary>
    /// Split Buttons Configuration.
    /// </summary>
    public class SplitButtonBuilder
    {
        private readonly IList<object> _items;

        internal SplitButtonBuilder(IList<object> buttons)
        {
            _items = buttons;
        }

        /// <summary>
        /// Add a new button item.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="action"></param>
        /// <returns></returns>
        public SplitButtonBuilder Add(string text, string action)
        {
            _items.Add(new Button { Action = action, Text = text });
            return this;
        }
    }
}
