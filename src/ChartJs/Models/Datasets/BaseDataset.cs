namespace RazorKit.ChartJs.Models
{
    class BaseDataset
    {
        public object Data { get; set; }
        public string Label { get; set; }
        public string Type { get; set; }
        public object BackgroundColor { get; set; }
        public object BorderColor { get; set; }
        public int? BorderWidth { get; set; }
        public object Clip { get; set; }
        public object HoverBackgroundColor { get; set; }
        public object HoverBorderColor { get; set; }
        public int? HoverBorderWidth { get; set; }
        public object Parsing { get; set; }
        public bool? Hidden { get; set; }
    }
}
