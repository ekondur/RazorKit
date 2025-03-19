namespace RazorKit.ChartJs.Models
{
    class Title
    {
        public TitleAlign? Align { get; set; }
        public string Color { get; set; }
        public bool? Display { get; set; }
        public bool? FullSize { get; set; }
        public TitlePosition? Position { get; set; }
        public ChartFont Font { get; set; }
        public Padding Padding { get; set; }
        public object Text { get; set; }
    }
}