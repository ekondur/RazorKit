namespace RazorKit.DataTables.Models
{
    internal class Filter
    {
        public string Field { get; set; }
        public string Value { get; set; }
        public Operand Operand { get; set; }
    }
}
