using HelperJS.Chart.Models;

namespace HelperJS.Chart.Builders
{
    /// <summary>
    /// Arc Element Configuration.
    /// </summary>
    public class ArcElementBuilder : BaseElementBuilder<ArcElementBuilder>
    {
        private readonly ArcElement _arcElement;

        internal ArcElementBuilder(ArcElement arcElement)
            : base(arcElement)
        {
            _arcElement = arcElement;
        }

        /// <summary>
        /// Arc angle to cover (for polar only). Default "circumference / (arc count)"
        /// </summary>
        /// <param name="angle"></param>
        /// <returns></returns>
        public ArcElementBuilder Angle(int angle)
        {
            _arcElement.Angle = angle;
            return this;
        }

        /// <summary>
        /// Arc stroke alignment.
        /// </summary>
        /// <param name="align"></param>
        /// <returns></returns>
        public ArcElementBuilder BorderAlign(BorderAlign align)
        {
            _arcElement.BorderAlign = align;
            return this;
        }

        /// <summary>
        /// Arc line dash.
        /// </summary>
        /// <param name="borderDash"></param>
        /// <returns></returns>
        public ArcElementBuilder BorderDash(params int[] borderDash)
        {
            _arcElement.BorderDash = borderDash;
            return this;
        }

        /// <summary>
        /// Arc line dash offset. Default 0.0
        /// </summary>
        /// <param name="offset"></param>
        /// <returns></returns>
        public ArcElementBuilder BorderDashOffset(double offset)
        {
            _arcElement.BorderDashOffset = offset;
            return this;
        }

        /// <summary>
        /// Line join style. The default is 'round' when borderAlign is 'inner'
        /// </summary>
        /// <param name="joinStyle"></param>
        /// <returns></returns>
        public ArcElementBuilder BorderJoinStyle(JoinStyle joinStyle)
        {
            _arcElement.BorderJoinStyle = joinStyle;
            return this;
        }

        /// <summary>
        /// By default the Arc is curved. If circular: false the Arc will be flat. Default true
        /// </summary>
        /// <param name="circular"></param>
        /// <returns></returns>
        public ArcElementBuilder Circular(bool circular)
        {
            _arcElement.Circular = circular;
            return this;
        }
    }
}
