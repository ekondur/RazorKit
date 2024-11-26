using RazorKit.DataTables.Models;

namespace RazorKit.DataTables.Builders
{
    /// <summary>
    /// Responsive Details Configuration.
    /// </summary>
    public class DetailsBuilder
    {
        private readonly Details _detail;

        internal DetailsBuilder(Details detail)
        {
            _detail = detail;
        }

        /// <summary>
        /// Set the child row display control type.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public DetailsBuilder Type(DetailType type)
        {
            _detail.Type = type;
            return this;
        }

        /// <summary>
        /// Column / selector for child row display control when using 'column' details type.
        /// </summary>
        /// <param name="target"></param>
        /// <returns></returns>
        public DetailsBuilder Target(int target)
        {
            _detail.Target = target;
            return this;
        }

        /// <summary>
        /// Define how the hidden information should be displayed to the end user.
        /// </summary>
        /// <param name="display"></param>
        /// <returns></returns>
        public DetailsBuilder Display(string display)
        {
            _detail.Display = display;
            return this;
        }

        /// <summary>
        /// Define the renderer used to display the child rows.
        /// </summary>
        /// <param name="renderer"></param>
        /// <returns></returns>
        public DetailsBuilder Renderer(string renderer)
        {
            _detail.Renderer = renderer;
            return this;
        }
    }
}
