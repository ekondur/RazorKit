﻿using RazorKit.Chart.Models;

namespace RazorKit.Chart.Builders
{
    /// <summary>
    /// Arc Dataset Configuration.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class ArcDatasetBuilder<T> : BaseDatasetBuilder<T> where T : ArcDatasetBuilder<T>
    {
        private readonly ArcDataset _dataset;

        internal ArcDatasetBuilder(ArcDataset dataset) : base(dataset)
        {
            _dataset = dataset;
        }

        /// <summary>
        /// Set Backgrounds colors
        /// </summary>
        /// <param name="colors"></param>
        /// <returns></returns>
        public T BackgroundColors(params string[] colors)
        {
            _dataset.BackgroundColor = colors;
            return (T)this;
        }

        /// <summary>
        /// Default 'center'
        /// </summary>
        /// <param name="borderAlign"></param>
        /// <returns></returns>
        public T BorderAlign(BorderAlign borderAlign)
        {
            _dataset.BorderAlign = borderAlign;
            return (T)this;
        }

        /// <summary>
        /// arc border length and spacing of dashes.
        /// </summary>
        /// <param name="dashes"></param>
        /// <returns></returns>
        public T BorderDash(params int[] dashes)
        {
            _dataset.BorderDash = dashes;
            return (T)this;
        }

        /// <summary>
        /// arc border offset for line dashes.
        /// </summary>
        /// <param name="dashOffset"></param>
        /// <returns></returns>
        public T BorderDashOffset(double dashOffset)
        {
            _dataset.BorderDashOffset = dashOffset;
            return (T)this;
        }

        /// <summary>
        /// arc border join style.
        /// </summary>
        /// <param name="joinStyle"></param>
        /// <returns></returns>
        public T BorderJoinStyle(JoinStyle joinStyle)
        {
            _dataset.BorderJoinStyle = joinStyle;
            return (T)this;
        }

        /// <summary>
        /// Set Data for arc chart.
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public T Data(params int[] data)
        {
            _dataset.Data = data;
            return (T)this;
        }

        /// <summary>
        /// arc border length and spacing of dashes when hovered.
        /// </summary>
        /// <param name="dashes"></param>
        /// <returns></returns>
        public T HoverBorderDash(params int[] dashes)
        {
            _dataset.HoverBorderDash = dashes;
            return (T)this;
        }

        /// <summary>
        /// arc border offset for line dashes when hovered.
        /// </summary>
        /// <param name="dashOffset"></param>
        /// <returns></returns>
        public T HoverBorderDashOffset(double dashOffset)
        {
            _dataset.HoverBorderDashOffset = dashOffset;
            return (T)this;
        }

        /// <summary>
        /// arc border join style when hovered.
        /// </summary>
        /// <param name="joinStyle"></param>
        /// <returns></returns>
        public T HoverBorderJoinStyle(JoinStyle joinStyle)
        {
            _dataset.HoverBorderJoinStyle = joinStyle;
            return (T)this;
        }
    }
}