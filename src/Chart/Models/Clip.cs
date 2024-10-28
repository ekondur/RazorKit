namespace HelperJS.Chart.Models
{
    class Clip
    {
        public int? Left { get; private set; }
        public int? Right { get; private set; }
        public int? Top { get; private set; }
        public int? Bottom { get; private set; }

        public Clip(int left, int right, int top, int bottom) 
        {
            Left = left;
            Right = right;
            Top = top;
            Bottom = bottom;
        }
    }
}
