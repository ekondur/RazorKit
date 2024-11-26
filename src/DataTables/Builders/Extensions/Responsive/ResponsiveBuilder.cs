using RazorKit.DataTables.Models;
using System;
using System.Collections.Generic;

namespace RazorKit.DataTables.Builders
{
    /// <summary>
    /// Configure the Responsive extension for DataTables.
    /// </summary>
    public class ResponsiveBuilder
    {
        private readonly Responsive _responsive;

        internal ResponsiveBuilder(Responsive responsive)
        {
            _responsive = responsive;
        }

        /// <summary>
        /// Set the orthogonal data request type for the hidden information display.
        /// </summary>
        /// <param name="orthogonal"></param>
        /// <returns></returns>
        public ResponsiveBuilder Orthogonal(string orthogonal)
        {
            _responsive.Orthogonal = orthogonal;
            return this;
        }

        /// <summary>
        /// Configure the breakpoints for a Responsive instance.
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        public ResponsiveBuilder Breakpoints(Action<BreakpointBuilder> action)
        {
            _responsive.Breakpoints = new List<Breakpoint>();
            var builder = new BreakpointBuilder(_responsive.Breakpoints);
            action(builder);
            return this;
        }

        /// <summary>
        /// Enable the child rows shown by Responsive for collapsed tables.
        /// </summary>
        /// <param name="enabled"></param>
        /// <returns></returns>
        public ResponsiveBuilder Details(bool enabled)
        {
            _responsive.Details = enabled;
            return this;
        }

        /// <summary>
        /// Configure the child rows shown by Responsive for collapsed tables.
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        public ResponsiveBuilder Details(Action<DetailsBuilder> action)
        {
            _responsive.Details = new Details();
            var builder = new DetailsBuilder((Details)_responsive.Details);
            action(builder);
            return this;
        }
    }
}
