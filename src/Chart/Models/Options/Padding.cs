namespace RazorKit.Chart.Models
{
    class Padding
    {
        public int? Left { get; set; }
        public int? Right { get; set; }
        public int? Top { get; set; }
        public int? Bottom { get; set; }

        public Padding() { }

        public Padding(int all)
        {
            Left = Right = Top = Bottom = all;
        }
    }
}
