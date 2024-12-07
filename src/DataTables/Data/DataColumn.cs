namespace RazorKit.DataTables
{
    public class DataColumn
    {
        public string Data { get; set; }
        public string Name { get; set; }
        public bool Searchable { get; set; }
        public bool Orderable { get; set; }
        public DataSearch Search { get; set; }
    }
}
