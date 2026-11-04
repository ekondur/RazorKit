using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using Newtonsoft.Json.Linq;

namespace RazorKit.TomSelect.Builders
{
    /// <summary>Builds a select element and its Tom Select initialization.</summary>
    public partial class TomSelectBuilder : SettingsBuilder<TomSelectBuilder>
    {
        internal readonly Dictionary<string, object> Attributes = new Dictionary<string, object>(StringComparer.OrdinalIgnoreCase);
        internal Func<TomSelectBuilder, string> HtmlFactory;
        internal bool ModelBound;
        internal bool IsMultiple;
        private readonly string _name;
        private string _id;
        private string _nonce;

        /// <summary>Creates an unbound select. Use TomSelectFor for MVC model binding.</summary>
        public TomSelectBuilder(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("An element name is required.", nameof(name));
            _name = name;
            _id = name.Replace('.', '_').Replace('[', '_').Replace(']', '_');
        }

        internal string Field(string key, string fallback) => Settings.TryGetValue(key, out var value) ? Convert.ToString(value, CultureInfo.InvariantCulture) : fallback;
        internal string ElementId => _id;

        /// <summary>Overrides the generated element ID without changing its form field name.</summary>
        public TomSelectBuilder Id(string value)
        {
            if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("An element ID is required.", nameof(value));
            _id = value; return this;
        }
        /// <summary>Enables multiple form values. Model-bound helpers infer this from the property type.</summary>
        public TomSelectBuilder Multiple(bool value = true)
        {
            if (ModelBound && value != IsMultiple) throw new InvalidOperationException("Selection multiplicity must match the model property type.");
            IsMultiple = value; return this;
        }
        /// <summary>Disables the underlying form control.</summary>
        public TomSelectBuilder Disabled(bool value = true) => BooleanAttribute("disabled", value);
        /// <summary>Marks the underlying form control as required.</summary>
        public TomSelectBuilder Required(bool value = true) => BooleanAttribute("required", value);
        private TomSelectBuilder BooleanAttribute(string name, bool value)
        {
            if (value) Attributes[name] = name; else Attributes.Remove(name);
            return this;
        }
        /// <summary>Adds an HTML attribute. Use Id/Multiple to configure reserved attributes.</summary>
        public TomSelectBuilder Attribute(string name, object value)
        {
            if (string.IsNullOrWhiteSpace(name) || name.Any(c => !(char.IsLetterOrDigit(c) || c == '-' || c == '_' || c == ':')))
                throw new ArgumentException("Invalid HTML attribute name.", nameof(name));
            if (new[] { "id", "name", "multiple" }.Contains(name, StringComparer.OrdinalIgnoreCase))
                throw new ArgumentException("Use Id/Multiple; the form field name is fixed by the helper.", nameof(name));
            if (value == null || value is bool flag && !flag) Attributes.Remove(name);
            else Attributes[name] = value is bool ? name : value;
            return this;
        }
        /// <summary>Adds HTML attributes from an anonymous object; underscores become hyphens.</summary>
        public TomSelectBuilder HtmlAttributes(object attributes)
        {
            if (attributes == null) throw new ArgumentNullException(nameof(attributes));
            if (attributes is IDictionary<string, object> dictionary)
                foreach (var pair in dictionary) Attribute(pair.Key, pair.Value);
            else
                foreach (var property in attributes.GetType().GetProperties()) Attribute(property.Name.Replace('_', '-'), property.GetValue(attributes, null));
            return this;
        }
        /// <summary>Sets the nonce on generated script tags for applications using a CSP.</summary>
        public TomSelectBuilder ScriptNonce(string value) { _nonce = value; return this; }

        internal static string Encode(object value) => WebUtility.HtmlEncode(Convert.ToString(value, CultureInfo.InvariantCulture));
        internal static string[] Values(object value)
        {
            if (value == null) return Array.Empty<string>();
            if (value is string text) return new[] { text };
            if (value is IEnumerable sequence) return sequence.Cast<object>().Select(ValueText).ToArray();
            return new[] { ValueText(value) };
        }

        private static string ValueText(object value) => value is Enum
            ? Convert.ToString(Convert.ChangeType(value, Enum.GetUnderlyingType(value.GetType()), CultureInfo.InvariantCulture), CultureInfo.InvariantCulture)
            : Convert.ToString(value, CultureInfo.CurrentCulture);

        internal List<SelectOption> SelectOptions(IEnumerable<string> selected)
        {
            var selectedValues = new HashSet<string>(selected ?? Array.Empty<string>(), StringComparer.Ordinal);
            var result = new List<SelectOption>();
            if (Settings.TryGetValue("options", out var options) && options != null)
            {
                foreach (var option in JArray.FromObject(options))
                {
                    var value = (string)option[Field("valueField", "value")];
                    if (value == null) throw new InvalidOperationException("Every option must have a value field.");
                    result.Add(new SelectOption
                    {
                        Value = value,
                        Text = (string)option[Field("labelField", "text")] ?? value,
                        Disabled = (bool?)option[Field("disabledField", "disabled")] ?? false,
                        Selected = selectedValues.Contains(value)
                    });
                }
            }
            foreach (var value in selectedValues)
                if (!result.Any(option => option.Value == value)) result.Add(new SelectOption { Value = value, Text = value, Selected = true });
            // A blank option prevents the browser from selecting the first item on an empty scalar model.
            if (!IsMultiple && !result.Any(option => option.Value == ""))
                result.Insert(0, new SelectOption { Value = "", Text = "", Selected = selectedValues.Count == 0 });
            return result;
        }

        /// <summary>Returns the HTML select element without initialization.</summary>
        public string ToHtml()
        {
            if (HtmlFactory != null) return HtmlFactory(this);
            var html = new StringBuilder("<select id=\"").Append(Encode(_id)).Append("\" name=\"").Append(Encode(_name)).Append('"');
            if (IsMultiple) html.Append(" multiple=\"multiple\"");
            foreach (var pair in Attributes) html.Append(' ').Append(pair.Key).Append("=\"").Append(Encode(pair.Value)).Append('"');
            html.Append('>');
            var selected = Settings.TryGetValue("items", out var items) ? Values(items) : Array.Empty<string>();
            foreach (var option in SelectOptions(selected))
            {
                html.Append("<option value=\"").Append(Encode(option.Value)).Append('"');
                if (option.Selected) html.Append(" selected=\"selected\"");
                if (option.Disabled) html.Append(" disabled=\"disabled\"");
                html.Append('>').Append(Encode(option.Text)).Append("</option>");
            }
            return html.Append("</select>").ToString();
        }

        /// <summary>Returns the JavaScript settings object. Explicit null values and functions are preserved.</summary>
        public string ToConfiguration()
        {
            var settings = new Dictionary<string, object>(Settings);
            if (ModelBound) settings.Remove("items");
            // These events are emitted by Tom Select but are not constructor callback settings.
            settings.Remove("onItemSelect");
            settings.Remove("onDestroy");
            return ScriptJson.Serialize(settings);
        }

        /// <summary>Returns an idempotent initialization script, optionally wrapped in a script tag.</summary>
        public string ToScript(bool includeScriptTag = true)
        {
            var script = new StringBuilder("(function(){function init(){var element=document.getElementById(")
                .Append(ScriptJson.Serialize(_id)).Append(");if(!element||element.tomselect)return;var control=new TomSelect(element,")
                .Append(ToConfiguration()).Append(");");
            foreach (var pair in new[] { new { Key = "onItemSelect", Event = "item_select" }, new { Key = "onDestroy", Event = "destroy" } })
                if (Settings.TryGetValue(pair.Key, out var callback)) script.Append("control.on(").Append(ScriptJson.Serialize(pair.Event)).Append(',').Append(ScriptJson.Serialize(callback)).Append(");");
            script.Append("}if(document.readyState==='loading'){document.addEventListener('DOMContentLoaded',init,{once:true});}else{init();}})();");
            if (!includeScriptTag) return script.ToString();
            return "<script" + (_nonce == null ? "" : " nonce=\"" + Encode(_nonce) + "\"") + ">" + script + "</script>";
        }

        internal sealed class SelectOption
        {
            internal string Value;
            internal string Text;
            internal bool Selected;
            internal bool Disabled;
        }
    }
}
