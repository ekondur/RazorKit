using RazorKit.DataTables.Models;

namespace RazorKit.DataTables.Builders
{
    /// <summary>
    /// ColReorder Configuration.
    /// </summary>
    public class ColReorderBuilder
    {
        private readonly ColReorder _colReorder;

        internal ColReorderBuilder(ColReorder colReorder)
        {
            _colReorder = colReorder;
        }

        /// <summary>
        /// Initial enablement state of ColReorder.
        /// </summary>
        /// <param name="enable"></param>
        /// <returns></returns>
        public ColReorderBuilder Enable(bool enable)
        {
            _colReorder.Enable = enable;
            return this;
        }

        /// <summary>
        /// Set a default order for the columns in the table.
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public ColReorderBuilder Order(params int[] order)
        {
            _colReorder.Order = order;
            return this;
        }

        /// <summary>
        /// Select which columns can be reordered.
        /// </summary>
        /// <param name="columns"></param>
        /// <returns></returns>
        public ColReorderBuilder Columns(string columns)
        {
            _colReorder.Columns = columns;
            return this;
        }
    }
}
