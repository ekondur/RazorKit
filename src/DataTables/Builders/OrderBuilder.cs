using RazorKit.DataTables.Models;
using RazorKit.DataTables.Utilities;
using System.Linq.Expressions;
using System;
using System.Linq;
using RazorKit.DataTables.Exceptions;

namespace RazorKit.DataTables.Builders
{
    /// <summary>
    /// Orders Configuration.
    /// </summary>
    public class OrderBuilder<T>
    {
        private readonly DatatableJs _datatable;

        internal OrderBuilder(DatatableJs datatable)
        {
            _datatable = datatable;
        }

        /// <summary>
        /// Adds the specified property for default ordering.
        /// </summary>
        /// <typeparam name="TProp">The type of the property.</typeparam>
        /// <param name="property">The property.</param>
        /// <param name="orderBy">The order.</param>
        /// <returns></returns>
        public OrderBuilder<T> Add<TProp>(Expression<Func<T, TProp>> property, OrderBy orderBy)
        {
            var propertyName = ExpressionHelpers<T>.PropertyName(property);

            var column = _datatable.Columns
                .Where(c => c.Name != null && c.Name.Equals(propertyName))
                .FirstOrDefault();

            if (column == null)
            {
                throw new ColumnNotFoundException(string.Format("Column not found for property {0}", propertyName));
            }

            var columnIndex = _datatable.Columns.IndexOf(column);

            var orderByStr = orderBy == OrderBy.Ascending ? "asc" : "desc";

            _datatable.Order.Add(new object[] { columnIndex, orderByStr });

            return this;
        }
    }
}
