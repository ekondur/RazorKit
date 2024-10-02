namespace HelperJS.Chart.Models
{
    class Title
    {
        public Align? Align { get; set; }

        public string Color { get; set; }

        public bool? Display { get; set; }

        public bool? FullSize { get; set; }

        public TitlePosition? Position { get; set; }

        public ChartFont Font { get; set; }

        public Padding Padding { get; set; }

        public string[] Text { get; set; }
    }
}