﻿using RazorKit.ChartJs.Models;
using System;

namespace RazorKit.ChartJs.Builders
{
    /// <summary>
    /// Base Dateset configurations
    /// </summary>
    public abstract class BaseDatasetBuilder<T> where T : BaseDatasetBuilder<T>
    {
        private readonly BaseDataset _dataset;

        internal BaseDatasetBuilder(BaseDataset baseDataset)
        {
            _dataset = baseDataset;
        }

        /// <summary>
        /// The label for the dataset which appears in the legend and tooltips.
        /// </summary>
        /// <param name="label"></param>
        /// <returns></returns>
        public T Label(string label)
        {
            _dataset.Label = label;
            return (T)this;
        }

        /// <summary>
        /// The line fill color.
        /// </summary>
        /// <param name="color"></param>
        /// <returns>The T instance.</returns>
        public T BackgroundColor(string color)
        {
            _dataset.BackgroundColor = color;
            return (T)this;
        }

        /// <summary>
        /// The line fill colors.
        /// </summary>
        /// <param name="colors"></param>
        /// <returns>The T instance.</returns>
        public T BackgroundColors(params string[] colors)
        {
            _dataset.BackgroundColor = colors;
            return (T)this;
        }

        /// <summary>
        /// The line color.
        /// </summary>
        /// <param name="color"></param>
        /// <returns>The T instance.</returns>
        public T BorderColor(string color)
        {
            _dataset.BorderColor = color;
            return (T)this;
        }

        /// <summary>
        /// The line colors.
        /// </summary>
        /// <param name="colors"></param>
        /// <returns>The T instance.</returns>
        public T BorderColors(params string[] colors)
        {
            _dataset.BorderColor = colors;
            return (T)this;
        }

        /// <summary>
        /// The line width (in pixels). Default 3
        /// </summary>
        /// <param name="width"></param>
        /// <returns>The T instance.</returns>
        public T BorderWidth(int width)
        {
            _dataset.BorderWidth = width;
            return (T)this;
        }

        /// <summary>
        /// How to clip relative to chartArea. Positive value allows overflow, negative value clips that many pixels inside chartArea.
        /// 0 = clip at chartArea.
        /// </summary>
        /// <param name="clip"></param>
        /// <returns>The T instance.</returns>
        public T Clip(int clip)
        {
            _dataset.Clip = clip;
            return (T)this;
        }

        /// <summary>
        /// How to clip relative to chartArea. Positive value allows overflow, negative value clips that many pixels inside chartArea.
        /// Clipping can also be configured per side: clip: {left: 5, top: false, right: -2, bottom: 0}
        /// </summary>
        public T Clip(Action<ClipBuilder> action)
        {
            _dataset.Clip = new Clip();
            var builder = new ClipBuilder((Clip)_dataset.Clip);
            action(builder);
            return (T)this;
        }

        /// <summary>
        /// Is clip enabled?
        /// </summary>
        /// <param name="enabled"></param>
        /// <returns></returns>
        public T Clip(bool enabled)
        {
            _dataset.Clip = enabled;
            return (T)this;
        }

        /// <summary>
        /// Background color when hovered.
        /// </summary>
        /// <param name="color"></param>
        /// <returns>The T instance with the set data.</returns>
        public T HoverBackgroundColor(string color)
        {
            _dataset.HoverBackgroundColor = color;
            return (T)this;
        }

        /// <summary>
        /// Background colors when hovered.
        /// </summary>
        /// <param name="colors"></param>
        /// <returns>The T instance with the set data.</returns>
        public T HoverBackgroundColors(params string[] colors)
        {
            _dataset.HoverBackgroundColor = colors;
            return (T)this;
        }

        /// <summary>
        /// Border color when hovered.
        /// </summary>
        /// <param name="color"></param>
        /// <returns>The T instance with the set data.</returns>
        public T HoverBorderColor(string color)
        {
            _dataset.HoverBorderColor = color;
            return (T)this;
        }

        /// <summary>
        /// Border colors when hovered.
        /// </summary>
        /// <param name="colors"></param>
        /// <returns>The T instance with the set data.</returns>
        public T HoverBorderColors(params string[] colors)
        {
            _dataset.HoverBorderColor = colors;
            return (T)this;
        }

        /// <summary>
        /// The line width (in pixels) when hovered.
        /// </summary>
        /// <param name="width"></param>
        /// <returns>The T instance with the set data.</returns>
        public T HoverBorderWidth(int width)
        {
            _dataset.HoverBorderWidth = width;
            return (T)this;
        }

        /// <summary>
        /// How to parse the dataset. The parsing can be disabled by specifying parsing: false at chart options or dataset. 
        /// If parsing is disabled, data must be sorted and in the formats the associated chart type and scales use internally.
        /// </summary>
        /// <param name="enabled"></param>
        /// <returns></returns>
        public T Parsing(bool enabled)
        {
            _dataset.Parsing = enabled;
            return (T)this;
        }

        /// <summary>
        /// Parsing with key.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public T Parsing(string key)
        {
            _dataset.Parsing = new Parsing { Key = key };
            return (T)this;
        }

        /// <summary>
        /// Parsing with x and y axis keys.
        /// </summary>
        /// <param name="xAxisKey"></param>
        /// <param name="yAxisKey"></param>
        /// <returns></returns>
        public T Parsing(string xAxisKey, string yAxisKey)
        {
            _dataset.Parsing = new Parsing { XAxisKey = xAxisKey, YAxisKey = yAxisKey };
            return (T)this;
        }

        /// <summary>
        /// Configure the visibility of the dataset. Using hidden: true will hide the dataset from being rendered in the Chart.
        /// </summary>
        /// <param name="hidden"></param>
        /// <returns></returns>
        public T Hidden(bool hidden)
        {
            _dataset.Hidden = hidden;
            return (T)this;
        }
    }
}
