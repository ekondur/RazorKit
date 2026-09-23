using RazorKit.DataTables.Models;


namespace RazorKit.DataTables.Builders
{
    /// <summary>
    /// Search Configuration.
    /// <see href="https://datatables.net/ref/core/type/DataTable.SearchOptions"/>
    /// </summary>
    public class SearchOptionsBuilder
    {
        private readonly SearchOptions _search;

        internal SearchOptionsBuilder(SearchOptions searching)
        {
            _search = searching;
        }
        /// <summary>
        /// Search term that should be applied to the table.
        /// </summary>
        /// <param name="defaultSearchValue"></param>
        /// <returns><see cref="SearchOptionsBuilder"/></returns>
        public SearchOptionsBuilder DefaultSearch(string defaultSearchValue)
        {
            _search.Search = defaultSearchValue;
            return this;
        }
        /// <summary>
        /// Indicate if case-insensitive search should be performed (true) or if the search should match on case (false).
        /// </summary>
        /// <param name="caseInsensitive"></param>
        /// <returns><see cref="SearchOptionsBuilder"/></returns>
        public SearchOptionsBuilder CaseInsensitive(bool caseInsensitive = true)
        {
            _search.CaseInsensitive = caseInsensitive;
            return this;
        }
        /// <summary>
        /// Indicate if the search term should be treated as a regular expression or not. 
        /// If false the input term will have any regular expression characters escaped for the regular expression that DataTables runs. 
        /// Note that as of DataTables 2.0 this option is discouraged - if you wish to perform a regular expression search, 
        /// pass the search term in as a RegExp object (rather than a string with a regex in it).
        /// </summary>
        /// <param name="regex"></param>
        /// <returns><see cref="SearchOptionsBuilder"/></returns>
        public SearchOptionsBuilder Regex(bool regex = false)
        {
            _search.Regex = regex;
            return this;
        }

        /// <summary>
        /// Start the matching from the start of a word. This can be useful for cases where you want a search term such as male to match Male but not Female. 
        /// Care must also be taken when using languages where white space is not significant, 
        /// for example with Chinese this option could cause only the first character in a whole paragraph to match. 
        /// This option is only available when smart search is enabled.
        /// </summary>
        /// <param name="boundary"></param>
        /// <returns><see cref="SearchOptionsBuilder"/></returns>
        public SearchOptionsBuilder Boundary(bool boundary = false)
        {
            _search.Boundary = boundary;
            return this;
        }

        /// <summary>
        /// This option can be used to enable and disable DataTables' smart search option. With smart search enabled you can:
        /// <list type="bullet">
        /// <item>Search for words in any order</item>
        /// <item>Enclose a string in double quotes to perform an exact match(just as can be done with search engines)</item>
        /// <item>Start a word with !to do a negation search(i.e.the search will match only records that do not contain the following word).</item>
        /// </list>
        /// </summary>
        /// <param name="smart"></param>
        /// <returns><see cref="SearchOptionsBuilder"/></returns>
        public SearchOptionsBuilder Smart(bool smart = true)
        {
            _search.Smart = smart;
            return this;
        }
        /// <summary>
        /// Enable / disable DataTables' search on return (Press Enter Key).
        /// </summary>
        /// <param name="returnOnEnterKey"></param>
        /// <returns><see cref="SearchOptionsBuilder"/></returns>
        public SearchOptionsBuilder Return(bool returnOnEnterKey = false)
        {
            _search.Return = returnOnEnterKey;
            return this;
        }
    }
}
