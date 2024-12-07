using RazorKit.DataTables.Models;
using System;

namespace RazorKit.DataTables.Builders
{
    /// <summary>
    /// Language Configuration.
    /// </summary>
    public class LanguageBuilder
    {
        private readonly Language _language;

        internal LanguageBuilder(Language language)
        {
            _language = language;
        }

        /// <summary>
        /// Set the decimal place character.  <see href="https://datatables.net/reference/option/language.decimal">Reference:</see>
        /// </summary>
        /// <param name="place"></param>
        /// <returns></returns>
        public LanguageBuilder Decimal(string place)
        {
            _language.Decimal = place;
            return this;
        }

        /// <summary>
        /// This string is shown when the table is empty of data (regardless of filtering).  <see href="https://datatables.net/reference/option/language.emptyTable">Reference:</see>
        /// </summary>
        /// <param name="message">No data available in table</param>
        /// <returns></returns>
        public LanguageBuilder EmptyTable(string message)
        {
            _language.EmptyTable = message;
            return this;
        }

        /// <summary>
        /// This string gives information to the end user about the information that is current on display on the page. <see href="https://datatables.net/reference/option/language.info">Reference:</see>
        /// </summary>
        /// <param name="message">Showing _START_ to _END_ of _TOTAL_ entries</param>
        /// <returns></returns>
        public LanguageBuilder Info(string message)
        {
            _language.Info = message;
            return this;
        }

        /// <summary>
        /// Display information string for when the table is empty. <see href="https://datatables.net/reference/option/language.infoEmpty">Reference:</see>
        /// </summary>
        /// <param name="message">Showing 0 to 0 of 0 entries</param>
        /// <returns></returns>
        public LanguageBuilder InfoEmpty(string message)
        {
            _language.InfoEmpty = message;
            return this;
        }

        /// <summary>
        /// When a user filters the information in a table, this string is appended to the information (info) to give an idea of how strong the filtering is. <see href="https://datatables.net/reference/option/language.infoFiltered">Reference:</see>
        /// </summary>
        /// <param name="message">(filtered from _MAX_ total entries)</param>
        /// <returns></returns>
        public LanguageBuilder InfoFiltered(string message)
        {
            _language.InfoFiltered = message;
            return this;
        }

        /// <summary>
        /// If can be useful to append extra information to the info string at times, and this variable does exactly that. <see href="https://datatables.net/reference/option/language.infoPostFix">Reference:</see>
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public LanguageBuilder InfoPostFix(string message)
        {
            _language.InfoPostFix = message;
            return this;
        }

        /// <summary>
        /// The thousands separator option is used for output of information only. <see href="https://datatables.net/reference/option/language.thousands">Reference:</see>
        /// </summary>
        /// <param name="place">,</param>
        /// <returns></returns>
        public LanguageBuilder Thousands(string place)
        {
            _language.Thousands = place;
            return this;
        }

        /// <summary>
        /// Detail the action that will be taken when the drop down menu for the pagination length option is changed. <see href="https://datatables.net/reference/option/language.lengthMenu">Reference:</see>
        /// </summary>
        /// <param name="message">Show _MENU_ entries</param>
        /// <returns></returns>
        public LanguageBuilder LengthMenu(string message)
        {
            _language.LengthMenu = message;
            return this;
        }

        /// <summary>
        /// This message is shown in an empty row in the table to indicate to the end user the the data is being loaded. <see href="https://datatables.net/reference/option/language.loadingRecords">Reference:</see>
        /// </summary>
        /// <param name="message">Loading...</param>
        /// <returns></returns>
        public LanguageBuilder LoadingRecords(string message)
        {
            _language.LoadingRecords = message;
            return this;
        }

        /// <summary>
        /// Text that is displayed when the table is processing a user action (usually a sort command or similar). <see href="https://datatables.net/reference/option/language.processing">Reference:</see>
        /// </summary>
        /// <param name="message">{Empty string}</param>
        /// <returns></returns>
        public LanguageBuilder Processing(string message)
        {
            _language.Processing = message;
            return this;
        }

        /// <summary>
        /// Sets the string that is used for DataTables filtering input control. <see href="https://datatables.net/reference/option/language.search">Reference:</see>
        /// </summary>
        /// <param name="message">Search:</param>
        /// <returns></returns>
        public LanguageBuilder Search(string message)
        {
            _language.Search = message;
            return this;
        }

        /// <summary>
        /// Text shown inside the table records when the is no information to be displayed after filtering. <see href="https://datatables.net/reference/option/language.zeroRecords">Reference:</see>
        /// </summary>
        /// <param name="message">No matching records found</param>
        /// <returns></returns>
        public LanguageBuilder ZeroRecords(string message)
        {
            _language.ZeroRecords = message;
            return this;
        }

        /// <summary>
        /// Pagination string used by DataTables for the built-in pagination control types. <see href="https://datatables.net/reference/option/language.paginate">Reference:</see>
        /// </summary>
        /// <param name="first">First</param>
        /// <param name="last">Last</param>
        /// <param name="next">Next</param>
        /// <param name="previous">Previous</param>
        /// <returns></returns>
        public LanguageBuilder Paginate(string first, string last, string next, string previous)
        {
            _language.Paginate.First = first;
            _language.Paginate.Last = last;
            _language.Paginate.Next = next;
            _language.Paginate.Previous = previous;
            return this;
        }

        /// <summary>
        /// Language strings used for WAI-ARIA specific attributes. <see href="https://datatables.net/reference/option/language.aria">Reference:</see>
        /// </summary>
        /// <returns></returns>
        public LanguageBuilder Aria(Action<LanguageAriaBuilder> action)
        {
            _language.Aria = new LanguageAria();
            var builder = new LanguageAriaBuilder(_language.Aria);
            action(builder);
            return this;
        }
    }
}
