using RazorKit.Chart.Models;

namespace RazorKit.Chart.Builders
{
    /// <summary>
    /// Line Element Configuration
    /// </summary>
    public class LineElementBuilder : BaseElementBuilder<LineElementBuilder>
    {
        private readonly LineElement _lineElement;

        internal LineElementBuilder(LineElement lineElement)
            : base(lineElement)
        {
            _lineElement = lineElement;
        }

        /// <summary>
        /// Bézier curve tension (0 for no Bézier curves).
        /// </summary>
        /// <param name="tension"></param>
        /// <returns></returns>
        public LineElementBuilder Tension(double tension)
        {
            _lineElement.Tension = tension;
            return this;
        }

        /// <summary>
        /// Line cap style. Default 'butt'
        /// </summary>
        /// <param name="capStyle"></param>
        /// <returns></returns>
        public LineElementBuilder BorderCapStyle(CapStyle capStyle)
        {
            _lineElement.BorderCapStyle = capStyle;
            return this;
        }

        /// <summary>
        /// Line dash.
        /// </summary>
        /// <param name="dash"></param>
        /// <returns></returns>
        public LineElementBuilder BorderDash(params int[] dash)
        {
            _lineElement.BorderDash = dash;
            return this;
        }

        /// <summary>
        /// Line dash offset. Default 0.0
        /// </summary>
        /// <param name="offset"></param>
        /// <returns></returns>
        public LineElementBuilder BorderDashOffset(double offset)
        {
            _lineElement.BorderDashOffset = offset;
            return this;
        }

        /// <summary>
        /// Line join style. Default 'miter'
        /// </summary>
        /// <param name="joinStyle"></param>
        /// <returns></returns>
        public LineElementBuilder BorderJoinStyle(JoinStyle joinStyle)
        {
            _lineElement.BorderJoinStyle = joinStyle;
            return this;
        }

        /// <summary>
        /// true to keep Bézier control inside the chart, false for no restriction. Default true
        /// </summary>
        /// <param name="capBezierPoints"></param>
        /// <returns></returns>
        public LineElementBuilder CapBezierPoints(bool capBezierPoints)
        {
            _lineElement.CapBezierPoints = capBezierPoints;
            return this;
        }

        /// <summary>
        /// Interpolation mode to apply. Default 'default'
        /// </summary>
        /// <param name="mode"></param>
        /// <returns></returns>
        public LineElementBuilder CubicInterpolationMode(string mode)
        {
            _lineElement.CubicInterpolationMode = mode;
            return this;
        }

        /// <summary>
        /// How to fill the area under the line. Default false
        /// </summary>
        /// <param name="fill"></param>
        /// <returns></returns>
        public LineElementBuilder Fill(bool fill)
        {
            _lineElement.Fill = fill;
            return this;
        }

        /// <summary>
        /// How to fill the area under the line.
        /// </summary>
        /// <param name="fill"></param>
        /// <returns></returns>
        public LineElementBuilder Fill(string fill)
        {
            _lineElement.Fill = fill;
            return this;
        }

        /// <summary>
        /// true to show the line as a stepped line (tension will be ignored). Default false
        /// </summary>
        /// <param name="stepped"></param>
        /// <returns></returns>
        public LineElementBuilder Stepped(bool stepped)
        {
            _lineElement.Stepped = stepped;
            return this;
        }
    }
}
