using RazorKit.Datatable.Models;
using System.Collections.Generic;

namespace RazorKit.Datatable.Builders
{
    /// <summary>
    /// Responsive Breakpoints Configuration.
    /// </summary>
    public class BreakpointBuilder
    {
        private readonly IList<Breakpoint> _breakpoints;

        internal BreakpointBuilder(IList<Breakpoint> breakpoints)
        {
            _breakpoints = breakpoints;
        }

        /// <summary>
        /// Set the breakpoints for a Responsive instance.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="width"></param>
        /// <returns></returns>
        public BreakpointBuilder Add(string name, int width)
        {
            _breakpoints.Add(new Breakpoint { Name = name, Width = width.ToString() });
            return this;
        }

        /// <summary>
        /// Set the breakpoints for a Responsive instance. Width will be Infinity.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public BreakpointBuilder Add(string name)
        {
            _breakpoints.Add(new Breakpoint { Name = name, Width = "Infinity" });
            return this;
        }
    }
}
