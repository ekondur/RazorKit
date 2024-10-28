using HelperJS.Chart.Models;

namespace HelperJS.Chart.Builders.Datasets
{
    /// <summary>
    /// Arc Dataset Configuration.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class ArcDatasetBuilder<T> : BaseDatasetBuilder<T> where T : ArcDatasetBuilder<T>
    {
        private readonly ArcDataset _arcDataset;

        internal ArcDatasetBuilder(ArcDataset arcDataset) : base(arcDataset)
        {
            _arcDataset = arcDataset;
        }

        /// <summary>
        /// Default 'center'
        /// </summary>
        /// <param name="borderAlign"></param>
        /// <returns></returns>
        public T BorderAlign(BorderAlign borderAlign)
        {
            _arcDataset.BorderAlign = borderAlign;
            return (T)this;
        }

        /// <summary>
        /// arc border length and spacing of dashes.
        /// </summary>
        /// <param name="dashes"></param>
        /// <returns></returns>
        public T BorderDash(params int[] dashes)
        {
            _arcDataset.BorderDash = dashes;
            return (T)this;
        }

        /// <summary>
        /// arc border offset for line dashes.
        /// </summary>
        /// <param name="dashOffset"></param>
        /// <returns></returns>
        public T BorderDashOffset(double dashOffset)
        {
            _arcDataset.BorderDashOffset = dashOffset;
            return (T)this;
        }

        /// <summary>
        /// arc border join style.
        /// </summary>
        /// <param name="joinStyle"></param>
        /// <returns></returns>
        public T BorderJoinStyle(JoinStyle joinStyle)
        {
            _arcDataset.BorderJoinStyle = joinStyle;
            return (T)this;
        }

        /// <summary>
        /// Set Data for arc chart.
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public T Data(params int[] data)
        {
            _arcDataset.Data = data;
            return (T)this;
        }

        /// <summary>
        /// arc border length and spacing of dashes when hovered.
        /// </summary>
        /// <param name="dashes"></param>
        /// <returns></returns>
        public T HoverBorderDash(params int[] dashes)
        {
            _arcDataset.HoverBorderDash = dashes;
            return (T)this;
        }

        /// <summary>
        /// arc border offset for line dashes when hovered.
        /// </summary>
        /// <param name="dashOffset"></param>
        /// <returns></returns>
        public T HoverBorderDashOffset(double dashOffset)
        {
            _arcDataset.HoverBorderDashOffset = dashOffset;
            return (T)this;
        }

        /// <summary>
        /// arc border join style when hovered.
        /// </summary>
        /// <param name="joinStyle"></param>
        /// <returns></returns>
        public T HoverBorderJoinStyle(JoinStyle joinStyle)
        {
            _arcDataset.HoverBorderJoinStyle = joinStyle;
            return (T)this;
        }
    }
}
