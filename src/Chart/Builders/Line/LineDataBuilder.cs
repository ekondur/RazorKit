using HelperJS.Chart.Models;
using System;

namespace HelperJS.Chart.Builders.Line
{
    /// <summary>
    /// LineData Builder
    /// </summary>
    public class LineDataBuilder
    {
        private readonly Data _data;

        internal LineDataBuilder(Data data)
        {
            _data = data;
        }

        /// <summary>
        /// Assigns labels to represent data.
        /// </summary>
        /// <param name="labels">An array of labels to assign.</param>
        /// <returns>Returns the LineDataBuilder object with assigned labels.</returns>
        public LineDataBuilder Labels(params string[] labels)
        {
            _data.Labels = labels;
            return this;
        }

        /// <summary>
        /// Configure datasets.
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        public LineDataBuilder Datasets(Action<LineDatasetBuilder> action)
        {
            var builder = new LineDatasetBuilder(_data);
            action(builder);
            return this;
        }
    }
}
