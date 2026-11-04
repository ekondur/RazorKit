using Newtonsoft.Json.Converters;
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

    /// <summary>Specifies the shape used to draw a data point.</summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PointStyle
    {
        /// <summary>A circular marker.</summary>
        [EnumMember(Value = "circle")]
        Circle,

        /// <summary>A plus-shaped marker.</summary>
        [EnumMember(Value = "cross")]
        Cross,

        /// <summary>A diagonal cross marker.</summary>
        [EnumMember(Value = "crossRot")]
        CrossRot,

        /// <summary>A short stroke extending from the point.</summary>
        [EnumMember(Value = "dash")]
        Dash,

        /// <summary>A straight line centered on the point.</summary>
        [EnumMember(Value = "line")]
        Line,

        /// <summary>A square marker.</summary>
        [EnumMember(Value = "rect")]
        Rect,

        /// <summary>A square marker with rounded corners.</summary>
        [EnumMember(Value = "rectRounded")]
        RectRounded,

        /// <summary>A diamond-shaped marker.</summary>
        [EnumMember(Value = "rectRot")]
        RectRot,

        /// <summary>A star-shaped marker.</summary>
        [EnumMember(Value = "star")]
        Star,

        /// <summary>A triangular marker.</summary>
        [EnumMember(Value = "triangle")]
        Triangle,
    }

    /// <summary>
    /// Easing function to use.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AnimationEasing
    {
        /// <summary>Animates at a constant rate.</summary>
        [EnumMember(Value = "linear")]
        Linear,

        /// <summary>Applies quadratic easing at the start of the animation.</summary>
        [EnumMember(Value = "easeInQuad")]
        EaseInQuad,

        /// <summary>Applies quadratic easing at the end of the animation.</summary>
        [EnumMember(Value = "easeOutQuad")]
        EaseOutQuad,

        /// <summary>Applies quadratic easing at both ends of the animation.</summary>
        [EnumMember(Value = "easeInOutQuad")]
        EaseInOutQuad,

        /// <summary>Applies cubic easing at the start of the animation.</summary>
        [EnumMember(Value = "easeInCubic")]
        EaseInCubic,

        /// <summary>Applies cubic easing at the end of the animation.</summary>
        [EnumMember(Value = "easeOutCubic")]
        EaseOutCubic,

        /// <summary>Applies cubic easing at both ends of the animation.</summary>
        [EnumMember(Value = "easeInOutCubic")]
        EaseInOutCubic,

        /// <summary>Applies quartic easing at the start of the animation.</summary>
        [EnumMember(Value = "easeInQuart")]
        EaseInQuart,

        /// <summary>Applies quartic easing at the end of the animation.</summary>
        [EnumMember(Value = "easeOutQuart")]
        EaseOutQuart,

        /// <summary>Applies quartic easing at both ends of the animation.</summary>
        [EnumMember(Value = "easeInOutQuart")]
        EaseInOutQuart,

        /// <summary>Applies quintic easing at the start of the animation.</summary>
        [EnumMember(Value = "easeInQuint")]
        EaseInQuint,

        /// <summary>Applies quintic easing at the end of the animation.</summary>
        [EnumMember(Value = "easeOutQuint")]
        EaseOutQuint,

        /// <summary>Applies quintic easing at both ends of the animation.</summary>
        [EnumMember(Value = "easeInOutQuint")]
        EaseInOutQuint,

        /// <summary>Applies sinusoidal easing at the start of the animation.</summary>
        [EnumMember(Value = "easeInSine")]
        EaseInSine,

        /// <summary>Applies sinusoidal easing at the end of the animation.</summary>
        [EnumMember(Value = "easeOutSine")]
        EaseOutSine,

        /// <summary>Applies sinusoidal easing at both ends of the animation.</summary>
        [EnumMember(Value = "easeInOutSine")]
        EaseInOutSine,

        /// <summary>Applies exponential easing at the start of the animation.</summary>
        [EnumMember(Value = "easeInExpo")]
        EaseInExpo,

        /// <summary>Applies exponential easing at the end of the animation.</summary>
        [EnumMember(Value = "easeOutExpo")]
        EaseOutExpo,

        /// <summary>Applies exponential easing at both ends of the animation.</summary>
        [EnumMember(Value = "easeInOutExpo")]
        EaseInOutExpo,

        /// <summary>Applies circular easing at the start of the animation.</summary>
        [EnumMember(Value = "easeInCirc")]
        EaseInCirc,

        /// <summary>Applies circular easing at the end of the animation.</summary>
        [EnumMember(Value = "easeOutCirc")]
        EaseOutCirc,

        /// <summary>Applies circular easing at both ends of the animation.</summary>
        [EnumMember(Value = "easeInOutCirc")]
        EaseInOutCirc,

        /// <summary>Applies elastic easing at the start of the animation.</summary>
        [EnumMember(Value = "easeInElastic")]
        EaseInElastic,

        /// <summary>Applies elastic easing at the end of the animation.</summary>
        [EnumMember(Value = "easeOutElastic")]
        EaseOutElastic,

        /// <summary>Applies elastic easing at both ends of the animation.</summary>
        [EnumMember(Value = "easeInOutElastic")]
        EaseInOutElastic,

        /// <summary>Applies overshoot easing at the start of the animation.</summary>
        [EnumMember(Value = "easeInBack")]
        EaseInBack,

        /// <summary>Applies overshoot easing at the end of the animation.</summary>
        [EnumMember(Value = "easeOutBack")]
        EaseOutBack,

        /// <summary>Applies overshoot easing at both ends of the animation.</summary>
        [EnumMember(Value = "easeInOutBack")]
        EaseInOutBack,

        /// <summary>Applies bounce easing at the start of the animation.</summary>
        [EnumMember(Value = "easeInBounce")]
        EaseInBounce,

        /// <summary>Applies bounce easing at the end of the animation.</summary>
        [EnumMember(Value = "easeOutBounce")]
        EaseOutBounce,

        /// <summary>Applies bounce easing at both ends of the animation.</summary>
        [EnumMember(Value = "easeInOutBounce")]
        EaseInOutBounce,
    }

    /// <summary>
    /// Alignment of Title, Subtitle
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TitleAlign
    {
        /// <summary>Centers the title.</summary>
        [EnumMember(Value = "center")]
        Center,

        /// <summary>Aligns the title to the start.</summary>
        [EnumMember(Value = "start")]
        Start,

        /// <summary>Aligns the title to the end.</summary>
        [EnumMember(Value = "end")]
        End
    }

    /// <summary>
    /// Alignment of Legent
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum LegendAlign
    {
        /// <summary>Centers the legend items.</summary>
        [EnumMember(Value = "center")]
        Center,

        /// <summary>Aligns legend items to the start.</summary>
        [EnumMember(Value = "start")]
        Start,

        /// <summary>Aligns legend items to the end.</summary>
        [EnumMember(Value = "end")]
        End
    }

    /// <summary>
    /// Alignment of the title.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TextAlign
    {
        /// <summary>Centers the text.</summary>
        [EnumMember(Value = "center")]
        Center,

        /// <summary>Aligns text to the left.</summary>
        [EnumMember(Value = "left")]
        Left,

        /// <summary>Aligns text to the right.</summary>
        [EnumMember(Value = "right")]
        Right
    }

    /// <summary>
    /// Position of the title.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TitlePosition
    {
        /// <summary>Places the title above the chart.</summary>
        [EnumMember(Value = "top")]
        Top,

        /// <summary>Places the title to the left of the chart.</summary>
        [EnumMember(Value = "left")]
        Left,

        /// <summary>Places the title below the chart.</summary>
        [EnumMember(Value = "bottom")]
        Bottom
    }

    /// <summary>
    /// Weight
    /// </summary>
    public enum FontWeight
    {
        /// <summary>Uses normal font weight.</summary>
        Normal,

        /// <summary>Uses bold font weight.</summary>
        Bold,

        /// <summary>Uses a lighter weight than the parent font.</summary>
        Lighter,

        /// <summary>Uses a heavier weight than the parent font.</summary>
        Bolder
    }

    /// <summary>
    /// Position of the legend.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum LegendPosition
    {
        /// <summary>Places the legend above the chart.</summary>
        [EnumMember(Value = "top")]
        Top,

        /// <summary>Places the legend to the left.</summary>
        [EnumMember(Value = "left")]
        Left,

        /// <summary>Places the legend below the chart.</summary>
        [EnumMember(Value = "bottom")]
        Bottom,

        /// <summary>Places the legend to the right.</summary>
        [EnumMember(Value = "right")]
        Right,

        /// <summary>Places the legend inside the chart area.</summary>
        [EnumMember(Value = "chartArea")]
        ChartArea
    }

    /// <summary>
    /// Mode
    /// </summary>
    public enum InteractionMode
    {
        /// <summary>Selects elements that intersect the pointer.</summary>
        Point,
        /// <summary>Finds the element nearest the pointer.</summary>
        Nearest,
        /// <summary>Selects elements at the same data index.</summary>
        Index,
        /// <summary>Selects elements from the same dataset.</summary>
        Dataset,
        /// <summary>Selects elements that intersect the pointer along the x-axis.</summary>
        X,
        /// <summary>Selects elements that intersect the pointer along the y-axis.</summary>
        Y
    }

    /// <summary>
    /// Position
    /// </summary>
    public enum TooltipPosition
    {
        /// <summary>Positions the tooltip at the average position of the active elements.</summary>
        Average,
        /// <summary>Positions the tooltip at the active element nearest the pointer.</summary>
        Nearest
    }

    /// <summary>
    /// Axis
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Axis
    {
        /// <summary>Uses the horizontal axis.</summary>
        [EnumMember(Value = "x")]
        X,

        /// <summary>Uses the vertical axis.</summary>
        [EnumMember(Value = "y")]
        Y,

        /// <summary>Uses both Cartesian axes.</summary>
        [EnumMember(Value = "xy")]
        XY,

        /// <summary>Uses the radial axis.</summary>
        [EnumMember(Value = "r")]
        R
    }

    /// <summary>Specifies a browser event the chart listens for.</summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ChartEvent
    {
        /// <summary>Handles mouse movement.</summary>
        [EnumMember(Value = "mousemove")]
        Mousemove,

        /// <summary>Handles the pointer leaving the chart.</summary>
        [EnumMember(Value = "mouseout")]
        Mouseout,

        /// <summary>Handles a click.</summary>
        [EnumMember(Value = "click")]
        Click,

        /// <summary>Handles the start of a touch.</summary>
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

    /// <summary>Specifies where an axis appears in the chart.</summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AxisPosition
    {
        /// <summary>Places the axis at the top.</summary>
        [EnumMember(Value = "top")]
        Top,

        /// <summary>Places the axis on the left.</summary>
        [EnumMember(Value = "left")]
        Left,

        /// <summary>Places the axis at the bottom.</summary>
        [EnumMember(Value = "bottom")]
        Bottom,

        /// <summary>Places the axis on the right.</summary>
        [EnumMember(Value = "right")]
        Right,

        /// <summary>Places the axis in the center.</summary>
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

    /// <summary>Specifies which bar borders to omit.</summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Skipped
    {
        /// <summary>Skips the border at the base of the bar.</summary>
        [EnumMember(Value = "start")]
        Start,

        /// <summary>Skips the border at the end of the bar.</summary>
        [EnumMember(Value = "end")]
        End,

        /// <summary>Skips borders between stacked bars.</summary>
        [EnumMember(Value = "middle")]
        Middle,

        /// <summary>Skips the bottom border.</summary>
        [EnumMember(Value = "bottom")]
        Bottom,

        /// <summary>Skips the left border.</summary>
        [EnumMember(Value = "left")]
        Left,

        /// <summary>Skips the top border.</summary>
        [EnumMember(Value = "top")]
        Top,

        /// <summary>Skips the right border.</summary>
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
        /// <summary>Aligns the label to the start of the tick.</summary>
        [EnumMember(Value = "start")]
        Start,

        /// <summary>Centers the label on the tick.</summary>
        [EnumMember(Value = "center")]
        Center,

        /// <summary>Aligns the label to the end of the tick.</summary>
        [EnumMember(Value = "end")]
        End,

        /// <summary>Aligns the outermost labels inward and centers the others.</summary>
        [EnumMember(Value = "inner")]
        Inner
    }

    /// <summary>
    /// The tick alignment perpendicular to the axis.
    /// </summary>
    public enum TicksCrossAlign
    {
        /// <summary>Places tick labels nearest the axis.</summary>
        [EnumMember(Value = "near")]
        Near,

        /// <summary>Centers tick labels across the available space.</summary>
        [EnumMember(Value = "center")]
        Center,

        /// <summary>Places tick labels farthest from the axis.</summary>
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
