using System.Collections.Generic;

namespace RazorKit.SweetAlert2.Builders
{
    /// <summary>
    /// Attributes configuration.
    /// </summary>
    public class AttributesBuilder
    {
        private readonly Dictionary<string, string> _attributes;

        internal AttributesBuilder(Dictionary<string, string> attributes)
        {
            _attributes = attributes;
        }

        /// <summary>
        /// Add an attribute
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public AttributesBuilder Add(string name, string value)
        {
            _attributes[name] = value;
            return this;
        }
    }
}
