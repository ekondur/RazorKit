namespace RazorKit.ChartJs.Models
{
    class LineDataset : PointDataset
    {
        public string CubicInterpolationMode { get; set; }
        public bool? DrawActiveElementsOnTop { get; set; }
        public string IndexAxis { get; set; }
        public object Segment { get; set; }
        public bool? ShowLine { get; set; }
        public string Stack { get; set; }
        public bool? Stepped { get; set; }
        public string XAxisID { get; set; }
        public string YAxisID { get; set; }
    }
}