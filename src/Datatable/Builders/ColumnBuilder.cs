﻿using RazorKit.Datatable.Models;
using RazorKit.Datatable.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace RazorKit.Datatable.Builders
{
    /// <summary>
    /// Columns Configuration.
    /// </summary>
    public class ColumnBuilder<T>
    {
        private readonly Models.DatatableJs _dataTable;
        private Column _column;

        internal ColumnBuilder(Models.DatatableJs dataTable)
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
            _column = new Column
            {
                Data = ExpressionHelpers<T>.PropertyName(property),
                Title = member.Member.GetCustomAttribute<DisplayAttribute>()?.Name ?? ExpressionHelpers<T>.PropertyName(property),
                Render = member.Member.GetCustomAttribute<DisplayFormatAttribute>() != null ? $@"moment(data).format('{member.Member.GetCustomAttribute<DisplayFormatAttribute>().DataFormatString}')" : null,
                Type = ((PropertyInfo)member.Member).PropertyType
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
        public ColumnBuilder<T> Width(int width)
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
        /// Define a link or button.
        /// </summary>
        /// <typeparam name="TProp"></typeparam>
        /// <param name="property"></param>
        /// <param name="onClick"></param>
        /// <param name="iconClass"></param>
        /// <param name="btnClass"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        public ColumnBuilder<T> Command<TProp>(Expression<Func<T, TProp>> property, string onClick, string iconClass, string btnClass, string text)
        {
            _column = new Column
            {
                Width = 1,
                Data = ExpressionHelpers<T>.PropertyName(property),
                Orderable = false,
                Searchable = false,
                Render = $@"'<a href=""#"" class=""{(!string.IsNullOrEmpty(iconClass) && string.IsNullOrEmpty(btnClass) ? "btn btn-primary" : btnClass)}"" onClick=""{onClick}(\''+data+'\')""><i class=""{iconClass}""></i>'+{(string.IsNullOrEmpty(text) ? (string.IsNullOrEmpty(iconClass) ? "data" : "''") : string.Format("' {0}'", text))}+'</a>'"
            };
            _dataTable.Columns.Add(_column);
            return this;
        }

        /// <summary>
        /// Define a link or button.
        /// </summary>
        /// <typeparam name="TProp"></typeparam>
        /// <param name="property"></param>
        /// <param name="onClick"></param>
        /// <param name="iconClass"></param>
        /// <param name="btnClass"></param>
        /// <returns></returns>
        public ColumnBuilder<T> Command<TProp>(Expression<Func<T, TProp>> property, string onClick, string iconClass, string btnClass)
        {
            return Command(property, onClick, iconClass, btnClass, "");
        }

        /// <summary>
        /// Define a link or button.
        /// </summary>
        /// <typeparam name="TProp"></typeparam>
        /// <param name="property"></param>
        /// <param name="onClick"></param>
        /// <param name="iconClass"></param>
        /// <returns></returns>
        public ColumnBuilder<T> Command<TProp>(Expression<Func<T, TProp>> property, string onClick, string iconClass)
        {
            return Command(property, onClick, iconClass, "", "");
        }

        /// <summary>
        /// Define a link or button.
        /// </summary>
        /// <typeparam name="TProp"></typeparam>
        /// <param name="property"></param>
        /// <param name="onClick"></param>
        /// <returns></returns>
        public ColumnBuilder<T> Command<TProp>(Expression<Func<T, TProp>> property, string onClick)
        {
            return Command(property, onClick, "", "", "");
        }

        /// <summary>
        /// Add multiple command to define button group.
        /// </summary>
        /// <typeparam name="TProp"></typeparam>
        /// <param name="property"></param>
        /// <param name="btnText"></param>
        /// <param name="btnClass"></param>
        /// <param name="iconClass"></param>
        /// <param name="commands"></param>
        /// <returns></returns>
        public ColumnBuilder<T> Commands<TProp>(Expression<Func<T, TProp>> property, IEnumerable<Command> commands, string btnText, string btnClass, string iconClass)
        {
            _column = new Column
            {
                Width = 1,
                Data = ExpressionHelpers<T>.PropertyName(property),
                Orderable = false,
                Searchable = false,
            };
            _column.Render = $@"'<div class=""btn-group"">'+
                        '<button type=""button"" class=""btn {btnClass} dropdown-toggle"" data-toggle=""dropdown"" data-bs-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">'+
                            '{btnText ?? ""} <span class=""{iconClass}""></span>'+
                        '</button>'+
                        '<div class=""dropdown-menu"">'+
                        {string.Join(Environment.NewLine,
                        commands.Select(a => $@"'<a class=""dropdown-item"" href=""#"" onclick=""{a.OnClick}(\''+data+'\');return false;"">{a.Text}</a>'+"))}
                        '</div>'+
                    '</div>'";
            _dataTable.Columns.Add(_column);
            return this;
        }

        /// <summary>
        /// Add multiple command to define button group.
        /// </summary>
        /// <typeparam name="TProp"></typeparam>
        /// <param name="property"></param>
        /// <param name="commands"></param>
        /// <returns></returns>
        public ColumnBuilder<T> Commands<TProp>(Expression<Func<T, TProp>> property, IEnumerable<Command> commands)
        {
            return Commands(property, commands, null, "btn-default", "caret");
        }

        /// <summary>
        /// Add multiple command to define button group.
        /// </summary>
        /// <typeparam name="TProp"></typeparam>
        /// <param name="property"></param>
        /// <param name="commands"></param>
        /// <param name="btnText"></param>
        /// <returns></returns>
        public ColumnBuilder<T> Commands<TProp>(Expression<Func<T, TProp>> property, IEnumerable<Command> commands, string btnText)
        {
            return Commands(property, commands, btnText, "btn-default", "caret");
        }

        /// <summary>
        /// Add multiple command to define button group.
        /// </summary>
        /// <typeparam name="TProp"></typeparam>
        /// <param name="property"></param>
        /// <param name="commands"></param>
        /// <param name="btnText"></param>
        /// <param name="btnClass"></param>
        /// <returns></returns>
        public ColumnBuilder<T> Commands<TProp>(Expression<Func<T, TProp>> property, IEnumerable<Command> commands, string btnText, string btnClass)
        {
            return Commands(property, commands, btnText, btnClass, "caret");
        }
    }
}