namespace HelperJS.Chart.Models
{
    internal class ArcDataset : BaseDataset
    {
        public BorderAlign? BorderAlign { get; set; }
        public int[] BorderDash { get; set; }
        public double? BorderDashOffset { get; set; }
        public JoinStyle? BorderJoinStyle { get; set; }
        public new int[] Data { get; set; }
    }
}
