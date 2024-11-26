using RazorKit.ChartJs.Models;
using System;

namespace RazorKit.ChartJs.Builders
{
    /// <summary>
    /// Tooltip Builder
    /// </summary>
    public class TooltipBuilder
    {
        private readonly ToolTip _toolTip;

        internal TooltipBuilder(ToolTip toolTip)
        {
            _toolTip = toolTip;
        }

        /// <summary>
        /// Are on-canvas tooltips enabled? default true
        /// </summary>
        /// <param name="enabled"></param>
        /// <returns></returns>
        public TooltipBuilder Enabled(bool enabled)
        {
            _toolTip.Enabled = enabled;
            return this;
        }

        /// <summary>
        /// External function name.
        /// </summary>
        /// <param name="external"></param>
        /// <returns></returns>
        public TooltipBuilder External(string external)
        {
            _toolTip.External = external;
            return this;
        }

        /// <summary>
        /// Sets which elements appear in the tooltip.
        /// </summary>
        /// <param name="mode"></param>
        /// <returns></returns>
        public TooltipBuilder Mode(Mode mode)
        {
            _toolTip.Mode = mode.ToString().ToLower();
            return this;
        }

        /// <summary>
        /// Sets which elements appear in the tooltip. 'Custom mode'
        /// </summary>
        /// <param name="mode">function name</param>
        /// <returns></returns>
        public TooltipBuilder Mode(string mode)
        {
            _toolTip.Mode = mode;
            return this;
        }

        /// <summary>
        /// If true, the tooltip mode applies only when the mouse position intersects with an element. 
        /// If false, the mode will be applied at all times.
        /// </summary>
        /// <param name="intersect"></param>
        /// <returns></returns>
        public TooltipBuilder Intersect(bool intersect)
        {
            _toolTip.Intersect = intersect;
            return this;
        }

        /// <summary>
        /// The mode for positioning the tooltip. default 'average'
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public TooltipBuilder Position(Position position)
        {
            _toolTip.Position = position.ToString().ToLower();
            return this;
        }

        /// <summary>
        /// The mode for positioning the tooltip. 'Custom position'
        /// </summary>
        /// <param name="position">function name</param>
        /// <returns></returns>
        public TooltipBuilder Position(string position)
        {
            _toolTip.Position = position;
            return this;
        }

        /// <summary>
        /// Configure callbacks.
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        public TooltipBuilder Callbacks(Action<CallbacksBuilder> action)
        {
            _toolTip.Callbacks = new Callbacks();
            var builder = new CallbacksBuilder(_toolTip.Callbacks);
            action(builder);
            return this;
        }

        /// <summary>
        /// Sort tooltip items.
        /// </summary>
        /// <param name="itemSort">function name</param>
        /// <returns></returns>
        public TooltipBuilder ItemSort(string itemSort)
        {
            _toolTip.ItemSort = itemSort;
            return this;
        }

        /// <summary>
        /// Filter tooltip items.
        /// </summary>
        /// <param name="filter">function name</param>
        /// <returns></returns>
        public TooltipBuilder Filter(string filter)
        {
            _toolTip.Filter = filter;
            return this;
        }

        /// <summary>
        /// Background color of the tooltip.
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public TooltipBuilder BackgroundColor(string color)
        {
            _toolTip.BorderColor = color;
            return this;
        }

        /// <summary>
        /// Color of title text. default '#fff'
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public TooltipBuilder TitleColor(string color)
        {
            _toolTip.TitleColor = color;
            return this;
        }

        /// <summary>
        /// Configure title font. default {weight: 'bold'}
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        public TooltipBuilder TitleFont(Action<FontBuilder> action)
        {
            _toolTip.TitleFont = new ChartFont();
            var builder = new FontBuilder(_toolTip.TitleFont);
            action(builder);
            return this;
        }

        /// <summary>
        /// Horizontal alignment of the title text lines. default 'left'
        /// </summary>
        /// <param name="align"></param>
        /// <returns></returns>
        public TooltipBuilder TitleAlign(TextAlign align)
        {
            _toolTip.TitleAlign = align;
            return this;
        }

        /// <summary>
        /// Spacing to add to top and bottom of each title line. default 2
        /// </summary>
        /// <param name="spacing"></param>
        /// <returns></returns>
        public TooltipBuilder TitleSpacing(int spacing)
        {
            _toolTip.TitleSpacing = spacing;
            return this;
        }

        /// <summary>
        /// Margin to add on bottom of title section. default 6
        /// </summary>
        /// <param name="marginBottom"></param>
        /// <returns></returns>
        public TooltipBuilder TitleMarginBottom(int marginBottom)
        {
            _toolTip.TitleMarginBottom = marginBottom;
            return this;
        }

        /// <summary>
        /// Color of body text. defautl '#fff'
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public TooltipBuilder BodyColor(string color)
        {
            _toolTip.BodyColor = color;
            return this;
        }

        /// <summary>
        /// Configure body font. default {weight: 'bold'}
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        public TooltipBuilder BodyFont(Action<FontBuilder> action)
        {
            _toolTip.BodyFont = new ChartFont();
            var builder = new FontBuilder(_toolTip.BodyFont);
            action(builder);
            return this;
        }

        /// <summary>
        /// Horizontal alignment of the body text lines. default 'left'
        /// </summary>
        /// <param name="align"></param>
        /// <returns></returns>
        public TooltipBuilder BodyAlign(TextAlign align)
        {
            _toolTip.BodyAlign = align;
            return this;
        }

        /// <summary>
        /// Spacing to add to top and bottom of each tooltip item. default 2
        /// </summary>
        /// <param name="spacing"></param>
        /// <returns></returns>
        public TooltipBuilder BodySpacing(int spacing)
        {
            _toolTip.BodySpacing = spacing;
            return this;
        }

        /// <summary>
        /// Color of footer text. default '#fff'
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public TooltipBuilder FooterColor(string color)
        {
            _toolTip.FooterColor = color;
            return this;
        }

        /// <summary>
        /// Configure footer font. default {weight: 'bold'}
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        public TooltipBuilder FooterFont(Action<FontBuilder> action)
        {
            _toolTip.FooterFont = new ChartFont();
            var builder = new FontBuilder(_toolTip.FooterFont);
            action(builder);
            return this;
        }

        /// <summary>
        /// Horizontal alignment of the footer text lines. defautl 'left'
        /// </summary>
        /// <param name="align"></param>
        /// <returns></returns>
        public TooltipBuilder FooterAlign(TextAlign align)
        {
            _toolTip.FooterAlign = align;
            return this;
        }

        /// <summary>
        /// Spacing to add to top and bottom of each footer line. default 2
        /// </summary>
        /// <param name="spacing"></param>
        /// <returns></returns>
        public TooltipBuilder FooterSpacing(int spacing)
        {
            _toolTip.FooterSpacing = spacing;
            return this;
        }

        /// <summary>
        /// Margin to add before drawing the footer. default 6
        /// </summary>
        /// <param name="margin"></param>
        /// <returns></returns>
        public TooltipBuilder FooterMarginTop(int margin)
        {
            _toolTip.FooterMarginTop = margin;
            return this;
        }

        /// <summary>
        /// Padding inside the tooltip. default 6
        /// </summary>
        /// <param name="padding"></param>
        /// <returns></returns>
        public TooltipBuilder Padding(int padding)
        {
            _toolTip.Padding = new Padding(padding);
            return this;
        }

        /// <summary>
        /// Padding Configuration.
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        public TooltipBuilder Padding(Action<PaddingBuilder> action)
        {
            _toolTip.Padding = new Padding();
            var builder = new PaddingBuilder(_toolTip.Padding);
            action(builder);
            return this;
        }

        /// <summary>
        /// Extra distance to move the end of the tooltip arrow away from the tooltip point. default 2
        /// </summary>
        /// <param name="padding"></param>
        /// <returns></returns>
        public TooltipBuilder CaretPadding(int padding)
        {
            _toolTip.CaretPadding = padding;
            return this;
        }

        /// <summary>
        /// Size, in px, of the tooltip arrow. default 5
        /// </summary>
        /// <param name="size"></param>
        /// <returns></returns>
        public TooltipBuilder CaretSize(int size)
        {
            _toolTip.CaretSize = size;
            return this;
        }

        /// <summary>
        /// Radius of tooltip corner curves. default 6
        /// </summary>
        /// <param name="radius"></param>
        /// <returns></returns>
        public TooltipBuilder CornerRadius(int radius)
        {
            _toolTip.CornerRadius = radius;
            return this;
        }

        /// <summary>
        /// Color to draw behind the colored boxes when multiple items are in the tooltip. default '#fff'
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public TooltipBuilder MultiKeyBackground(string color)
        {
            _toolTip.MultiKeyBackground = color;
            return this;
        }

        /// <summary>
        /// If true, color boxes are shown in the tooltip. default true
        /// </summary>
        /// <param name="displayColors"></param>
        /// <returns></returns>
        public TooltipBuilder DisplayColors(bool displayColors)
        {
            _toolTip.DisplayColors = displayColors;
            return this;
        }

        /// <summary>
        /// Width of the color box if displayColors is true.
        /// </summary>
        /// <param name="width"></param>
        /// <returns></returns>
        public TooltipBuilder BoxWidth(int width)
        {
            _toolTip.BoxWidth = width;
            return this;
        }

        /// <summary>
        /// Height of the color box if displayColors is true.
        /// </summary>
        /// <param name="height"></param>
        /// <returns></returns>
        public TooltipBuilder BoxHeight(int height)
        {
            _toolTip.BoxHeight = height;
            return this;
        }

        /// <summary>
        /// Padding between the color box and the text. default 1
        /// </summary>
        /// <param name="padding"></param>
        /// <returns></returns>
        public TooltipBuilder BoxPadding(int padding)
        {
            _toolTip.BoxPadding = padding;
            return this;
        }

        /// <summary>
        /// Use the corresponding point style (from dataset options) instead of color boxes, ex: star, triangle etc.
        /// (size is based on the minimum value between boxWidth and boxHeight). default false
        /// </summary>
        /// <param name="usePointStyle"></param>
        /// <returns></returns>
        public TooltipBuilder UsePointStyle(bool usePointStyle)
        {
            _toolTip.UsePointStyle = usePointStyle;
            return this;
        }

        /// <summary>
        /// Color of the border.
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public TooltipBuilder BorderColor(string color)
        {
            _toolTip.BorderColor = color;
            return this;
        }

        /// <summary>
        /// Size of the border. default 0
        /// </summary>
        /// <param name="width"></param>
        /// <returns></returns>
        public TooltipBuilder BorderWidth(int width)
        {
            _toolTip.BorderWidth = width;
            return this;
        }

        /// <summary>
        /// true for rendering the tooltip from right to left.
        /// </summary>
        /// <param name="rtl"></param>
        /// <returns></returns>
        public TooltipBuilder Rtl(bool rtl)
        {
            _toolTip.Rtl = rtl;
            return this;
        }

        /// <summary>
        /// This will force the text direction 'rtl' or 'ltr' on the canvas for rendering the tooltips, 
        /// regardless of the css specified on the canvas.
        /// </summary>
        /// <param name="direction"></param>
        /// <returns></returns>
        public TooltipBuilder TextDirection(string direction)
        {
            _toolTip.TextDirection = direction;
            return this;
        }

        /// <summary>
        /// Position of the tooltip caret in the X direction.
        /// </summary>
        /// <param name="align"></param>
        /// <returns></returns>
        public TooltipBuilder XAlign(string align)
        {
            _toolTip.XAlign = align;
            return this;
        }

        /// <summary>
        /// Position of the tooltip caret in the Y direction.
        /// </summary>
        /// <param name="align"></param>
        /// <returns></returns>
        public TooltipBuilder YAlign(string align)
        {
            _toolTip.YAlign = align;
            return this;
        }
    }
}
