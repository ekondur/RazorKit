using HelperJS.Chart.Models;
using System;

namespace HelperJS.Chart.Builders
{
    /// <summary>
    /// LegendLabels Builder
    /// </summary>
    public class LegendLabelsBuilder
    {
        private readonly ChartJs _chart;
        private readonly LegendLabels _legendLabel;

        internal LegendLabelsBuilder(ChartJs chart)
        {
            _chart = chart;
            _chart.Options.Plugins.Legend.Labels = _legendLabel = new LegendLabels();
        }

        /// <summary>
        /// Width of coloured box. default 40
        /// </summary>
        /// <param name="width"></param>
        /// <returns></returns>
        public LegendLabelsBuilder BoxWidth(int width)
        {
            _legendLabel.BoxWidth = width;
            return this;
        }

        /// <summary>
        /// Height of the coloured box.
        /// </summary>
        /// <param name="height"></param>
        /// <returns></returns>
        public LegendLabelsBuilder BoxHeight(int height)
        {
            _legendLabel.BoxHeight = height;
            return this;
        }

        /// <summary>
        /// Color of label and the strikethrough.
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public LegendLabelsBuilder Color(string color)
        {
            _legendLabel.Color = color;
            return this;
        }

        /// <summary>
        /// Configure font.
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        public LegendLabelsBuilder Font(Action<FontBuilder> action)
        {
            var builder = new FontBuilder(_chart, FontSource.LegendLabels);
            action(builder);
            return this;
        }

        /// <summary>
        /// Padding between rows of colored boxes. Default 10
        /// </summary>
        /// <param name="padding"></param>
        /// <returns></returns>
        public LegendLabelsBuilder Padding(int padding)
        {
            _legendLabel.Padding = padding;
            return this;
        }

        /// <summary>
        /// Generates legend items for each thing in the legend.
        /// Default implementation returns the text + styling for the color box. 
        /// </summary>
        /// <param name="function"></param>
        /// <returns></returns>
        public LegendLabelsBuilder GenerateLabels(string function)
        {
            _legendLabel.GenerateLabels = function;
            return this;
        }

        /// <summary>
        /// Filters legend items out of the legend. Receives 2 parameters, a Legend Item and the chart data.
        /// </summary>
        /// <param name="function"></param>
        /// <returns></returns>
        public LegendLabelsBuilder Filter(string function)
        {
            _legendLabel.Filter = function;
            return this;
        }

        /// <summary>
        /// Sorts legend items. Type is : sort(a: LegendItem, b: LegendItem, data: ChartData): number;.
        /// Receives 3 parameters, two Legend Items and the chart data. 
        /// The return value of the function is a number that indicates the order of the two legend item parameters. 
        /// The ordering matches the return value of Array.prototype.sort()
        /// </summary>
        /// <param name="function"></param>
        /// <returns></returns>
        public LegendLabelsBuilder Sort(string function)
        {
            _legendLabel.Sort = function;
            return this;
        }

        /// <summary>
        /// If specified, this style of point is used for the legend. Only used if usePointStyle is true. default 'circle'
        /// </summary>
        /// <param name="pointStyle"></param>
        /// <returns></returns>
        public LegendLabelsBuilder PointStyle(PointStyle pointStyle)
        {
            _legendLabel.PointStyle = pointStyle;
            return this;
        }

        /// <summary>
        /// Horizontal alignment of the label text. Options are: 'left', 'right' or 'center'. default 'center'
        /// </summary>
        /// <param name="textAlign"></param>
        /// <returns></returns>
        public LegendLabelsBuilder TextAlign(TextAlign textAlign)
        {
            _legendLabel.TextAlign = textAlign;
            return this;
        }

        /// <summary>
        /// Label style will match corresponding point style (size is based on pointStyleWidth or the minimum value between boxWidth and font.size).
        /// default false
        /// </summary>
        /// <param name="usePointStyle"></param>
        /// <returns></returns>
        public LegendLabelsBuilder UsePointStyle(bool usePointStyle)
        {
            _legendLabel.UsePointStyle = usePointStyle;
            return this;
        }

        /// <summary>
        /// If UsePointStyle is true, the width of the point style used for the legend.
        /// </summary>
        /// <param name="width"></param>
        /// <returns></returns>
        public LegendLabelsBuilder PointStyleWidth(int width)
        {
            _legendLabel.PointStyleWidth = width;
            return this;
        }

        /// <summary>
        /// Label borderRadius will match corresponding borderRadius. default false
        /// </summary>
        /// <param name="useBorderRadius"></param>
        /// <returns></returns>
        public LegendLabelsBuilder UseBorderRadius(bool useBorderRadius)
        {
            _legendLabel.UseBorderRadius = useBorderRadius;
            return this;
        }

        /// <summary>
        /// Override the borderRadius to use.
        /// </summary>
        /// <param name="borderRadius"></param>
        /// <returns></returns>
        public LegendLabelsBuilder BorderRadius(double borderRadius)
        {
            _legendLabel.BorderRadius = borderRadius;
            return this;
        }
    }
}
