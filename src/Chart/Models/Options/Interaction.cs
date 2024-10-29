namespace RazorKit.Chart.Models
{
    class Interaction
    {
        public Mode Mode { get; set; }
        public bool? Intersect { get; set; }
        public Axis Axis { get; set; }
        public bool? IncludeInvisible { get; set; }
    }
}
