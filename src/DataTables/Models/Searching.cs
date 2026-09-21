using Newtonsoft.Json;

namespace RazorKit.DataTables.Models
{
    /// <summary>
    /// Represent the Search options for the DataTable. 
    /// Since <see cref="JsonSerializerSettings"/> will ignore null values, 
    /// all values are optional preventing to search options to fail silently.
    /// <see cref="https://datatables.net/ref/core/type/DataTable.SearchOptions#top"/>
    /// </summary>
    public class SearchOptions
    {
        public bool? Return { get; set; }
        public string Placeholder { get; set; } = default;
        public string Search { get; set; } = default;
        public bool? Boundary { get; set; }
        public bool? Smart { get; set; }
        public bool? CaseInsensitive { get; set; }
        public bool? Regex { get; set; }
    }
}
