using RazorKit.DataTables.Models;

namespace RazorKit.DataTables.Builders
{
    /// <summary>
    /// Select Configuration.
    /// </summary>
    public class SelectBuilder
    {
        private readonly Select _select;
        private readonly DatatableJs _datatableJs;

        internal SelectBuilder(DatatableJs datatable)
        {
            _datatableJs = datatable;
            _datatableJs.Select = _select = new Select();
        }

        /// <summary>
        /// Set the class name that will be applied to selected items.
        /// </summary>
        /// <param name="className"></param>
        /// <returns></returns>
        public SelectBuilder ClassName(string className)
        {
            _select.ClassName = className;
            return this;
        }

        /// <summary>
        /// Indicate if the selected items will be removed when clicking outside of the table.
        /// </summary>
        /// <param name="blurable"></param>
        /// <returns></returns>
        public SelectBuilder Blurable(bool blurable)
        {
            _select.Blurable = blurable;
            return this;
        }

        /// <summary>
        /// Control automatic addition of header checkbox.
        /// </summary>
        /// <returns></returns>
        public SelectBuilder HeaderCheckbox()
        {
            return HeaderCheckbox(false);
        }

        /// <summary>
        /// Control automatic addition of header checkbox. Limit with page selection.
        /// </summary>
        /// <param name="selectPage"></param>
        /// <returns></returns>
        public SelectBuilder HeaderCheckbox(bool selectPage)
        {
            _select.HeaderCheckbox = selectPage ? "select-page" : "select-all";

            _datatableJs.Columns.Insert(0, new Column
            {
                Orderable = false,
                Searchable = false,
                Render = "DataTable.render.select()"
            });

            return this;
        }

        /// <summary>
        /// Enable / disable the display for item selection information in the table summary.
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public SelectBuilder Info(bool info)
        {
            _select.Info = info;
            return this;
        }

        /// <summary>
        /// Set which table items to select (rows, columns or cells).
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public SelectBuilder Items(SelectItems items)
        {
            _select.Items = items;
            return this;
        }

        /// <summary>
        /// Set the element selector used for mouse event capture to select items.
        /// </summary>
        /// <param name="selector"></param>
        /// <returns></returns>
        public SelectBuilder Selector(string selector)
        {
            _select.Selector = selector;
            return this;
        }

        /// <summary>
        /// Set the selection style for end user interaction with the table.
        /// </summary>
        /// <param name="style"></param>
        /// <returns></returns>
        public SelectBuilder Style(SelectStyle style)
        {
            _select.Style = style;
            return this;
        }

        /// <summary>
        /// Disable the deselection of selected rows when clicked.
        /// </summary>
        /// <param name="toggleable"></param>
        /// <returns></returns>
        public SelectBuilder Toggleable(bool toggleable)
        {
            _select.Toggleable = toggleable;
            return this;
        }

        /// <summary>
        /// Set a function that will determine if a row should be selectable.
        /// </summary>
        /// <param name="selectable"></param>
        /// <returns></returns>
        public SelectBuilder Selectable(string selectable)
        {
            _select.Selectable = selectable;
            return this;
        }
    }
}