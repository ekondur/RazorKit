using RazorKit.DataTables.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorKit.DataTables.Builders
{
    /// <summary>
    /// Search Configuration.
    /// </summary>
    public class SearchingBuilder
    {
        private readonly Searching _search;

        internal SearchingBuilder(Searching searching)
        {
            _search = searching;
        }

        public SearchingBuilder Placeholder(string placeholder)
        {
            _search.Placeholder = placeholder;
            return this;
        }
        public SearchingBuilder DefaultSearch(string defaultSearchValue)
        {
            _search.Search = defaultSearchValue;
            return this;
        }
        public SearchingBuilder CaseInsensitive(bool caseInsensitive)
        {
            _search.CaseInsensitive = caseInsensitive;
            return this;
        }
        public SearchingBuilder Regex(string regex)
        {
            _search.Regex = regex;
            return this;
        }
        public SearchingBuilder Smart(bool smart = false)
        {
            _search.Smart = smart;
            return this;
        }
        public SearchingBuilder Return(bool returnOnEnterKey = false)
        {
            _search.Return = returnOnEnterKey;
            return this;
        }
    }
}
