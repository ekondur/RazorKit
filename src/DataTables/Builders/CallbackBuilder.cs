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
        /// Callback for whenever a TR element is created for the table's body.
        /// </summary>
        /// <param name="functionName"></param>
        /// <returns></returns>
        public CallbackBuilder CreatedRow(string functionName)
        {
            _datatable.CreatedRow = functionName;
            return this;
        }

        /// <summary>
        /// Function that is called every time DataTables performs a draw.
        /// </summary>
        /// <param name="functionName"></param>
        /// <returns></returns>
        public CallbackBuilder DrawCallback(string functionName)
        {
            _datatable.DrawCallback = functionName;
            return this;
        }

        /// <summary>
        /// Footer display callback function.
        /// </summary>
        /// <param name="functionName"></param>
        /// <returns></returns>
        public CallbackBuilder FooterCallback(string functionName)
        {
            _datatable.FooterCallback = functionName;
            return this;
        }

        /// <summary>
        /// Number formatting callback function.
        /// </summary>
        /// <param name="functionName"></param>
        /// <returns></returns>
        public CallbackBuilder FormatNumber(string functionName)
        {
            _datatable.FormatNumber = functionName;
            return this;
        }

        /// <summary>
        /// Header display callback function.
        /// </summary>
        /// <param name="functionName"></param>
        /// <returns></returns>
        public CallbackBuilder HeaderCallback(string functionName)
        {
            _datatable.HeaderCallback = functionName;
            return this;
        }

        /// <summary>
        /// Table summary information display callback.
        /// </summary>
        /// <param name="functionName"></param>
        /// <returns></returns>
        public CallbackBuilder InfoCallback(string functionName)
        {
            _datatable.InfoCallback = functionName;
            return this;
        }

        /// <summary>
        /// Initialisation complete callback.
        /// </summary>
        /// <param name="functionName"></param>
        /// <returns></returns>
        public CallbackBuilder InitComplete(string functionName)
        {
            _datatable.InitComplete = functionName;
            return this;
        }

        /// <summary>
        /// Pre-draw callback.
        /// </summary>
        /// <param name="functionName"></param>
        /// <returns></returns>
        public CallbackBuilder PreDrawCallback(string functionName)
        {
            _datatable.PreDrawCallback = functionName;
            return this;
        }

        /// <summary>
        /// Row draw callback.
        /// </summary>
        /// <param name="functionName"></param>
        /// <returns></returns>
        public CallbackBuilder RowCallback(string functionName)
        {
            _datatable.RowCallback = functionName;
            return this;
        }

        /// <summary>
        /// Callback that defines where and how a saved state should be loaded.
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
        /// State loaded - data manipulation callback.
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
        /// State loaded callback.
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
        /// Callback that defines how the table state is stored and where.
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
        /// State save - data manipulation callback.
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
