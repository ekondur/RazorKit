using RazorKit.DataTables.Data;
using System.Collections.Generic;

namespace RazorKit.DataTables
{
    /// <summary>
    /// DataRequest Instance
    /// </summary>
    public class DataRequest
    {
        public int Draw { get; set; }
        public int Start { get; set; }
        public int Length { get; set; }
        public List<DataColumn> Columns { get; set; }
        public List<DataOrder> Order { get; set; }
        public DataSearch Search { get; set; }
        public List<DataFilter> Filters { get; set; }

        public DataRequest()
        {
            Filters = new List<DataFilter>();
            Order = new List<DataOrder>();
            Columns = new List<DataColumn>();
        }
    }
}
