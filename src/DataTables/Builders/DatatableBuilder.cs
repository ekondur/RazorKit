using System;
using System.Collections.Generic;
using System.Linq;
using RazorKit.DataTables.Models;

namespace RazorKit.DataTables.Builders
{
    /// <summary>
    /// DataTable Configuration.
    /// </summary>
    public class DatatableBuilder<T>
    {
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
            Datatable.Name = name;
            return this;
        }

        /// <summary>
        /// Define table columns.
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        public DatatableBuilder<T> Columns(Action<ColumnBuilder<T>> action)
        {
            var builder = new ColumnBuilder<T>(Datatable);
            action(builder);
            return this;
        }

        /// <summary>
        /// Data Source Configuration.
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        public DatatableBuilder<T> DataSource(Action<DataSourceBuilder> action)
        {
            Datatable.Ajax = new AjaxSource();
            var builder = new DataSourceBuilder(Datatable.Ajax);
            action(builder);
            return this;
        }

        /// <summary>
        /// Set object data source.
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public DatatableBuilder<T> DataSource(IList<object> data)
        {
            Datatable.Data = data;
            return this;
        }

        /// <summary>
        /// Filter data with request.
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        public DatatableBuilder<T> Filters(Action<FilterBuilder<T>> action)
        {
            var builder = new FilterBuilder<T>(Datatable);
            action(builder);
            return this;
        }

        /// <summary>
        /// Enable ordering and set default orders.
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        public DatatableBuilder<T> Orders(Action<OrderBuilder<T>> action)
        {
            Datatable.Ordering = true;
            Datatable.Order = new List<object[]>();

            var builder = new OrderBuilder<T>(Datatable);
            action(builder);
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
        /// Language Configuration.
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        public DatatableBuilder<T> Language(Action<LanguageBuilder> action)
        {
            Datatable.Language = new Language();
            var builder = new LanguageBuilder(Datatable.Language);
            action(builder);
            return this;
        }

        /// <summary>
        /// Set callback functions. <see href="https://datatables.net/reference/option/">Reference:</see>
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        public DatatableBuilder<T> Callbacks(Action<CallbackBuilder> action)
        {
            var builder = new CallbackBuilder(Datatable);
            action(builder);
            return this;
        }

        /// <summary>
        /// Enable and configure the FixedColumns extension for DataTables.
        /// </summary>
        /// <param name="enabled"></param>
        /// <returns></returns>
        public DatatableBuilder<T> FixedColumns(bool enabled)
        {
            Datatable.FixedColumns = enabled;
            return this;
        }

        /// <summary>
        /// Enable and configure the FixedColumns extension for DataTables.
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        public DatatableBuilder<T> FixedColumns(Action<FixedColumnsBuilder> action)
        {
            Datatable.FixedColumns = new FixedColumns();
            var builder = new FixedColumnsBuilder((FixedColumns)Datatable.FixedColumns);
            action(builder);
            return this;
        }

        /// <summary>
        /// Change the options in the page length select list.
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        public DatatableBuilder<T> LengthMenu(Action<LengthMenuBuilder> action)
        {
            var builder = new LengthMenuBuilder(Datatable);
            action(builder);
            return this;
        }

        /// <summary>
        /// Is FixedHeader enabled?
        /// </summary>
        /// <param name="enabled"></param>
        /// <returns></returns>
        public DatatableBuilder<T> FixedHeader(bool enabled)
        {
            Datatable.FixedHeader = enabled;
            return this;
        }

        /// <summary>
        /// FixedHeader Configuration.
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        public DatatableBuilder<T> FixedHeader(Action<FixedHeaderBuilder> action)
        {
            Datatable.FixedHeader = new FixedHeader();
            var builder = new FixedHeaderBuilder((FixedHeader)Datatable.FixedHeader);
            action(builder);
            return this;
        }

        /// <summary>
        /// Enable the ColReorder extension for DataTables.
        /// </summary>
        /// <param name="enabled"></param>
        /// <returns></returns>
        public DatatableBuilder<T> ColReorder(bool enabled)
        {
            Datatable.ColReorder = enabled;
            return this;
        }

        /// <summary>
        /// Configure the ColReorder extension for DataTables.
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        public DatatableBuilder<T> ColReorder(Action<ColReorderBuilder> action)
        {
            Datatable.ColReorder = new ColReorder();
            var builder = new ColReorderBuilder((ColReorder)Datatable.ColReorder);
            action(builder);
            return this;
        }

        /// <summary>
        /// Enable the RowReorder extension for DataTables.
        /// </summary>
        /// <param name="enabled"></param>
        /// <returns></returns>
        public DatatableBuilder<T> RowReorder(bool enabled)
        {
            Datatable.RowReorder = enabled;
            return this;
        }

        /// <summary>
        /// Configure the RowReorder extension for DataTables.
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        public DatatableBuilder<T> RowReorder(Action<RowReorderBuilder> action)
        {
            Datatable.RowReorder = new RowReorder();
            var builder = new RowReorderBuilder((RowReorder)Datatable.RowReorder);
            action(builder);
            return this;
        }

        /// <summary>
        /// Enable the RowGroup extension for DataTables.
        /// </summary>
        /// <param name="enabled"></param>
        /// <returns></returns>
        public DatatableBuilder<T> RowGroup(bool enabled)
        {
            Datatable.RowGroup = enabled;
            return this;
        }

        /// <summary>
        /// Configure the RowGroup extension for DataTables.
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        public DatatableBuilder<T> RowGroup(Action<RowGroupBuilder> action)
        {
            Datatable.RowGroup = new RowGroup();
            var builder = new RowGroupBuilder((RowGroup)Datatable.RowGroup);
            action(builder);
            return this;
        }

        /// <summary>
        /// Enable the KeyTable extension for DataTables.
        /// </summary>
        /// <param name="enabled"></param>
        /// <returns></returns>
        public DatatableBuilder<T> KeyTable(bool enabled)
        {
            Datatable.Keys = enabled;
            return this;
        }

        /// <summary>
        /// Configure the KeyTable extension for DataTables.
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        public DatatableBuilder<T> KeyTable(Action<KeyTableBuilder> action)
        {
            Datatable.Keys = new KeyTable();
            var builder = new KeyTableBuilder((KeyTable)Datatable.Keys);
            action(builder);
            return this;
        }

        /// <summary>
        /// Enable selection.
        /// </summary>
        /// <param name="enabled"></param>
        /// <returns></returns>
        public DatatableBuilder<T> Select(bool enabled)
        {
            Datatable.Select = enabled;
            return this;
        }

        /// <summary>
        /// Select Configuration.
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        public DatatableBuilder<T> Select(Action<SelectBuilder> action)
        {
            var builder = new SelectBuilder(Datatable);
            action(builder);
            return this;
        }

        /// <summary>
        /// Enable the AutoFill extension for DataTables.
        /// </summary>
        /// <param name="enabled"></param>
        /// <returns></returns>
        public DatatableBuilder<T> AutoFill(bool enabled)
        {
            Datatable.AutoFill = enabled;
            return this;
        }

        /// <summary>
        /// Configure the AutoFill extension for DataTables.
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        public DatatableBuilder<T> AutoFill(Action<AutoFillBuilder> action)
        {
            Datatable.AutoFill = new AutoFill();
            var builder = new AutoFillBuilder((AutoFill)Datatable.AutoFill);
            action(builder);
            return this;
        }

        /// <summary>
        /// Define and position the table control elements to appear on the page.
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        public DatatableBuilder<T> Layout(Action<LayoutsBuilder> action)
        {
            Datatable.Layout = new Dictionary<string, object>();
            var builder = new LayoutsBuilder(Datatable.Layout);
            action(builder);
            return this;
        }

        /// <summary>
        /// Add built-in buttons.
        /// </summary>
        /// <param name="buttons"></param>
        /// <returns></returns>
        public DatatableBuilder<T> Buttons(params string[] buttons)
        {
            Datatable.Buttons = buttons.Cast<object>().ToList();
            return this;
        }

        /// <summary>
        /// Buttons Configuration.
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        public DatatableBuilder<T> Button(Action<ButtonBuilder> action)
        {
            if (Datatable.Buttons == null)
            {
                Datatable.Buttons = new List<object>();
            }

            var builder = new ButtonBuilder(Datatable.Buttons);
            action(builder);
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
        public DatatableBuilder<T> Style(string cssClass)
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
        /// Enable server-side processing mode.
        /// </summary>
        /// <param name="serverSide"></param>
        /// <returns></returns>
        public DatatableBuilder<T> ServerSide(bool serverSide)
        {
            Datatable.ServerSide = serverSide;
            return this;
        }

        /// <summary>
        /// Number of rows to display on a single page when using pagination. <see href="https://datatables.net/reference/option/pageLength">Reference:</see>
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
        /// Set a caption for the table.
        /// </summary>
        /// <param name="caption"></param>
        /// <returns></returns>
        public DatatableBuilder<T> Caption(string caption)
        {
            Datatable.Caption = caption;
            return this;
        }

        /// <summary>
        /// Enable the Responsive extension for DataTables.
        /// </summary>
        /// <param name="responsive"></param>
        /// <returns></returns>
        public DatatableBuilder<T> Responsive(bool responsive)
        {
            Datatable.Responsive = responsive;
            return this;
        }

        /// <summary>
        /// Configure the Responsive extension for DataTables.
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        public DatatableBuilder<T> Responsive(Action<ResponsiveBuilder> action)
        {
            Datatable.Responsive = new Responsive();
            var builder = new ResponsiveBuilder((Responsive)Datatable.Responsive);
            action(builder);
            return this;
        }
    }
}
