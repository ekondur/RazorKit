using RazorKit.DataTables.Models;
using RazorKit.DataTables.Utilities;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using System.Reflection;

namespace RazorKit.DataTables.Builders
{
    /// <summary>
    /// Columns Configuration.
    /// </summary>
    public class ColumnBuilder<T>
    {
        private readonly DatatableJs _dataTable;
        private Column _column;

        internal ColumnBuilder(DatatableJs dataTable)
        {
            _dataTable = dataTable;
        }

        /// <summary>
        /// Make a column with defined type properties.
        /// </summary>
        /// <typeparam name="TProp">The type of the property.</typeparam>
        /// <param name="property">The property.</param>
        /// <returns></returns>
        public ColumnBuilder<T> Field<TProp>(Expression<Func<T, TProp>> property)
        {
            var member = property.Body as MemberExpression;
            var propName = ExpressionHelpers<T>.PropertyName(property);
            _column = new Column
            {
                Data = propName,
                Name = propName,
                Title = member.Member.GetCustomAttribute<DisplayAttribute>()?.Name ?? propName,
                Render = member.Member.GetCustomAttribute<DisplayFormatAttribute>() != null ? $@"moment(data).format('{member.Member.GetCustomAttribute<DisplayFormatAttribute>().DataFormatString}')" : null,
            };
            _dataTable.Columns.Add(_column);
            return this;
        }

        /// <summary>
        /// Set column title.
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
        public ColumnBuilder<T> Title(string title)
        {
            _column.Title = title;
            return this;
        }

        /// <summary>
        /// Set a descriptive name for a column.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public ColumnBuilder<T> Name(string name)
        {
            _column.Name = name;
            return this;
        }

        /// <summary>
        /// Set column visible or hidden, default is true.
        /// </summary>
        /// <param name="isVisible"></param>
        /// <returns></returns>
        public ColumnBuilder<T> Visible(bool isVisible)
        {
            _column.Visible = isVisible;

            if (isVisible == false)
            {
                _column.Orderable = false;
                _column.Searchable = false;
            }

            return this;
        }

        /// <summary>
        /// Set column orderable or not, default is true.
        /// </summary>
        /// <param name="isOrderable"></param>
        /// <returns></returns>
        public ColumnBuilder<T> Orderable(bool isOrderable)
        {
            _column.Orderable = isOrderable;
            return this;
        }

        /// <summary>
        /// Set column searchable or not, default is true.
        /// </summary>
        /// <param name="isSearchable"></param>
        /// <returns></returns>
        public ColumnBuilder<T> Searchable(bool isSearchable)
        {
            _column.Searchable = isSearchable;
            return this;
        }

        /// <summary>
        /// Set column width percentage.
        /// </summary>
        /// <param name="width"></param>
        /// <returns></returns>
        public ColumnBuilder<T> Width(string width)
        {
            _column.Width = width;
            return this;
        }

        /// <summary>
        /// Set css class of column.
        /// </summary>
        /// <param name="className"></param>
        /// <returns></returns>
        public ColumnBuilder<T> Class(string className)
        {
            _column.ClassName = className;
            return this;
        }

        /// <summary>
        /// Set default value for null data
        /// </summary>
        /// <param name="defaultContent"></param>
        /// <returns></returns>
        public ColumnBuilder<T> DefaultContent(string defaultContent)
        {
            _column.DefaultContent = defaultContent;
            return this;
        }

        /// <summary>
        /// Set a jquery datatable date format.
        /// </summary>
        /// <param name="format"></param>
        /// <returns></returns>
        public ColumnBuilder<T> Format(string format)
        {
            _column.Render = $@"moment(data).format('{format}')";
            return this;
        }

        /// <summary>
        /// Customize column template using "data" for comparison.
        /// </summary>
        /// <param name="template"></param>
        /// <returns></returns>
        public ColumnBuilder<T> Template(string template)
        {
            _column.Render = template;
            return this;
        }

        /// <summary>
        /// Add padding to the text content used when calculating the optimal width for a table.
        /// </summary>
        /// <param name="contentPadding"></param>
        /// <returns></returns>
        public ColumnBuilder<T> ContentPadding(string contentPadding)
        {
            _column.ContentPadding = contentPadding;
            return this;
        }

        /// <summary>
        /// Cell created callback to allow DOM manipulation.
        /// </summary>
        /// <param name="createdCell"></param>
        /// <returns></returns>
        public ColumnBuilder<T> CreatedCell(string createdCell)
        {
            _column.CreatedCell = createdCell;
            return this;
        }

        /// <summary>
        /// Set the column footer text.
        /// </summary>
        /// <param name="footer"></param>
        /// <returns></returns>
        public ColumnBuilder<T> Footer(string footer)
        {
            _column.Footer = footer;
            return this;
        }

        /// <summary>
        /// Set the column type - used for filtering and sorting string processing.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public ColumnBuilder<T> Type(ColumnType type)
        {
            _column.Type = type;
            return this;
        }

        /// <summary>
        /// Set column's visibility priority.
        /// </summary>
        /// <param name="responsivePriority"></param>
        /// <returns></returns>
        public ColumnBuilder<T> ResponsivePriority(int responsivePriority)
        {
            _column.ResponsivePriority = responsivePriority;
            return this;
        }

        /// <summary>
        /// Command group (dropdown) configuration.
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        public ColumnBuilder<T> Command(Action<CommandBuilder> action)
        {
            var builder = new CommandBuilder(_dataTable);
            action(builder);
            return this;
        }

        /// <summary>
        /// Command (link or button) configuration.
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        public ColumnBuilder<T> CommandGroup(Action<CommandGroupBuilder> action)
        {
            _dataTable.CommandGroup = new CommandGroup();
            var builder = new CommandGroupBuilder(_dataTable.CommandGroup);
            action(builder);
            return this;
        }
    }
}
