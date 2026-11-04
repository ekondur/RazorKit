using System;
using System.Collections.Generic;

namespace RazorKit.TomSelect.Builders
{
    /// <summary>Builds weighted search fields.</summary>
    public sealed class SearchFieldsBuilder
    {
        internal readonly List<object> Fields = new List<object>();
        /// <summary>Adds a field with an optional search weight.</summary>
        public SearchFieldsBuilder Add(string field, double weight = 1)
        {
            Fields.Add(new { field, weight }); return this;
        }
    }

    /// <summary>Builds ordered sort fields.</summary>
    public sealed class SortFieldsBuilder
    {
        internal readonly List<object> Fields = new List<object>();
        /// <summary>Adds an ascending or descending sort field.</summary>
        public SortFieldsBuilder Add(string field, string direction = "asc")
        {
            if (direction != "asc" && direction != "desc") throw new ArgumentException("Use asc or desc.", nameof(direction));
            Fields.Add(new { field, direction }); return this;
        }
    }

    /// <summary>Builds options without requiring a custom data model.</summary>
    public sealed class OptionsBuilder
    {
        private readonly TomSelectBuilder _owner;
        internal readonly List<object> Values = new List<object>();
        internal OptionsBuilder(TomSelectBuilder owner) { _owner = owner; }
        /// <summary>Adds an option, optionally grouped or disabled. Configure field names before calling Options.</summary>
        public OptionsBuilder Add(string value, string text, string optgroup = null, bool disabled = false)
        {
            var option = new Dictionary<string, object>
            {
                [_owner.Field("valueField", "value")] = value,
                [_owner.Field("labelField", "text")] = text,
                [_owner.Field("disabledField", "disabled")] = disabled
            };
            if (optgroup != null) option[_owner.Field("optgroupField", "optgroup")] = optgroup;
            Values.Add(option); return this;
        }
    }

    /// <summary>Builds option groups.</summary>
    public sealed class OptgroupsBuilder
    {
        private readonly TomSelectBuilder _owner;
        internal readonly List<object> Values = new List<object>();
        internal OptgroupsBuilder(TomSelectBuilder owner) { _owner = owner; }
        /// <summary>Adds an option group. Configure field names before calling Optgroups.</summary>
        public OptgroupsBuilder Add(string value, string label, bool disabled = false)
        {
            Values.Add(new Dictionary<string, object>
            {
                [_owner.Field("optgroupValueField", "value")] = value,
                [_owner.Field("optgroupLabelField", "label")] = label,
                [_owner.Field("disabledField", "disabled")] = disabled
            });
            return this;
        }
    }
}
