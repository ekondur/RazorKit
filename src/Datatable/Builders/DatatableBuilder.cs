using System;
using RazorKit.Datatable.Models;
using static System.Net.WebRequestMethods;

namespace RazorKit.Datatable.Builders
{
    /// <summary>
    /// DataTable Configuration.
    /// </summary>
    public class DatatableBuilder<T>
    {
        internal string Id { get; private set; } = "DataTableId";
        internal bool CamelCaseValue { get; set; }
        internal DatatableJs Datatable { get; set; }

        internal DatatableBuilder()
        {
            Datatable = new DatatableJs();
        }

        /// <summary>
        /// Default name/id is "DataTableId".
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public DatatableBuilder<T> Name(string name)
        {
            Id = name;
            return this;
        }

        /// <summary>
        /// Define table columns.
        /// </summary>
        /// <param name="config"></param>
        /// <returns></returns>
        public DatatableBuilder<T> Columns(Action<ColumnBuilder<T>> config)
        {
            var builder = new ColumnBuilder<T>(Datatable);
            config(builder);
            return this;
        }

        /// <summary>
        /// Specify language json url from cdn or local.
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public DatatableBuilder<T> Language(string url)
        {
            Datatable.Language = new Language { URL = url };
            return this;
        }

        /// <summary>
        /// Disable or enable ordering, default is true.
        /// </summary>
        /// <param name="ordering"></param>
        /// <returns></returns>
        public DatatableBuilder<T> Ordering(bool ordering)
        {
            Datatable.Ordering = ordering;
            return this;
        }

        /// <summary>
        /// Disable or enable searching, default is true.
        /// </summary>
        /// <param name="searching"></param>
        /// <returns></returns>
        public DatatableBuilder<T> Searching(bool searching)
        {
            Datatable.Searching = searching;
            return this;
        }

        /// <summary>
        /// Dom allow to control position of datatable elements
        /// </summary>
        /// <param name="dom"></param>
        /// <returns></returns>
        public DatatableBuilder<T> Dom(string dom)
        {
            Datatable.Dom = dom;
            return this;
        }

        /// <summary>
        /// Set css class of table.
        /// </summary>
        /// <param name="cssClass"></param>
        /// <returns></returns>
        public DatatableBuilder<T> Class(string cssClass)
        {
            Datatable.Style = cssClass;
            return this;
        }

        /// <summary>
        /// Disable or enable paging, default is true.
        /// </summary>
        /// <param name="paging"></param>
        /// <returns></returns>
        public DatatableBuilder<T> Paging(bool paging)
        {
            if (paging == false)
            {
                Datatable.ServerSide = false;
            }
            Datatable.Paging = paging;
            return this;
        }

        /// <summary>
        /// Define table page length.
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
        public DatatableBuilder<T> PageLength(int length)
        {
            Datatable.PageLength = length;
            return this;
        }

        /// <summary>
        /// Enable or disable the display of a 'processing' indicator when the table is being processed, Default is true.
        /// </summary>
        /// <param name="processing"></param>
        /// <returns></returns>
        public DatatableBuilder<T> Processing(bool processing)
        {
            Datatable.Processing = processing;
            return this;
        }

        /// <summary>
        /// Enable horizontal scrolling. When a table is too wide to fit into a certain layout, or you have a large number of columns in the table, you can enable horizontal (x) scrolling to show the table in a viewport, which can be scrolled.
        /// </summary>
        /// <param name="scrollX"></param>
        /// <returns></returns>
        public DatatableBuilder<T> ScrollX(bool scrollX)
        {
            Datatable.ScrollX = scrollX;
            return this;
        }

        /// <summary>
        /// Enable or disable state saving such as pagination position, display length, filtering and sorting information.
        /// </summary>
        /// <param name="stateSave"></param>
        /// <returns></returns>
        public DatatableBuilder<T> StateSave(bool stateSave)
        {
            Datatable.StateSave = stateSave;
            return this;
        }
        
        /// <summary>
        /// Is column re-ordering enabled?
        /// </summary>
        /// <param name="enabled"></param>
        /// <returns></returns>
        public DatatableBuilder<T> ColReorder(bool enabled)
        {
            Datatable.ColReorder = enabled;
            return this;
        }
    }
}
