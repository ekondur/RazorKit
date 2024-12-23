﻿namespace RazorKit.ChartJs.Models
{
    partial class Scale
    {
        // Common options to all axes
        public string Type { get; set; }
        public bool? AlignToPixels { get; set; }
        public string BackgroundColor { get; set; }
        public ScaleBorder Border { get; set; }
        public object Display { get; set; }
        public Grid Grid { get; set; }
        public int? Min { get; set; }
        public int? Max { get; set; }
        public bool? Reverse { get; set; }
        public object Stacked { get; set; }
        public int? SuggestedMax { get; set; }
        public int? SuggestedMin { get; set; }
        public Ticks Ticks { get; set; }
        public int? Weight { get; set; }

        // Linear Axis specific options
        public bool? BeginAtZero { get; set; }
        public object Grace { get; set; }

        // Common options to all cartesian axes
        public Bounds? Bounds { get; set; }
        public bool? Clip { get; set; }
        public AxisPosition? Position { get; set; }
        public string Stack { get; set; }
        public int? StackWeight { get; set; }
        public string Axis { get; set; }
        public bool? Offset { get; set; }
        public ScaleTitle Title { get; set; }
    }
}
