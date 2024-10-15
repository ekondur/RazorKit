using HelperJS.Chart.Models;
using System;

namespace HelperJS.Chart.Builders
{
    /// <summary>
    /// Labels Builder
    /// </summary>
    public class LabelsBuilder
    {
        private readonly Labels _labels;

        internal LabelsBuilder(Labels labels)
        {
            _labels = labels;
        }

        /// <summary>
        /// Width of coloured box. default 40
        /// </summary>
        /// <param name="width"></param>
        /// <returns></returns>
        public LabelsBuilder BoxWidth(int width)
        {
            _labels.BoxWidth = width;
            return this;
        }

        /// <summary>
        /// Height of the coloured box.
        /// </summary>
        /// <param name="height"></param>
        /// <returns></returns>
        public LabelsBuilder BoxHeight(int height)
        {
            _labels.BoxHeight = height;
            return this;
        }

        /// <summary>
        /// Color of label and the strikethrough.
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public LabelsBuilder Color(string color)
        {
            _labels.Color = color;
            return this;
        }

        /// <summary>
        /// Font Configuration.
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        public LabelsBuilder Font(Action<FontBuilder> action)
        {
            _labels.Font = new ChartFont();
            var builder = new FontBuilder(_labels.Font);
            action(builder);
            return this;
        }

        /// <summary>
        /// Padding between rows of colored boxes. Default 10
        /// </summary>
        /// <param name="padding"></param>
        /// <returns></returns>
        public LabelsBuilder Padding(int padding)
        {
            _labels.Padding = padding;
            return this;
        }

        /// <summary>
        /// Generates legend items for each thing in the legend.
        /// Default implementation returns the text + styling for the color box. 
        /// </summary>
        /// <param name="function"></param>
        /// <returns></returns>
        public LabelsBuilder GenerateLabels(string function)
        {
            _labels.GenerateLabels = function;
            return this;
        }

        /// <summary>
        /// Filters legend items out of the legend. Receives 2 parameters, a Legend Item and the chart data.
        /// </summary>
        /// <param name="function"></param>
        /// <returns></returns>
        public LabelsBuilder Filter(string function)
        {
            _labels.Filter = function;
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
        public LabelsBuilder Sort(string function)
        {
            _labels.Sort = function;
            return this;
        }

        /// <summary>
        /// If specified, this style of point is used for the legend. Only used if usePointStyle is true. default 'circle'
        /// </summary>
        /// <param name="pointStyle"></param>
        /// <returns></returns>
        public LabelsBuilder PointStyle(PointStyle pointStyle)
        {
            _labels.PointStyle = pointStyle;
            return this;
        }

        /// <summary>
        /// Horizontal alignment of the label text. Options are: 'left', 'right' or 'center'. default 'center'
        /// </summary>
        /// <param name="textAlign"></param>
        /// <returns></returns>
        public LabelsBuilder TextAlign(TextAlign textAlign)
        {
            _labels.TextAlign = textAlign;
            return this;
        }

        /// <summary>
        /// Label style will match corresponding point style (size is based on pointStyleWidth or the minimum value between boxWidth and font.size).
        /// default false
        /// </summary>
        /// <param name="usePointStyle"></param>
        /// <returns></returns>
        public LabelsBuilder UsePointStyle(bool usePointStyle)
        {
            _labels.UsePointStyle = usePointStyle;
            return this;
        }

        /// <summary>
        /// If UsePointStyle is true, the width of the point style used for the legend.
        /// </summary>
        /// <param name="width"></param>
        /// <returns></returns>
        public LabelsBuilder PointStyleWidth(int width)
        {
            _labels.PointStyleWidth = width;
            return this;
        }

        /// <summary>
        /// Label borderRadius will match corresponding borderRadius. default false
        /// </summary>
        /// <param name="useBorderRadius"></param>
        /// <returns></returns>
        public LabelsBuilder UseBorderRadius(bool useBorderRadius)
        {
            _labels.UseBorderRadius = useBorderRadius;
            return this;
        }

        /// <summary>
        /// Override the borderRadius to use.
        /// </summary>
        /// <param name="borderRadius"></param>
        /// <returns></returns>
        public LabelsBuilder BorderRadius(double borderRadius)
        {
            _labels.BorderRadius = borderRadius;
            return this;
        }
    }
}
