using RazorKit.DataTables.Models;

namespace RazorKit.DataTables.Builders
{
    /// <summary>
    /// Data Configuration.
    /// </summary>
    public class DataSourceBuilder
    {
        private readonly AjaxSource _ajaxSource;

        internal DataSourceBuilder(AjaxSource ajaxSource)
        {
            _ajaxSource = ajaxSource;
        }

        /// <summary>
        /// Set data source URL.
        /// </summary>
        /// <param name="url"></param>
        public DataSourceBuilder URL(string url)
        {
            _ajaxSource.Url = url;
            return this;
        }

        /// <summary>
        /// Set Ajax Http method.
        /// </summary>
        /// <param name="method"></param>
        /// <returns></returns>
        public DataSourceBuilder Method(string method)
        {
            _ajaxSource.Type = method;
            return this;
        }

        /// <summary>
        /// Passing additional data to action set name of javascript function.
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public DataSourceBuilder Data(string data)
        {
            _ajaxSource.Data = data;
            return this;
        }

        /// <summary>
        /// Set naming convention strategy. If not set uses default.
        /// </summary>
        /// <param name="convention"></param>
        /// <returns></returns>
        public DataSourceBuilder Naming(Convention convention)
        {
            _ajaxSource.Convention = convention;
            return this;
        }
    }
}
