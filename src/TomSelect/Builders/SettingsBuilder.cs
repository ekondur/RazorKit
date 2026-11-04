using System;
using System.Collections.Generic;

namespace RazorKit.TomSelect.Builders
{
    /// <summary>Extensible settings shared by Tom Select configuration builders.</summary>
    public abstract class SettingsBuilder<T> where T : SettingsBuilder<T>
    {
        internal readonly Dictionary<string, object> Settings = new Dictionary<string, object>();

        /// <summary>Sets a JSON value, preserving its property names and explicit nulls.</summary>
        public T Set(string name, object value)
        {
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("A setting name is required.", nameof(name));
            Settings[name] = value;
            return (T)this;
        }

        /// <summary>Sets a trusted JavaScript expression. Do not use untrusted input.</summary>
        public T SetJavaScript(string name, string expression) => Set(name, new JavaScript(expression));
    }
}
