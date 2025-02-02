﻿using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace RazorKit
{
    /// <summary>
    /// There are three possible values for this property: "round", "bevel", and "miter". 
    /// The default is "miter".
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum JoinStyle
    {
        /// <summary>
        /// Connected segments are joined by extending their outside edges to connect at a single point, with the effect of filling an additional lozenge-shaped area. 
        /// This setting is effected by the miterLimit property.
        /// </summary>
        [EnumMember(Value = "miter")]
        Miter,

        /// <summary>
        /// Rounds off the corners of a shape by filling an additional sector of disc centered at the common endpoint of connected segments. 
        /// The radius for these rounded corners is equal to the line width.
        /// </summary>
        [EnumMember(Value = "round")]
        Round,

        /// <summary>
        /// Fills an additional triangular area between the common endpoint of connected segments,
        /// and the separate outside rectangular corners of each segment.
        /// </summary>
        [EnumMember(Value = "bevel")]
        Bevel
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum PointStyle
    {
        [EnumMember(Value = "circle")]
        Circle,

        [EnumMember(Value = "cross")]
        Cross,

        [EnumMember(Value = "crossRot")]
        CrossRot,

        [EnumMember(Value = "dash")]
        Dash,

        [EnumMember(Value = "line")]
        Line,

        [EnumMember(Value = "rect")]
        Rect,

        [EnumMember(Value = "rectRounded")]
        RectRounded,

        [EnumMember(Value = "rectRot")]
        RectRot,

        [EnumMember(Value = "star")]
        Star,

        [EnumMember(Value = "triangle")]
        Triangle,
    }

    /// <summary>
    /// Easing function to use.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AnimationEasing
    {
        [EnumMember(Value = "linear")]
        Linear,

        [EnumMember(Value = "easeInQuad")]
        EaseInQuad,

        [EnumMember(Value = "easeOutQuad")]
        EaseOutQuad,

        [EnumMember(Value = "easeInOutQuad")]
        EaseInOutQuad,

        [EnumMember(Value = "easeInCubic")]
        EaseInCubic,

        [EnumMember(Value = "easeOutCubic")]
        EaseOutCubic,

        [EnumMember(Value = "easeInOutCubic")]
        EaseInOutCubic,

        [EnumMember(Value = "easeInQuart")]
        EaseInQuart,

        [EnumMember(Value = "easeOutQuart")]
        EaseOutQuart,

        [EnumMember(Value = "easeInOutQuart")]
        EaseInOutQuart,

        [EnumMember(Value = "easeInQuint")]
        EaseInQuint,

        [EnumMember(Value = "easeOutQuint")]
        EaseOutQuint,

        [EnumMember(Value = "easeInOutQuint")]
        EaseInOutQuint,

        [EnumMember(Value = "easeInSine")]
        EaseInSine,

        [EnumMember(Value = "easeOutSine")]
        EaseOutSine,

        [EnumMember(Value = "easeInOutSine")]
        EaseInOutSine,

        [EnumMember(Value = "easeInExpo")]
        EaseInExpo,

        [EnumMember(Value = "easeOutExpo")]
        EaseOutExpo,

        [EnumMember(Value = "easeInOutExpo")]
        EaseInOutExpo,

        [EnumMember(Value = "easeInCirc")]
        EaseInCirc,

        [EnumMember(Value = "easeOutCirc")]
        EaseOutCirc,

        [EnumMember(Value = "easeInOutCirc")]
        EaseInOutCirc,

        [EnumMember(Value = "easeInElastic")]
        EaseInElastic,

        [EnumMember(Value = "easeOutElastic")]
        EaseOutElastic,

        [EnumMember(Value = "easeInOutElastic")]
        EaseInOutElastic,

        [EnumMember(Value = "easeInBack")]
        EaseInBack,

        [EnumMember(Value = "easeOutBack")]
        EaseOutBack,

        [EnumMember(Value = "easeInOutBack")]
        EaseInOutBack,

        [EnumMember(Value = "easeInBounce")]
        EaseInBounce,

        [EnumMember(Value = "easeOutBounce")]
        EaseOutBounce,

        [EnumMember(Value = "easeInOutBounce")]
        EaseInOutBounce,
    }

    /// <summary>
    /// Alignment of Title, Subtitle
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TitleAlign
    {
        [EnumMember(Value = "center")]
        Center,

        [EnumMember(Value = "start")]
        Start,

        [EnumMember(Value = "end")]
        End
    }

    /// <summary>
    /// Alignment of Legent
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum LegendAlign
    {
        [EnumMember(Value = "center")]
        Center,

        [EnumMember(Value = "start")]
        Start,

        [EnumMember(Value = "end")]
        End
    }

    /// <summary>
    /// Alignment of the title.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TextAlign
    {
        [EnumMember(Value = "center")]
        Center,

        [EnumMember(Value = "left")]
        Left,

        [EnumMember(Value = "right")]
        Right
    }

    /// <summary>
    /// Position of the title.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TitlePosition
    {
        [EnumMember(Value = "top")]
        Top,

        [EnumMember(Value = "left")]
        Left,

        [EnumMember(Value = "bottom")]
        Bottom
    }

    /// <summary>
    /// Weight
    /// </summary>
    public enum FontWeight
    {
        Normal,

        Bold,

        Lighter,

        Bolder
    }

    /// <summary>
    /// Position of the legend.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum LegendPosition
    {
        [EnumMember(Value = "top")]
        Top,

        [EnumMember(Value = "left")]
        Left,

        [EnumMember(Value = "bottom")]
        Bottom,

        [EnumMember(Value = "right")]
        Right,

        [EnumMember(Value = "chartArea")]
        ChartArea
    }

    /// <summary>
    /// Mode
    /// </summary>
    public enum InteractionMode
    {
        Point,
        Nearest,
        Index,
        Dataset,
        X,
        Y
    }

    /// <summary>
    /// Position
    /// </summary>
    public enum TooltipPosition
    {
        Average,
        Nearest
    }

    /// <summary>
    /// Axis
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Axis
    {
        [EnumMember(Value = "x")]
        X,

        [EnumMember(Value = "y")]
        Y,

        [EnumMember(Value = "xy")]
        XY,

        [EnumMember(Value = "r")]
        R
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ChartEvent
    {
        [EnumMember(Value = "mousemove")]
        Mousemove,

        [EnumMember(Value = "mouseout")]
        Mouseout,

        [EnumMember(Value = "click")]
        Click,

        [EnumMember(Value = "touchstart")]
        Touchstart
    }

    /// <summary>
    /// The bounds property controls the scale boundary strategy (bypassed by min/max options).
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Bounds
    {
        /// <summary>
        /// : makes sure ticks are fully visible, data outside are truncated
        /// </summary>
        [EnumMember(Value = "ticks")]
        Ticks,

        /// <summary>
        /// : makes sure data are fully visible, labels outside are removed
        /// </summary>
        [EnumMember(Value = "data")]
        Data
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum AxisPosition
    {
        [EnumMember(Value = "top")]
        Top,

        [EnumMember(Value = "left")]
        Left,

        [EnumMember(Value = "bottom")]
        Bottom,

        [EnumMember(Value = "right")]
        Right,

        [EnumMember(Value = "center")]
        Center
    }

    /// <summary>
    /// Decimation algorithm to use for data.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Algorithm
    {
        /// <summary>
        /// Lttb decimation reduces the number of data points significantly. 
        /// This is most useful for showing trends in data using only a few data points.
        /// </summary>
        [EnumMember(Value = "lttb")]
        Lttb,

        /// <summary>
        /// Min/max decimation will preserve peaks in your data but could require up to 4 points for each pixel. 
        /// This type of decimation would work well for a very noisy signal where you need to see data peaks.
        /// </summary>
        [EnumMember(Value = "min-max")]
        MinMax
    }

    /// <summary>
    /// Line cap style.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CapStyle
    {
        /// <summary>
        /// The ends of lines are squared off at the endpoints.
        /// </summary>
        [EnumMember(Value = "butt")]
        Butt,

        /// <summary>
        /// The ends of lines are rounded.
        /// </summary>
        [EnumMember(Value = "round")]
        Round,

        /// <summary>
        /// The ends of lines are squared off by adding a box with an equal width and half the height of the line's thickness.
        /// </summary>
        [EnumMember(Value = "square")]
        Square
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Skipped
    {
        [EnumMember(Value = "start")]
        Start,

        [EnumMember(Value = "end")]
        End,

        [EnumMember(Value = "middle")]
        Middle,

        [EnumMember(Value = "bottom")]
        Bottom,

        [EnumMember(Value = "left")]
        Left,

        [EnumMember(Value = "top")]
        Top,

        [EnumMember(Value = "right")]
        Right,
    }

    /// <summary>
    /// Arc stroke alignment.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum BorderAlign
    {
        /// <summary>
        /// Center
        /// </summary>
        [EnumMember(Value = "center")]
        Center,

        /// <summary>
        /// Inner
        /// </summary>
        [EnumMember(Value = "inner")]
        Inner
    }

    /// <summary>
    /// The base axis of the dataset. 'x' for vertical bars and 'y' for horizontal bars.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum IndexAxis
    {
        /// <summary>
        /// x axis
        /// </summary>
        X,

        /// <summary>
        /// y axis
        /// </summary>
        Y
    }

    /// <summary>
    /// Filler draw time.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DrawTime
    {
        /// <summary>
        /// Before draw
        /// </summary>
        [EnumMember(Value = "beforeDraw")]
        BeforeDraw,

        /// <summary>
        /// Before dataset draw
        /// </summary>
        [EnumMember(Value = "beforeDatasetDraw")]
        BeforeDatasetDraw,

        /// <summary>
        /// Before Datasets draw
        /// </summary>
        [EnumMember(Value = "beforeDatasetsDraw")]
        BeforeDatasetsDraw
    }

    /// <summary>
    /// The tick alignment along the axis.
    /// </summary>
    public enum TicksAlign
    {
        [EnumMember(Value = "start")]
        Start,

        [EnumMember(Value = "center")]
        Center,

        [EnumMember(Value = "end")]
        End,

        [EnumMember(Value = "inner")]
        Inner
    }

    /// <summary>
    /// The tick alignment perpendicular to the axis.
    /// </summary>
    public enum TicksCrossAlign
    {
        [EnumMember(Value = "near")]
        Near,

        [EnumMember(Value = "center")]
        Center,

        [EnumMember(Value = "far")]
        Far
    }

    /// <summary>
    /// Interpolation Mode
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum InterpolationMode
    {
        /// <summary>
        /// It uses a custom weighted cubic interpolation, which produces pleasant curves for all types of datasets.
        /// </summary>
        [EnumMember(Value = "default")]
        Default,

        /// <summary>
        /// It is more suited to y = f(x) datasets: it preserves monotonicity (or piecewise monotonicity) of the dataset being interpolated, 
        /// and ensures local extremums (if any) stay at input data points.
        /// </summary>
        [EnumMember(Value = "monotone")]
        Monotone
    }
}
