namespace RazorKit.DataTables
{
    public class DataColumn
    {
        public string data { get; set; }
        public string name { get; set; }
        public bool searchable { get; set; }
        public bool orderable { get; set; }
        public DataSearch search { get; set; }
    }
}
