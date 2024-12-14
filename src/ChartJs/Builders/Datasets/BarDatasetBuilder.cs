using RazorKit.ChartJs.Models;
using System.Collections.Generic;

namespace RazorKit.ChartJs.Builders
{
    /// <summary>
    /// Bar Dataset Configuration
    /// </summary>
    public class BarDatasetBuilder : BaseDatasetBuilder<BarDatasetBuilder>
    {
        private readonly BarDataset _dataset;

        internal BarDatasetBuilder(BarDataset baseDataset) : base(baseDataset)
        {
            _dataset = baseDataset;
        }

        /// <summary>
        /// Sets the data for the Dataset.
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public BarDatasetBuilder Data(object data)
        {
            _dataset.Data = data;
            return this;
        }

        /// <summary>
        /// Sets the data for the Dataset.
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public BarDatasetBuilder Data(IList<object> data)
        {
            _dataset.Data = data;
            return this;
        }

        /// <summary>
        /// Sets the data for the Dataset.
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public BarDatasetBuilder Data(params double[] data)
        {
            _dataset.Data = data;
            return this;
        }

        /// <summary>
        /// Sets the data for the Dataset.
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public BarDatasetBuilder Data(params string[] data)
        {
            _dataset.Data = data;
            return this;
        }

        /// <summary>
        /// Set backgrounds colors.
        /// </summary>
        /// <param name="colors"></param>
        /// <returns></returns>
        public BarDatasetBuilder BackgroundColors(params string[] colors)
        {
            _dataset.BackgroundColor = colors;
            return this;
        }

        /// <summary>
        /// Set border colors.
        /// </summary>
        /// <param name="colors"></param>
        /// <returns></returns>
        public BarDatasetBuilder BorderColors(params string[] colors)
        {
            _dataset.BorderColor = colors;
            return this;
        }

        /// <summary>
        /// Base value for the bar in data units along the value axis. If not set, defaults to the value axis base value.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public BarDatasetBuilder Base(int value)
        {
            _dataset.Base = value;
            return this;
        }

        /// <summary>
        /// Percent (0-1) of the available width each bar should be within the category width.
        /// 1.0 will take the whole category width and put the bars right next to each other.
        /// Default 0.9
        /// </summary>
        /// <param name="percentage"></param>
        /// <returns></returns>
        public BarDatasetBuilder BarPercentage(double percentage)
        {
            _dataset.BarPercentage = percentage;
            return this;
        }

        /// <summary>
        /// If this value is a number, it is applied to the width of each bar, in pixels. 
        /// When this is enforced, barPercentage and categoryPercentage are ignored.
        /// </summary>
        /// <param name="thickness"></param>
        /// <returns></returns>
        public BarDatasetBuilder BarThickness(int thickness)
        {
            _dataset.BarThickness = thickness;
            return this;
        }

        /// <summary>
        /// If set to 'flex', the base sample widths are calculated automatically based on the previous and following samples
        /// so that they take the full available widths without overlap. Then, bars are sized using barPercentage and categoryPercentage.
        /// There is no gap when the percentage options are 1. 
        /// This mode generates bars with different widths when data are not evenly spaced.
        /// </summary>
        /// <param name="thickness"></param>
        /// <returns></returns>
        public BarDatasetBuilder BarThickness(string thickness)
        {
            _dataset.BarThickness = thickness;
            return this;
        }

        /// <summary>
        /// This setting is used to avoid drawing the bar stroke at the base of the fill, or disable the border radius. 
        /// In general, this does not need to be changed except when creating chart types that derive from a bar chart.
        /// </summary>
        /// <param name="skipped"></param>
        /// <returns></returns>
        public BarDatasetBuilder BorderSkipped(Skipped skipped)
        {
            _dataset.BorderSkipped = skipped;
            return this;
        }

        /// <summary>
        /// Skip all borders (true), or don't skip any borders (false).
        /// </summary>
        /// <param name="skipped"></param>
        /// <returns></returns>
        public BarDatasetBuilder BorderSkipped(bool skipped)
        {
            _dataset.BorderSkipped = skipped;
            return this;
        }

        /// <summary>
        /// If this value is a number, it is applied to all sides of the rectangle (left, top, right, bottom), except borderSkipped.
        /// Default 0
        /// </summary>
        /// <param name="width"></param>
        /// <returns></returns>
        public new BarDatasetBuilder BorderWidth(int width)
        {
            _dataset.BorderWidth = width;
            return this;
        }

        /// <summary>
        /// If this value is an object, the left property defines the left border width. 
        /// Similarly, the right, top, and bottom properties can also be specified. Omitted borders and borderSkipped are skipped.
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <param name="top"></param>
        /// <param name="bottom"></param>
        /// <returns></returns>
        public BarDatasetBuilder BorderWidth(int left, int right, int top, int bottom)
        {
            _dataset.BorderWidth = new BorderWidth { Left = left, Right = right, Top = top, Bottom = bottom };
            return this;
        }

        /// <summary>
        /// If this value is a number, it is applied to all corners of the rectangle (topLeft, topRight, bottomLeft, bottomRight),
        /// except corners touching the borderSkipped. Default 0
        /// </summary>
        /// <param name="radius"></param>
        /// <returns></returns>
        public BarDatasetBuilder BorderRadius(int radius)
        {
            _dataset.BorderRadius = radius;
            return this;
        }

        /// <summary>
        /// If this value is an object, the topLeft property defines the top-left corners border radius.
        /// Similarly, the topRight, bottomLeft, and bottomRight.
        /// </summary>
        /// <param name="topLeft"></param>
        /// <param name="topRight"></param>
        /// <param name="bottomLeft"></param>
        /// <param name="bottomRight"></param>
        /// <returns></returns>
        public BarDatasetBuilder BorderRadius(int topLeft, int topRight, int bottomLeft, int bottomRight)
        {
            _dataset.BorderRadius = new BorderRadius { TopLeft = topLeft, TopRight = topRight, BottomLeft = bottomLeft, BottomRight = bottomRight };
            return this;
        }

        /// <summary>
        /// Percent (0-1) of the available width each category should be within the sample width.
        /// </summary>
        /// <param name="percentage"></param>
        /// <returns></returns>
        public BarDatasetBuilder CategoryPercentage(double percentage)
        {
            _dataset.CategoryPercentage = percentage;
            return this;
        }

        /// <summary>
        /// Should the bars be grouped on index axis. When true, all the datasets at same index value will be placed next to each other centering on that index value. 
        /// When false, each bar is placed on its actual index-axis value. Default true
        /// </summary>
        /// <param name="grouped"></param>
        /// <returns></returns>
        public BarDatasetBuilder Grouped(bool grouped)
        {
            _dataset.Grouped = grouped;
            return this;
        }

        /// <summary>
        /// The bar border radius when hovered (in pixels). Default 0
        /// </summary>
        /// <param name="radius"></param>
        /// <returns></returns>
        public BarDatasetBuilder HoverBorderRadius(int radius)
        {
            _dataset.HoverBorderRadius = radius;
            return this;
        }

        /// <summary>
        /// The base axis of the dataset. 'x' for vertical bars and 'y' for horizontal bars.
        /// </summary>
        /// <param name="axis"></param>
        /// <returns></returns>
        public BarDatasetBuilder IndexAxis(IndexAxis axis)
        {
            _dataset.IndexAxis = axis;
            return this;
        }

        /// <summary>
        /// The drawing order of dataset. Also affects order for stacking, tooltip and legend.
        /// Default 0
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public BarDatasetBuilder Order(int order)
        {
            _dataset.Order = order;
            return this;
        }

        /// <summary>
        /// Is style of the point enabled?
        /// </summary>
        /// <param name="enabled"></param>
        /// <returns></returns>
        public BarDatasetBuilder PointStyle(bool enabled)
        {
            _dataset.PointStyle = enabled;
            return this;
        }

        /// <summary>
        /// Style of the point.
        /// </summary>
        /// <param name="pointStyle"></param>
        /// <returns></returns>
        public BarDatasetBuilder PointStyle(PointStyle pointStyle)
        {
            _dataset.PointStyle = pointStyle;
            return this;
        }

        /// <summary>
        /// If true, null or undefined values will not be used for spacing calculations when determining bar size.
        /// </summary>
        /// <param name="skipNull"></param>
        /// <returns></returns>
        public BarDatasetBuilder SkipNull(bool skipNull)
        {
            _dataset.SkipNull = skipNull;
            return this;
        }

        /// <summary>
        /// The ID of the group to which this dataset belongs to (when stacked, each group will be a separate stack).
        /// </summary>
        /// <param name="stack"></param>
        /// <returns></returns>
        public BarDatasetBuilder Stack(string stack)
        {
            _dataset.Stack = stack;
            return this;
        }

        /// <summary>
        /// The ID of the x-axis to plot this dataset on.
        /// </summary>
        /// <param name="axisID"></param>
        /// <returns></returns>
        public BarDatasetBuilder XAxisID(string axisID)
        {
            _dataset.XAxisID = axisID;
            return this;
        }

        /// <summary>
        /// The ID of the y-axis to plot this dataset on.
        /// </summary>
        /// <param name="axisID"></param>
        /// <returns></returns>
        public BarDatasetBuilder YAxisID(string axisID)
        {
            _dataset.YAxisID = axisID;
            return this;
        }
    }
}
