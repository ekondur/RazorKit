using RazorKit.DataTables.Models;

namespace RazorKit.DataTables.Builders
{
    /// <summary>
    /// Callbacks Configuration.
    /// </summary>
    public class CallbackBuilder
    {
        private readonly DatatableJs _datatable;

        internal CallbackBuilder(DatatableJs datatable)
        {
            _datatable = datatable;
        }

        /// <summary>
        /// Set createdRow function <see href="https://datatables.net/reference/option/createdRow">Reference:</see>
        /// </summary>
        /// <param name="functionName"></param>
        /// <returns></returns>
        public CallbackBuilder CreatedRow(string functionName)
        {
            _datatable.CreatedRow = functionName;
            return this;
        }

        /// <summary>
        /// Set drawCallback function <see href="https://datatables.net/reference/option/drawCallback">Reference:</see>
        /// </summary>
        /// <param name="functionName"></param>
        /// <returns></returns>
        public CallbackBuilder DrawCallback(string functionName)
        {
            _datatable.DrawCallback = functionName;
            return this;
        }

        /// <summary>
        /// Set footerCallback function <see href="https://datatables.net/reference/option/footerCallback">Reference:</see>
        /// </summary>
        /// <param name="functionName"></param>
        /// <returns></returns>
        public CallbackBuilder FooterCallback(string functionName)
        {
            _datatable.FooterCallback = functionName;
            return this;
        }

        /// <summary>
        /// Set formatNumber function <see href="https://datatables.net/reference/option/formatNumber">Reference:</see>
        /// </summary>
        /// <param name="functionName"></param>
        /// <returns></returns>
        public CallbackBuilder FormatNumber(string functionName)
        {
            _datatable.FormatNumber = functionName;
            return this;
        }

        /// <summary>
        /// Set headerCallback function <see href="https://datatables.net/reference/option/headerCallback">Reference:</see>
        /// </summary>
        /// <param name="functionName"></param>
        /// <returns></returns>
        public CallbackBuilder HeaderCallback(string functionName)
        {
            _datatable.HeaderCallback = functionName;
            return this;
        }

        /// <summary>
        /// Set infoCallback function <see href="https://datatables.net/reference/option/infoCallback">Reference:</see>
        /// </summary>
        /// <param name="functionName"></param>
        /// <returns></returns>
        public CallbackBuilder InfoCallback(string functionName)
        {
            _datatable.InfoCallback = functionName;
            return this;
        }

        /// <summary>
        /// Set initComplete function <see href="https://datatables.net/reference/option/initComplete">Reference:</see>
        /// </summary>
        /// <param name="functionName"></param>
        /// <returns></returns>
        public CallbackBuilder InitComplete(string functionName)
        {
            _datatable.InitComplete = functionName;
            return this;
        }

        /// <summary>
        /// Set preDrawCallback function <see href="https://datatables.net/reference/option/preDrawCallback">Reference:</see>
        /// </summary>
        /// <param name="functionName"></param>
        /// <returns></returns>
        public CallbackBuilder PreDrawCallback(string functionName)
        {
            _datatable.PreDrawCallback = functionName;
            return this;
        }

        /// <summary>
        /// Set rowCallback function <see href="https://datatables.net/reference/option/rowCallback">Reference:</see>
        /// </summary>
        /// <param name="functionName"></param>
        /// <returns></returns>
        public CallbackBuilder RowCallback(string functionName)
        {
            _datatable.RowCallback = functionName;
            return this;
        }

        /// <summary>
        /// Set stateLoadCallback function <see href="https://datatables.net/reference/option/stateLoadCallback">Reference:</see>
        /// </summary>
        /// <param name="functionName"></param>
        /// <returns></returns>
        public CallbackBuilder StateLoadCallback(string functionName)
        {
            _datatable.StateLoadCallback = functionName;
            _datatable.StateSave = true;
            return this;
        }

        /// <summary>
        /// Set stateLoadParams function <see href="https://datatables.net/reference/option/stateLoadParams">Reference:</see>
        /// </summary>
        /// <param name="functionName"></param>
        /// <returns></returns>
        public CallbackBuilder StateLoadParams(string functionName)
        {
            _datatable.StateLoadParams = functionName;
            _datatable.StateSave = true;
            return this;
        }

        /// <summary>
        /// Set stateLoaded function <see href="https://datatables.net/reference/option/stateLoaded">Reference:</see>
        /// </summary>
        /// <param name="functionName"></param>
        /// <returns></returns>
        public CallbackBuilder StateLoaded(string functionName)
        {
            _datatable.StateLoaded = functionName;
            _datatable.StateSave = true;
            return this;
        }

        /// <summary>
        /// Set stateSaveCallback function <see href="https://datatables.net/reference/option/stateSaveCallback">Reference:</see>
        /// </summary>
        /// <param name="functionName"></param>
        /// <returns></returns>
        public CallbackBuilder StateSaveCallback(string functionName)
        {
            _datatable.StateSaveCallback = functionName;
            _datatable.StateSave = true;
            return this;
        }

        /// <summary>
        /// Set stateSaveParams function <see href="https://datatables.net/reference/option/stateSaveParams">Reference:</see>
        /// </summary>
        /// <param name="functionName"></param>
        /// <returns></returns>
        public CallbackBuilder StateSaveParams(string functionName)
        {
            _datatable.StateSaveParams = functionName;
            _datatable.StateSave = true;
            return this;
        }
    }
}
