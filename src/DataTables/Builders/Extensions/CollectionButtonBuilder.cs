using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorKit.DataTables.Builders.Extensions
{
    /// <summary>
    /// Collection button configuration when using extend type 'Collection'
    /// </summary>
    public class CollectionButtonBuilder
    {
        private readonly IList<object> _items;

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="buttons"></param>
        public CollectionButtonBuilder(IList<object> buttons)
        {
            _items = buttons;
        }

        /// <summary>
        /// Add a new button item to collection
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        public CollectionButtonBuilder Button(Action<ButtonBuilder> action)
        {
            var builder = new ButtonBuilder(_items);
            action(builder);
            return this;
        }
    }
}
