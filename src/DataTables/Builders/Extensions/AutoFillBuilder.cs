using RazorKit.DataTables.Models;

namespace RazorKit.DataTables.Builders
{
    /// <summary>
    /// Autofill Configuration.
    /// </summary>
    public class AutoFillBuilder
    {
        private readonly AutoFill _autoFill;

        internal AutoFillBuilder(AutoFill autoFill)
        {
            _autoFill = autoFill;
        }

        /// <summary>
        /// Always ask the end user if an action should be taken or not.
        /// </summary>
        /// <param name="alwaysAsk"></param>
        /// <returns></returns>
        public AutoFillBuilder AlwaysAsk(bool alwaysAsk)
        {
            _autoFill.AlwaysAsk = alwaysAsk;
            return this;
        }

        /// <summary>
        /// Select the columns that can be auto filled.
        /// </summary>
        /// <param name="columns"></param>
        /// <returns></returns>
        public AutoFillBuilder Columns(string columns)
        {
            _autoFill.Columns = columns;
            return this;
        }

        /// <summary>
        /// Attach an Editor instance for database updating.
        /// </summary>
        /// <param name="editor"></param>
        /// <returns></returns>
        public AutoFillBuilder Editor(string editor)
        {
            _autoFill.Editor = editor;
            return this;
        }

        /// <summary>
        /// Initial enablement state of AutoFill.
        /// </summary>
        /// <param name="enable"></param>
        /// <returns></returns>
        public AutoFillBuilder Enable(bool enable)
        {
            _autoFill.Enable = enable;
            return this;
        }

        /// <summary>
        /// Action that will cause the auto fill drag handle to appear in a cell.
        /// </summary>
        /// <param name="focus"></param>
        /// <returns></returns>
        public AutoFillBuilder Focus(string focus)
        {
            _autoFill.Focus = focus;
            return this;
        }

        /// <summary>
        /// Enable / disable user ability to horizontally drag and fill.
        /// </summary>
        /// <param name="horizontal"></param>
        /// <returns></returns>
        public AutoFillBuilder Horizontal(bool horizontal)
        {
            _autoFill.Horizontal = horizontal;
            return this;
        }

        /// <summary>
        /// Control automatic update of data when a fill drag is completed.
        /// </summary>
        /// <param name="update"></param>
        /// <returns></returns>
        public AutoFillBuilder Update(bool update)
        {
            _autoFill.Update = update;
            return this;
        }

        /// <summary>
        /// Enable / disable user ability to vertically drag and fill.
        /// </summary>
        /// <param name="vertical"></param>
        /// <returns></returns>
        public AutoFillBuilder Vertical(bool vertical)
        {
            _autoFill.Vertical = vertical;
            return this;
        }
    }
}
