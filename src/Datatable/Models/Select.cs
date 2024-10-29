namespace RazorKit.Datatable.Models
{
    internal class Select
    {
        public bool? Info { get; set; }
        public SelectStyle? Style { get; set; }
        public SelectItems? Items { get; set; }
        public bool? Toggleable { get; set; }
        public string Selector
        {
            get
            {
                return Items == SelectItems.Checkbox ? "td:first-child" : null;
            }
        }
        public bool Blurable { get; set; } = true;
    }
}
