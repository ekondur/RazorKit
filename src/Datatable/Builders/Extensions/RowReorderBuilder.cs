using RazorKit.Datatable.Models;

namespace RazorKit.Datatable.Builders
{
    /// <summary>
    /// RowReorder Configuration.
    /// </summary>
    public class RowReorderBuilder
    {
        private readonly RowReorder _rowReorder;

        internal RowReorderBuilder(RowReorder rowReorder)
        {
            _rowReorder = rowReorder;
        }

        /// <summary>
        /// Enable / disable the canceling of the drag and drop interaction.
        /// </summary>
        /// <param name="cancelable"></param>
        /// <returns></returns>
        public RowReorderBuilder Cancelable(bool cancelable)
        {
            _rowReorder.Cancelable = cancelable;
            return this;
        }

        /// <summary>
        /// Configure the data point that will be used for the reordering data.
        /// </summary>
        /// <param name="dataSrc"></param>
        /// <returns></returns>
        public RowReorderBuilder DataSrc(string dataSrc)
        {
            _rowReorder.DataSrc = dataSrc;
            return this;
        }

        /// <summary>
        /// Attach an Editor instance for database updating.
        /// </summary>
        /// <param name="editor"></param>
        /// <returns></returns>
        public RowReorderBuilder Editor(string editor)
        {
            _rowReorder.Editor = editor;
            return this;
        }

        /// <summary>
        /// Enable / disable RowReorder's user interaction.
        /// </summary>
        /// <param name="enable"></param>
        /// <returns></returns>
        public RowReorderBuilder Enable(bool enable)
        {
            _rowReorder.Enable = enable;
            return this;
        }

        /// <summary>
        /// Set the options for the Editor form when submitting data.
        /// </summary>
        /// <param name="submit"></param>
        /// <returns></returns>
        public RowReorderBuilder FormOptions(string submit)
        {
            _rowReorder.FormOptions = new FormOptions { Submit = submit };
            return this;
        }

        /// <summary>
        /// Define the selector used to pick the elements that will start a drag.
        /// </summary>
        /// <param name="selector"></param>
        /// <returns></returns>
        public RowReorderBuilder Selector(string selector)
        {
            _rowReorder.Selector = selector;
            return this;
        }

        /// <summary>
        /// Horizontal position control of the row being dragged.
        /// </summary>
        /// <param name="snap"></param>
        /// <returns></returns>
        public RowReorderBuilder SnapX(bool snap)
        {
            _rowReorder.SnapX = snap;
            return this;
        }

        /// <summary>
        /// Control automatic of data when a row is dropped.
        /// </summary>
        /// <param name="update"></param>
        /// <returns></returns>
        public RowReorderBuilder Update(bool update)
        {
            _rowReorder.Update = update;
            return this;
        }
    }
}
