using RazorKit.Chart.Models;
using System;

namespace RazorKit.Chart.Builders
{
    /// <summary>
    /// Data Configuration.
    /// </summary>
    public class DataBuilder
    {
        private readonly Data _data;

        internal DataBuilder(Data data)
        {
            _data = data;
        }

        /// <summary>
        /// Assigns labels to represent data.
        /// </summary>
        /// <param name="labels">An array of labels to assign.</param>
        /// <returns>Returns the LineDataBuilder object with assigned labels.</returns>
        public DataBuilder Labels(params string[] labels)
        {
            _data.Labels = labels;
            return this;
        }

        /// <summary>
        /// Configure datasets.
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        public DataBuilder Datasets(Action<DatasetsBuilder> action)
        {
            var builder = new DatasetsBuilder(_data);
            action(builder);
            return this;
        }
    }
}
