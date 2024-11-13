using RazorKit.Datatable.Models;

namespace RazorKit.Datatable.Builders
{
    /// <summary>
    /// Layout Configuration.
    /// </summary>
    public class LayoutBuilder
    {
        private readonly Layout _layout;

        internal LayoutBuilder(Layout layout)
        {
            _layout = layout;
        }
        /// <summary>
        /// Positions elements above the table but centers them horizontally. 
        /// This layout places the controls centered at the top of the table.
        /// </summary>
        /// <param name="layouts"></param>
        /// <returns></returns>
        public LayoutBuilder Top(params Layouts[] layouts)
        {
            _layout.Top = layouts;
            return this;
        }

        /// <summary>
        /// Positions elements above the table but centers them horizontally. 
        /// This layout places the controls centered at the bottom of the table.
        /// </summary>
        /// <param name="layouts"></param>
        /// <returns></returns>
        public LayoutBuilder Bottom(params Layouts[] layouts)
        {
            _layout.Bottom = layouts;
            return this;
        }

        /// <summary>
        /// This layout places controls on the top left side of the table.
        /// </summary>
        /// <param name="layout"></param>
        /// <returns></returns>
        public LayoutBuilder TopStart(Layouts? layout)
        {
            _layout.TopStart = layout ?? Layouts.Null;
            return this;
        }

        /// <summary>
        /// This layout places controls on the top right side of the table.
        /// </summary>
        /// <param name="layout"></param>
        /// <returns></returns>
        public LayoutBuilder TopEnd(Layouts? layout)
        {
            _layout.TopEnd = layout ?? Layouts.Null;
            return this;
        }

        /// <summary>
        /// This layout places controls on the bottom left side of the table.
        /// </summary>
        /// <param name="layout"></param>
        /// <returns></returns>
        public LayoutBuilder BottomStart(Layouts? layout)
        {
            _layout.BottomStart = layout ?? Layouts.Null;
            return this;
        }

        /// <summary>
        /// This layout places controls on the bottom right side of the table.
        /// </summary>
        /// <param name="layout"></param>
        /// <returns></returns>
        public LayoutBuilder BottomEnd(Layouts? layout)
        {
            _layout.BottomEnd = layout ?? Layouts.Null;
            return this;
        }
    }
}
