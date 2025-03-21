﻿using RazorKit.ChartJs.Models;
using System;
using System.Collections.Generic;

namespace RazorKit.ChartJs.Builders
{
    /// <summary>
    /// Options Builder
    /// </summary>
    public class OptionsBuilder
    {
        private readonly Options _options;

        internal OptionsBuilder(Options options)
        {
            _options = options;
        }

        /// <summary>
        /// Resizes the chart canvas when its container does. Default true
        /// </summary>
        /// <param name="responsive"></param>
        /// <returns></returns>
        public OptionsBuilder Responsive(bool responsive)
        {
            _options.Responsive = responsive;
            return this;
        }

        /// <summary>
        /// Maintain the original canvas aspect ratio (width / height) when resizing. Default true
        /// </summary>
        /// <param name="maintainAspectRatio"></param>
        /// <returns></returns>
        public OptionsBuilder MaintainAspectRatio(bool maintainAspectRatio)
        {
            _options.MaintainAspectRatio = maintainAspectRatio;
            return this;
        }

        /// <summary>
        /// Canvas aspect ratio (i.e. width / height, a value of 1 representing a square canvas).
        /// Note that this option is ignored if the height is explicitly defined either as attribute or via the style.
        /// The default value varies by chart type; Radial charts (doughnut, pie, polarArea, radar) default to 1 and others default to 2.
        /// </summary>
        /// <param name="aspectRatio"></param>
        /// <returns></returns>
        public OptionsBuilder AspectRatio(int aspectRatio)
        {
            _options.AspectRatio = aspectRatio;
            return this;
        }

        /// <summary>
        /// Called when a resize occurs. Gets passed two arguments: the chart instance and the new size.
        /// </summary>
        /// <param name="onResize"></param>
        /// <returns></returns>
        public OptionsBuilder OnResize(string onResize)
        {
            _options.OnResize = onResize;
            return this;
        }

        /// <summary>
        /// Called when any of the events fire over chartArea. 
        /// Passed the event, an array of active elements (bars, points, etc), and the chart.
        /// </summary>
        /// <param name="onHover"></param>
        /// <returns></returns>
        public OptionsBuilder OnHover(string onHover)
        {
            _options.OnHover = onHover;
            return this;
        }

        /// <summary>
        /// The events option defines the browser events that the chart should listen to for. 
        /// Each of these events trigger hover and are passed to plugins. 
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public OptionsBuilder Events(params ChartEvent[] events)
        {
            _options.Events = events;
            return this;
        }

        /// <summary>
        /// Called if the event is of type 'mouseup', 'click' or 'contextmenu' over chartArea. 
        /// Passed the event, an array of active elements, and the chart.
        /// </summary>
        /// <param name="onClick"></param>
        /// <returns></returns>
        public OptionsBuilder OnClick(string onClick)
        {
            _options.OnClick = onClick;
            return this;
        }

        /// <summary>
        /// Delay the resize update by the given amount of milliseconds.
        /// This can ease the resize process by debouncing the update of the elements.
        /// Default 0
        /// </summary>
        /// <param name="delay"></param>
        /// <returns></returns>
        public OptionsBuilder ResizeDelay(int delay)
        {
            _options.ResizeDelay = delay;
            return this;
        }

        /// <summary>
        /// Set a language code.
        /// </summary>
        /// <param name="locale"></param>
        /// <returns></returns>
        public OptionsBuilder Locale(string locale)
        {
            _options.Locale = locale;
            return this;
        }

        /// <summary>
        /// Configure plugins.
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        public OptionsBuilder Plugins(Action<PluginsBuilder> action)
        {
            _options.Plugins = new Plugins();
            var builder = new PluginsBuilder(_options.Plugins);
            action(builder);
            return this;
        }

        /// <summary>
        /// Configure layout.
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        public OptionsBuilder Layout(Action<LayoutBuilder> action)
        {
            _options.Layout = new Layout();
            var builder = new LayoutBuilder(_options.Layout);
            action(builder);
            return this;
        }

        /// <summary>
        /// Configure animation.
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        public OptionsBuilder Animation(Action<AnimationBuilder> action)
        {
            _options.Animation = new Animation();
            var builder = new AnimationBuilder(_options.Animation);
            action(builder);
            return this;
        }

        /// <summary>
        /// Configure Interaction.
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        public OptionsBuilder Interaction(Action<InteractionBuilder> action)
        {
            _options.Interaction = new Interaction();
            var builder = new InteractionBuilder(_options.Interaction);
            action(builder);
            return this;
        }

        /// <summary>
        /// Configure Scales.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="action"></param>
        /// <returns></returns>
        public OptionsBuilder Scales(Action<ScaleBuilder> action)
        {
            _options.Scales = new Dictionary<string, Scale>();
            var builder = new ScaleBuilder(_options.Scales);
            action(builder);
            return this;
        }

        /// <summary>
        /// Animations options configures which element properties are animated and how.
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        public OptionsBuilder Animations(Action<AnimationBuilder> action)
        {
            _options.Animations = new Dictionary<string, Animation>();
            var builder = new AnimationBuilder(_options.Animations);
            action(builder);
            return this;
        }

        /// <summary>
        /// Elements Configuration.
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        public OptionsBuilder Elements(Action<ElementsBuilder> action)
        {
            _options.Elements = new Elements();
            var builder = new ElementsBuilder(_options.Elements);
            action(builder);
            return this;
        }

        /// <summary>
        /// How to parse the dataset. The parsing can be disabled by specifying parsing: false at chart options or dataset. 
        /// If parsing is disabled, data must be sorted and in the formats the associated chart type and scales use internally.
        /// </summary>
        /// <param name="enabled"></param>
        /// <returns></returns>
        public OptionsBuilder Parsing(bool enabled)
        {
            _options.Parsing = enabled;
            return this;
        }

        /// <summary>
        /// Parsing with key.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public OptionsBuilder Parsing(string key)
        {
            _options.Parsing = new Parsing { Key = key };
            return this;
        }

        /// <summary>
        /// Parsing with x and y axis keys.
        /// </summary>
        /// <param name="xAxisKey"></param>
        /// <param name="yAxisKey"></param>
        /// <returns></returns>
        public OptionsBuilder Parsing(string xAxisKey, string yAxisKey)
        {
            _options.Parsing = new Parsing { XAxisKey = xAxisKey, YAxisKey = yAxisKey };
            return this;
        }
    }
}
