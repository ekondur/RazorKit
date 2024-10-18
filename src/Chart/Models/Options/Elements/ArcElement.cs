namespace HelperJS.Chart.Models
{
    internal class ArcElement : BaseElement
    {
        public int? Angle { get; set; }
        public BorderAlign? BorderAlign { get; set; }
        public int[] BorderDash { get; set; }
        public double? BorderDashOffset { get; set; }
        public JoinStyle? BorderJoinStyle { get; set; }
        public bool? Circular { get; set; }
    }
}
