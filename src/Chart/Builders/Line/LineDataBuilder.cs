using HelperJS.Chart.Models;
using System;

namespace HelperJS.Chart.Builders.Line
{
    public class LineDataBuilder
    {
        private readonly ChartJs _chart;

        public LineDataBuilder(ChartJs chart)
        {
            _chart = chart;
            _chart.Data = new Data();
        }

        public LineDataBuilder Labels(params string[] labels)
        {
            _chart.Data.Labels = labels;
            return this;
        }

        public LineDataBuilder Datasets(Action<LineDatasetBuilder> action)
        {
            var builder = new LineDatasetBuilder(_chart);
            action(builder);
            return this;
        }
    }
}
