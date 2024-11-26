using RazorKit.DataTables.Data;
using System.Collections.Generic;

namespace RazorKit.DataTables
{
    /// <summary>
    /// DataRequest Instance
    /// </summary>
    public class DataRequest
    {
        public int draw { get; set; }
        public int start { get; set; }
        public int length { get; set; }
        public List<DataColumn> columns { get; set; }
        public List<DataOrder> order { get; set; }
        public DataSearch search { get; set; }
        public List<DataFilter> filters { get; set; }

        public DataRequest()
        {
            filters = new List<DataFilter>();
            order = new List<DataOrder>();
            columns = new List<DataColumn>();
        }
    }
}
