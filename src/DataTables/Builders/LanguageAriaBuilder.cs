using RazorKit.DataTables.Models;

namespace RazorKit.DataTables.Builders
{
    /// <summary>
    /// Language Arica Configuration.
    /// </summary>
    public class LanguageAriaBuilder
    {
        private readonly LanguageAria _aria;

        internal LanguageAriaBuilder(LanguageAria aria)
        {
            _aria = aria;
        }

        /// <summary>
        /// Set ARIA sort ascending string.
        /// </summary>
        /// <param name="sortString"></param>
        /// <returns></returns>
        public LanguageAriaBuilder SortAscending(string sortString)
        {
            _aria.SortAscending = sortString;
            return this;
        }

        /// <summary>
        /// Set ARIA sort descending string.
        /// </summary>
        /// <param name="sortString"></param>
        /// <returns></returns>
        public LanguageAriaBuilder SortDescending(string sortString)
        {
            _aria.SortDescending = sortString;
            return this;
        }

        /// <summary>
        /// Set ARIA orderable string.
        /// </summary>
        /// <param name="orderable"></param>
        /// <returns></returns>
        public LanguageAriaBuilder Orderable(string orderable)
        {
            _aria.Orderable = orderable;
            return this;
        }

        /// <summary>
        /// Set ARIA orderableReverse string.
        /// </summary>
        /// <param name="orderableReverse"></param>
        /// <returns></returns>
        public LanguageAriaBuilder OrderableReverse(string orderableReverse)
        {
            _aria.OrderableReverse = orderableReverse;
            return this;
        }

        /// <summary>
        /// Set ARIA orderableRemove string.
        /// </summary>
        /// <param name="orderableRemove"></param>
        /// <returns></returns>
        public LanguageAriaBuilder OrderableRemove(string orderableRemove)
        {
            _aria.OrderableRemove = orderableRemove;
            return this;
        }
    }
}
