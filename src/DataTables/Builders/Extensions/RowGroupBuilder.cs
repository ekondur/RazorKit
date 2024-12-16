using RazorKit.DataTables.Models;

namespace RazorKit.DataTables.Builders
{
    /// <summary>
    /// RowGroup configuration.
    /// </summary>
    public class RowGroupBuilder
    {
        private readonly RowGroup _rowGroup;

        internal RowGroupBuilder(RowGroup rowGroup)
        {
            _rowGroup = rowGroup;
        }

        /// <summary>
        /// Set the class name to be used for the grouping rows.
        /// </summary>
        /// <param name="className"></param>
        /// <returns></returns>
        public RowGroupBuilder ClassName(string className)
        {
            _rowGroup.ClassName = className;
            return this;
        }

        /// <summary>
        /// Set the data point to use as the grouping data source.
        /// </summary>
        /// <param name="dataSrc"></param>
        /// <returns></returns>
        public RowGroupBuilder DataSrc(int dataSrc)
        {
            _rowGroup.DataSrc = dataSrc;
            return this;
        }

        /// <summary>
        /// Set the data point to use as the grouping data source.
        /// </summary>
        /// <param name="dataSrc"></param>
        /// <returns></returns>
        public RowGroupBuilder DataSrc(string dataSrc)
        {
            _rowGroup.DataSrc = dataSrc;
            return this;
        }

        /// <summary>
        /// Set the data point to use as the grouping data source.
        /// </summary>
        /// <param name="dataSrc"></param>
        /// <returns></returns>
        public RowGroupBuilder DataSrc(params string[] dataSrc)
        {
            _rowGroup.DataSrc = dataSrc;
            return this;
        }

        /// <summary>
        /// Text to show for rows which have null, undefined or empty string group data.
        /// </summary>
        /// <param name="emptyDataGroup"></param>
        /// <returns></returns>
        public RowGroupBuilder EmptyDataGroup(string emptyDataGroup)
        {
            _rowGroup.EmptyDataGroup = emptyDataGroup;
            return this;
        }

        /// <summary>
        /// Provides the ability to disable row grouping at initialisation.
        /// </summary>
        /// <param name="enable"></param>
        /// <returns></returns>
        public RowGroupBuilder Enable(bool enable)
        {
            _rowGroup.Enable = enable;
            return this;
        }

        /// <summary>
        /// Set the class name to be used for the grouping end rows.
        /// </summary>
        /// <param name="endClassName"></param>
        /// <returns></returns>
        public RowGroupBuilder EndClassName(string endClassName)
        {
            _rowGroup.EndClassName = endClassName;
            return this;
        }

        /// <summary>
        /// Provide a function that can be used to control the data shown in the end grouping row.
        /// </summary>
        /// <param name="endRender"></param>
        /// <returns></returns>
        public RowGroupBuilder EndRender(string endRender)
        {
            _rowGroup.EndRender = endRender;
            return this;
        }

        /// <summary>
        /// Set the class name to be used for the grouping start rows.
        /// </summary>
        /// <param name="startClassName"></param>
        /// <returns></returns>
        public RowGroupBuilder StartClassName(string startClassName)
        {
            _rowGroup.StartClassName = startClassName;
            return this;
        }

        /// <summary>
        /// Provide a function that can be used to control the data shown in the start grouping row.
        /// </summary>
        /// <param name="startRender"></param>
        /// <returns></returns>
        public RowGroupBuilder StartRender(string startRender)
        {
            _rowGroup.StartRender = startRender;
            return this;
        }
    }
}
