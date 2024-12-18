using System.Collections.Generic;

namespace RazorKit.DataTables.Builders
{
    /// <summary>
    /// Layout Configuration.
    /// </summary>
    public class LayoutsBuilder
    {
        private readonly Dictionary<string, object> _layouts;

        internal LayoutsBuilder(Dictionary<string, object> layout)
        {
            _layouts = layout;
        }

        /// <summary>
        /// Set a new position for feature or set null to disable feature.
        /// </summary>
        /// <param name="position"></param>
        /// <param name="feature"></param>
        /// <returns></returns>
        public LayoutsBuilder Set(string position, string feature)
        {
            _layouts.Add(position, feature);
            return this;
        }

        /// <summary>
        /// Positions elements above the table but centers them horizontally. 
        /// This layout places the controls centered at the top of the table.
        /// </summary>
        /// <param name="features"></param>
        /// <returns></returns>
        public LayoutsBuilder Top(params string[] features)
        {
            _layouts.Add("top", features);
            return this;
        }

        /// <summary>
        /// Positions elements above the table but centers them horizontally. 
        /// This layout places the controls centered at the bottom of the table.
        /// </summary>
        /// <param name="features"></param>
        /// <returns></returns>
        public LayoutsBuilder Bottom(params string[] features)
        {
            _layouts.Add("bottom", features);
            return this;
        }
    }
}
