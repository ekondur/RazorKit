using RazorKit.Datatable.Models;

namespace RazorKit.Datatable.Builders
{
    /// <summary>
    /// Data Configuration.
    /// </summary>
    public class DataSourceBuilder
    {
        private readonly Ajax _ajax;

        internal DataSourceBuilder(Ajax ajax)
        {
            _ajax = ajax;
        }

        /// <summary>
        /// Set data source URL.
        /// </summary>
        /// <param name="url"></param>
        public DataSourceBuilder URL(string url)
        {
            _ajax.Url = url;
            return this;
        }

        /// <summary>
        /// Set Ajax Http method.
        /// </summary>
        /// <param name="method"></param>
        /// <returns></returns>
        public DataSourceBuilder Method(string method)
        {
            _ajax.Type = method;
            return this;
        }

        /// <summary>
        /// Passing additional data to action set name of javascript function.
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public DataSourceBuilder Data(string data)
        {
            _ajax.Data = data;
            return this;
        }
    }
}
