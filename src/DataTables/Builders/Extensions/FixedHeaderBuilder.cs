using RazorKit.DataTables.Models;

namespace RazorKit.DataTables.Builders
{
    /// <summary>
    /// FixedHeader Configuraion.
    /// </summary>
    public class FixedHeaderBuilder
    {
        private readonly FixedHeader _fixedHeader;

        internal FixedHeaderBuilder(FixedHeader fixedHeader)
        {
            _fixedHeader = fixedHeader;
        }

        /// <summary>
        /// Enable / disable fixed header.
        /// </summary>
        /// <param name="header"></param>
        /// <returns></returns>
        public FixedHeaderBuilder Header(bool header)
        {
            _fixedHeader.Header = header;
            return this;
        }

        /// <summary>
        /// Enable / disable fixed footer.
        /// </summary>
        /// <param name="footer"></param>
        /// <returns></returns>
        public FixedHeaderBuilder Footer(bool footer)
        {
            _fixedHeader.Footer = footer;
            return this;
        }

        /// <summary>
        /// Offset the table's fixed header.
        /// </summary>
        /// <param name="offset"></param>
        /// <returns></returns>
        public FixedHeaderBuilder HeaderOffset(int offset)
        {
            _fixedHeader.HeaderOffset = offset.ToString();
            return this;
        }

        /// <summary>
        /// Offset the table's fixed header with function.
        /// </summary>
        /// <param name="function"></param>
        /// <returns></returns>
        public FixedHeaderBuilder HeaderOffset(string function)
        {
            _fixedHeader.HeaderOffset = function;
            return this;
        }

        /// <summary>
        /// Offset the table's fixed footer.
        /// </summary>
        /// <param name="offset"></param>
        /// <returns></returns>
        public FixedHeaderBuilder FooterOffset(int offset)
        {
            _fixedHeader.FooterOffset = offset.ToString();
            return this;
        }

        /// <summary>
        /// Offset the table's fixed footer with function.
        /// </summary>
        /// <param name="function"></param>
        /// <returns></returns>
        public FixedHeaderBuilder FooterOffset(string function)
        {
            _fixedHeader.FooterOffset = function;
            return this;
        }
    }
}
