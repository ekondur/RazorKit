namespace HelperJS.Chart.Models
{
    class Clip
    {
        public int? Left { get; set; }
        public int? Right { get; set; }
        public int? Top { get; set; }
        public int? Bottom { get; set; }

        public Clip() { }

        public Clip(int all)
        {
            Left = Right = Top = Bottom = all;
        }
    }
}
