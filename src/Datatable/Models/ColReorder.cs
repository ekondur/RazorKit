namespace RazorKit.Datatable.Models
{
    internal class ColReorder
    {
        public bool? Enable { get; set; }
        public int? FixedColumnsLeft { get; set; }
        public int? FixedColumnsRight { get; set; }
        public string Order { get; set; }
        public bool? RealTime { get; set; }
    }
}
