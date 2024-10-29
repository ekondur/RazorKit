using RazorKit.Datatable.Models;
using RazorKit.Datatable.Utilities;
using System;
using System.Linq.Expressions;

namespace RazorKit.Datatable.Builders
{
    /// <summary>
    /// Filters Configuration.
    /// </summary>
    public class FilterBuilder<T>
    {
        private readonly DatatableJs _datatable;
        private Filter _filter;

        internal FilterBuilder(DatatableJs datatable)
        {
            _datatable = datatable;
        }

        /// <summary>
        /// Add the specified property for filter.
        /// </summary>
        /// <typeparam name="TProp">The type of the property.</typeparam>
        /// <param name="property">The property.</param>
        /// <returns></returns>
        public FilterBuilder<T> Add<TProp>(Expression<Func<T, TProp>> property)
        {
            _filter = new Filter
            {
                Field = ExpressionHelpers<T>.PropertyName(property),
            };
            return this;
        }

        /// <summary>
        /// Equals the specified value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public FilterBuilder<T> Equal(object value)
        {
            _filter.Operand = Operand.Equal;
            _filter.Value = value.ToString();
            _datatable.Filters.Add(_filter);
            return this;
        }

        /// <summary>
        /// Nots the equal.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public FilterBuilder<T> NotEqual(object value)
        {
            _filter.Operand = Operand.NotEqual;
            _filter.Value = value.ToString();
            _datatable.Filters.Add(_filter);
            return this;
        }

        /// <summary>
        /// Greaters the than.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public FilterBuilder<T> GreaterThan(object value)
        {
            _filter.Operand = Operand.GreaterThan;
            _filter.Value = value.ToString();
            _datatable.Filters.Add(_filter);
            return this;
        }

        /// <summary>
        /// Determines whether this instance contains the object.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public FilterBuilder<T> Contains(object value)
        {
            _filter.Operand = Operand.Contains;
            _filter.Value = value.ToString();
            _datatable.Filters.Add(_filter);
            return this;
        }

        /// <summary>
        /// Endses the with.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public FilterBuilder<T> EndsWith(object value)
        {
            _filter.Operand = Operand.EndsWith;
            _filter.Value = value.ToString();
            _datatable.Filters.Add(_filter);
            return this;
        }

        /// <summary>
        /// Greaters the than or equal.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public FilterBuilder<T> GreaterThanOrEqual(object value)
        {
            _filter.Operand = Operand.GreaterThanOrEqual;
            _filter.Value = value.ToString();
            _datatable.Filters.Add(_filter);
            return this;
        }

        /// <summary>
        /// Lesses the than.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public FilterBuilder<T> LessThan(object value)
        {
            _filter.Operand = Operand.LessThan;
            _filter.Value = value.ToString();
            _datatable.Filters.Add(_filter);
            return this;
        }

        /// <summary>
        /// Lesses the than or equal.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public FilterBuilder<T> LessThanOrEqual(object value)
        {
            _filter.Operand = Operand.LessThanOrEqual;
            _filter.Value = value.ToString();
            _datatable.Filters.Add(_filter);
            return this;
        }

        /// <summary>
        /// Startses the with.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public FilterBuilder<T> StartsWith(object value)
        {
            _filter.Operand = Operand.StartsWith;
            _filter.Value = value.ToString();
            _datatable.Filters.Add(_filter);
            return this;
        }
    }
}
