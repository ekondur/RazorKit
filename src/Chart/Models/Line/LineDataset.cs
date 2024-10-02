namespace HelperJS.Chart.Models.Line
{
    class LineDataset : PointDataset
    {
        public string BorderCapStyle { get; set; }
        public int[] BorderDash { get; set; }
        public double? BorderDashOffset { get; set; }
        public BorderJoinStyle? BorderJoinStyle { get; set; }
        public string CubicInterpolationMode { get; set; }
        public double[] Data { get; set; }
        public bool? DrawActiveElementsOnTop { get; set; }
        public bool? Fill { get; set; }
        public string HoverBorderCapStyle { get; set; }
        public int[] HoverBorderDash { get; set; }
        public double? HoverBorderDashOffset { get; set; }
        public BorderJoinStyle? HoverBorderJoinStyle { get; set; }
        public string IndexAxis { get; set; }
        public object Segment { get; set; }
        public bool? ShowLine { get; set; }
        public bool? SpanGaps { get; set; }
        public string Stack { get; set; }
        public bool? Stepped { get; set; }
        public double? Tension { get; set; }
        public string XAxisID { get; set; }
        public string YAxisID { get; set; }
    }
}
