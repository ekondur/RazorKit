using RazorKit.DataTables.Models;

namespace RazorKit.DataTables.Builders
{
    /// <summary>
    /// Configure the search input displayed in a layout position.
    /// </summary>
    public class LayoutSearchOptionsBuilder
    {
        private readonly LayoutSearchOptions _search;

        internal LayoutSearchOptionsBuilder(LayoutSearchOptions search)
        {
            _search = search;
        }

        /// <summary>
        /// Set the placeholder attribute of the search input.
        /// </summary>
        /// <param name="placeholder">Placeholder text.</param>
        /// <returns>The search input builder.</returns>
        public LayoutSearchOptionsBuilder Placeholder(string placeholder)
        {
            _search.Placeholder = placeholder;
            return this;
        }
    }
}
