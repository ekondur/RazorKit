using RazorKit.DataTables.Models;

namespace RazorKit.DataTables.Builders
{
    /// <summary>
    /// Fixed Columns Configuration.
    /// </summary>
    public class FixedColumnsBuilder
    {
        private readonly FixedColumns _fixedColumns;

        internal FixedColumnsBuilder(FixedColumns fixedColumns)
        {
            _fixedColumns = fixedColumns;
        }

        /// <summary>
        /// Number of columns to fix to the start of the table.
        /// </summary>
        /// <param name="start"></param>
        /// <returns></returns>
        public FixedColumnsBuilder Start(int start)
        {
            _fixedColumns.Start = start;
            return this;
        }

        /// <summary>
        /// Number of columns to fix to the end of the table.
        /// </summary>
        /// <param name="end"></param>
        /// <returns></returns>
        public FixedColumnsBuilder End(int end)
        {
            _fixedColumns.End = end;
            return this;
        }

        /// <summary>
        /// Number of columns to fix to the left of the table.
        /// </summary>
        /// <param name="left"></param>
        /// <returns></returns>
        public FixedColumnsBuilder Left(int left)
        {
            _fixedColumns.Left = left;
            return this;
        }

        /// <summary>
        /// Number of columns to fix to the right of the table.
        /// </summary>
        /// <param name="right"></param>
        /// <returns></returns>
        public FixedColumnsBuilder Right(int right)
        {
            _fixedColumns.Right = right;
            return this;
        }

        /// <summary>
        /// Number of columns to fix to the left of the table.
        /// </summary>
        /// <param name="leftColumns"></param>
        /// <returns></returns>
        public FixedColumnsBuilder LeftColumns(int leftColumns)
        {
            _fixedColumns.LeftColumns = leftColumns;
            return this;
        }

        /// <summary>
        /// Number of columns to fix to the right of the table.
        /// </summary>
        /// <param name="rightColumns"></param>
        /// <returns></returns>
        public FixedColumnsBuilder RightColumns(int rightColumns)
        {
            _fixedColumns.RightColumns = rightColumns;
            return this;
        }
    }
}
