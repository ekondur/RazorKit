namespace RazorKit.ChartJs.Models
{
    class Interaction
    {
        public InteractionMode Mode { get; set; }
        public bool? Intersect { get; set; }
        public Axis Axis { get; set; }
        public bool? IncludeInvisible { get; set; }
    }
}
