namespace RazorKit.DataTables.Models
{
    internal class Language
    {
        public string URL { get; set; }
        public string Decimal { get; set; }
        public string EmptyTable { get; set; }
        public string Info { get; set; }
        public string InfoEmpty { get; set; }
        public string InfoFiltered { get; set; }
        public string InfoPostFix { get; set; }
        public string Thousands { get; set; }
        public string LengthMenu { get; set; }
        public string LoadingRecords { get; set; }
        public string Processing { get; set; }
        public string Search { get; set; }
        public string ZeroRecords { get; set; }
        public LanguagePaginate Paginate { get; set; }
        public LanguageAria Aria { get; set; }
    }

    internal class LanguagePaginate
    {
        public string First { get; set; }
        public string Last { get; set; }
        public string Next { get; set; }
        public string Previous { get; set; }
    }

    internal class LanguageAria
    {
        public string SortAscending { get; set; }
        public string SortDescending { get; set; }
        public string Orderable { get; set; }
        public string OrderableReverse { get; set; }
        public string OrderableRemove { get; set; }
    }
}
