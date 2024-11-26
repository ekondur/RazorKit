using RazorKit.ChartJs.Models;

namespace RazorKit.ChartJs.Builders
{
    /// <summary>
    /// Doughnut or Pie Datasets Configuration.
    /// </summary>
    public class DoughnutPieDatasetBuilder : ArcDatasetBuilder<DoughnutPieDatasetBuilder>
    {
        private readonly DoughnutPieDataset _dataset;

        internal DoughnutPieDatasetBuilder(DoughnutPieDataset dataset) : base(dataset)
        {
            _dataset = dataset;
        }

        /// <summary>
        /// Per-dataset override for the sweep that the arcs cover.
        /// </summary>
        /// <param name="circumference"></param>
        /// <returns></returns>
        public DoughnutPieDatasetBuilder Circumference(int circumference)
        {
            _dataset.Circumference = circumference;
            return this;
        }

        /// <summary>
        /// arc offset when hovered (in pixels).
        /// </summary>
        /// <param name="offset"></param>
        /// <returns></returns>
        public DoughnutPieDatasetBuilder HoverOffset(int offset)
        {
            _dataset.HoverOffset = offset;
            return this;
        }

        /// <summary>
        /// arc offset (in pixels).
        /// </summary>
        /// <param name="offset"></param>
        /// <returns></returns>
        public DoughnutPieDatasetBuilder Offset(int offset)
        {
            _dataset.Offset = offset;
            return this;
        }

        /// <summary>
        /// arc offset (in pixels).
        /// </summary>
        /// <param name="offset"></param>
        /// <returns></returns>
        public DoughnutPieDatasetBuilder Offset(params int[] offset)
        {
            _dataset.Offset = offset;
            return this;
        }

        /// <summary>
        /// Per-dataset override for the starting angle to draw arcs from.
        /// </summary>
        /// <param name="rotation"></param>
        /// <returns></returns>
        public DoughnutPieDatasetBuilder Rotation(int rotation)
        {
            _dataset.Rotation = rotation;
            return this;
        }

        /// <summary>
        /// Fixed arc offset (in pixels). Similar to offset but applies to all arcs. Default 0
        /// </summary>
        /// <param name="spacing"></param>
        /// <returns></returns>
        public DoughnutPieDatasetBuilder Spacing(int spacing)
        {
            _dataset.Spacing = spacing;
            return this;
        }

        /// <summary>
        /// The relative thickness of the dataset. Providing a value for weight will cause the pie or doughnut dataset to be drawn with
        /// a thickness relative to the sum of all the dataset weight values. Default 1
        /// </summary>
        /// <param name="weight"></param>
        /// <returns></returns>
        public DoughnutPieDatasetBuilder Weight(int weight)
        {
            _dataset.Weight = weight;
            return this;
        }
    }
}
