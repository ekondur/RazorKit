namespace RazorKit.Datatable.Models
{
    public class Command
    {
        internal string Text { get; set; }
        internal string OnClick { get; set; }
        public string IconClass { get; set; }
        public string BtnClass { get; set; }
        public int? Width { get; set; }
    }
}
