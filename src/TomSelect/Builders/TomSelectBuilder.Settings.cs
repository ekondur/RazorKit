using System;
using System.Collections.Generic;

namespace RazorKit.TomSelect.Builders
{
    public partial class TomSelectBuilder
    {
        /// <summary>Sets Tom Select's persist option.</summary>
        public TomSelectBuilder Persist(bool value = true) => Set("persist", value);

        /// <summary>Sets Tom Select's diacritics option.</summary>
        public TomSelectBuilder Diacritics(bool value = true) => Set("diacritics", value);

        /// <summary>Sets Tom Select's createOnBlur option.</summary>
        public TomSelectBuilder CreateOnBlur(bool value = true) => Set("createOnBlur", value);

        /// <summary>Sets Tom Select's highlight option.</summary>
        public TomSelectBuilder Highlight(bool value = true) => Set("highlight", value);

        /// <summary>Sets Tom Select's openOnFocus option.</summary>
        public TomSelectBuilder OpenOnFocus(bool value = true) => Set("openOnFocus", value);

        /// <summary>Sets Tom Select's shouldOpen option.</summary>
        public TomSelectBuilder ShouldOpen(bool value = true) => Set("shouldOpen", value);

        /// <summary>Sets Tom Select's hideSelected option.</summary>
        public TomSelectBuilder HideSelected(bool value = true) => Set("hideSelected", value);

        /// <summary>Sets Tom Select's duplicates option.</summary>
        public TomSelectBuilder Duplicates(bool value = true) => Set("duplicates", value);

        /// <summary>Sets Tom Select's addPrecedence option.</summary>
        public TomSelectBuilder AddPrecedence(bool value = true) => Set("addPrecedence", value);

        /// <summary>Sets Tom Select's selectOnTab option.</summary>
        public TomSelectBuilder SelectOnTab(bool value = true) => Set("selectOnTab", value);

        /// <summary>Sets Tom Select's allowEmptyOption option.</summary>
        public TomSelectBuilder AllowEmptyOption(bool value = true) => Set("allowEmptyOption", value);

        /// <summary>Sets Tom Select's closeAfterSelect option.</summary>
        public TomSelectBuilder CloseAfterSelect(bool value = true) => Set("closeAfterSelect", value);

        /// <summary>Sets Tom Select's clearAfterSelect option.</summary>
        public TomSelectBuilder ClearAfterSelect(bool value = true) => Set("clearAfterSelect", value);

        /// <summary>Sets Tom Select's lockOptgroupOrder option.</summary>
        public TomSelectBuilder LockOptgroupOrder(bool value = true) => Set("lockOptgroupOrder", value);

        /// <summary>Sets Tom Select's copyClassesToDropdown option.</summary>
        public TomSelectBuilder CopyClassesToDropdown(bool value = true) => Set("copyClassesToDropdown", value);

        /// <summary>Sets Tom Select's hidePlaceholder option.</summary>
        public TomSelectBuilder HidePlaceholder(bool value = true) => Set("hidePlaceholder", value);

        /// <summary>Sets Tom Select's nesting option.</summary>
        public TomSelectBuilder Nesting(bool value = true) => Set("nesting", value);

        /// <summary>Sets Tom Select's delimiter option.</summary>
        public TomSelectBuilder Delimiter(string value) => Set("delimiter", value);

        /// <summary>Sets Tom Select's placeholder option.</summary>
        public TomSelectBuilder Placeholder(string value) => Set("placeholder", value);

        /// <summary>Sets Tom Select's loadingClass option.</summary>
        public TomSelectBuilder LoadingClass(string value) => Set("loadingClass", value);

        /// <summary>Sets Tom Select's dataAttr option.</summary>
        public TomSelectBuilder DataAttr(string value) => Set("dataAttr", value);

        /// <summary>Sets Tom Select's valueField option.</summary>
        public TomSelectBuilder ValueField(string value) => Set("valueField", value);

        /// <summary>Sets Tom Select's labelField option.</summary>
        public TomSelectBuilder LabelField(string value) => Set("labelField", value);

        /// <summary>Sets Tom Select's disabledField option.</summary>
        public TomSelectBuilder DisabledField(string value) => Set("disabledField", value);

        /// <summary>Sets Tom Select's optgroupField option.</summary>
        public TomSelectBuilder OptgroupField(string value) => Set("optgroupField", value);

        /// <summary>Sets Tom Select's optgroupLabelField option.</summary>
        public TomSelectBuilder OptgroupLabelField(string value) => Set("optgroupLabelField", value);

        /// <summary>Sets Tom Select's optgroupValueField option.</summary>
        public TomSelectBuilder OptgroupValueField(string value) => Set("optgroupValueField", value);

        /// <summary>Sets Tom Select's wrapperClass option.</summary>
        public TomSelectBuilder WrapperClass(string value) => Set("wrapperClass", value);

        /// <summary>Sets Tom Select's controlClass option.</summary>
        public TomSelectBuilder ControlClass(string value) => Set("controlClass", value);

        /// <summary>Sets Tom Select's dropdownClass option.</summary>
        public TomSelectBuilder DropdownClass(string value) => Set("dropdownClass", value);

        /// <summary>Sets Tom Select's dropdownContentClass option.</summary>
        public TomSelectBuilder DropdownContentClass(string value) => Set("dropdownContentClass", value);

        /// <summary>Sets Tom Select's itemClass option.</summary>
        public TomSelectBuilder ItemClass(string value) => Set("itemClass", value);

        /// <summary>Sets Tom Select's optionClass option.</summary>
        public TomSelectBuilder OptionClass(string value) => Set("optionClass", value);

        /// <summary>Sets Tom Select's dropdownParent option.</summary>
        public TomSelectBuilder DropdownParent(string value) => Set("dropdownParent", value);

        /// <summary>Sets Tom Select's controlInput option.</summary>
        public TomSelectBuilder ControlInput(string value) => Set("controlInput", value);

        /// <summary>Sets Tom Select's maxItems option; null removes the limit or throttle.</summary>
        public TomSelectBuilder MaxItems(int? value) => Set("maxItems", value);

        /// <summary>Sets Tom Select's maxOptions option; null removes the limit or throttle.</summary>
        public TomSelectBuilder MaxOptions(int? value) => Set("maxOptions", value);

        /// <summary>Sets Tom Select's loadThrottle option; null removes the limit or throttle.</summary>
        public TomSelectBuilder LoadThrottle(int? value) => Set("loadThrottle", value);

        /// <summary>Sets Tom Select's refreshThrottle option.</summary>
        public TomSelectBuilder RefreshThrottle(int value) => Set("refreshThrottle", value);

        /// <summary>Enables or disables creation of options.</summary>
        public TomSelectBuilder Create(bool value = true) => Set("create", value);
        /// <summary>Creates options using a trusted JavaScript function.</summary>
        public TomSelectBuilder Create(string callback) => SetJavaScript("create", callback);
        /// <summary>Sets a regular expression pattern for allowed new items.</summary>
        public TomSelectBuilder CreateFilter(string pattern) => Set("createFilter", pattern);
        /// <summary>Sets a trusted function or RegExp for allowed new items.</summary>
        public TomSelectBuilder CreateFilter(JavaScript expression) => Set("createFilter", expression);
        /// <summary>Sets a literal paste separator.</summary>
        public TomSelectBuilder SplitOn(string separator) => Set("splitOn", separator);
        /// <summary>Sets a trusted RegExp paste separator.</summary>
        public TomSelectBuilder SplitOn(JavaScript expression) => Set("splitOn", expression);
        /// <summary>Loads options on initialization.</summary>
        public TomSelectBuilder Preload(bool value = true) => Set("preload", value);
        /// <summary>Loads options on first focus.</summary>
        public TomSelectBuilder PreloadOnFocus() => Set("preload", "focus");
        /// <summary>Sets single or multi selection mode.</summary>
        public TomSelectBuilder Mode(string value)
        {
            if (value != "single" && value != "multi") throw new ArgumentException("Use single or multi.", nameof(value));
            return Set("mode", value);
        }
        /// <summary>Sets the fields searched locally; an empty list disables local filtering.</summary>
        public TomSelectBuilder SearchField(params string[] fields) => Set("searchField", fields);
        /// <summary>Configures weighted search fields.</summary>
        public TomSelectBuilder SearchField(Action<SearchFieldsBuilder> configure)
        {
            var builder = new SearchFieldsBuilder(); configure(builder); return Set("searchField", builder.Fields);
        }
        /// <summary>Sets and/or semantics for multiple search terms.</summary>
        public TomSelectBuilder SearchConjunction(string value)
        {
            if (value != "and" && value != "or") throw new ArgumentException("Use and or or.", nameof(value));
            return Set("searchConjunction", value);
        }
        /// <summary>Sorts by a field.</summary>
        public TomSelectBuilder SortField(string field) => Set("sortField", field);
        /// <summary>Configures ordered sort fields.</summary>
        public TomSelectBuilder SortField(Action<SortFieldsBuilder> configure)
        {
            var builder = new SortFieldsBuilder(); configure(builder); return Set("sortField", builder.Fields);
        }
        /// <summary>Sets a trusted sort function.</summary>
        public TomSelectBuilder SortField(JavaScript expression) => Set("sortField", expression);
        /// <summary>Sets selected values for an unbound helper. Model-bound helpers use ModelState/model values.</summary>
        public TomSelectBuilder Items(params string[] values) => Set("items", values);
        /// <summary>Sets option data. Property names are preserved, including custom fields.</summary>
        public TomSelectBuilder Options<T>(IEnumerable<T> values) => Set("options", values);
        /// <summary>Sets optgroup data. Property names are preserved.</summary>
        public TomSelectBuilder Optgroups<T>(IEnumerable<T> values) => Set("optgroups", values);
        /// <summary>Builds options using the configured value, label, group and disabled fields.</summary>
        public TomSelectBuilder Options(Action<OptionsBuilder> configure)
        {
            var builder = new OptionsBuilder(this); configure(builder); return Set("options", builder.Values);
        }
        /// <summary>Builds groups using the configured group value and label fields.</summary>
        public TomSelectBuilder Optgroups(Action<OptgroupsBuilder> configure)
        {
            var builder = new OptgroupsBuilder(this); configure(builder); return Set("optgroups", builder.Values);
        }
        /// <summary>Configures lifecycle callbacks.</summary>
        public TomSelectBuilder Callbacks(Action<CallbacksBuilder> configure)
        {
            var builder = new CallbacksBuilder(); configure(builder);
            foreach (var pair in builder.Settings) Set(pair.Key, pair.Value);
            return this;
        }
        /// <summary>Configures trusted rendering functions. Escape user data with Tom Select's escape argument.</summary>
        public TomSelectBuilder Templates(Action<TemplatesBuilder> configure)
        {
            var builder = new TemplatesBuilder(); configure(builder); return Set("render", builder.Settings);
        }
        /// <summary>Configures built-in or custom plugins.</summary>
        public TomSelectBuilder Plugins(Action<PluginsBuilder> configure)
        {
            var builder = new PluginsBuilder(); configure(builder); return Set("plugins", builder.Settings);
        }
        /// <summary>Enables plugins by their upstream names.</summary>
        public TomSelectBuilder Plugins(params string[] names)
        {
            var builder = new PluginsBuilder(); foreach (var name in names) builder.Add(name); return Set("plugins", builder.Settings);
        }
        /// <summary>Configures fetch-based remote loading. Later Load/ShouldLoad calls may override the generated callbacks.</summary>
        public TomSelectBuilder DataSource(Action<DataSourceBuilder> configure)
        {
            var builder = new DataSourceBuilder(); configure(builder); builder.Apply(this); return this;
        }
        /// <summary>Sets the trusted load JavaScript callback.</summary>
        public TomSelectBuilder Load(string expression) => SetJavaScript("load", expression);
        /// <summary>Sets the trusted shouldLoad JavaScript callback.</summary>
        public TomSelectBuilder ShouldLoad(string expression) => SetJavaScript("shouldLoad", expression);
        /// <summary>Sets the trusted score JavaScript callback.</summary>
        public TomSelectBuilder Score(string expression) => SetJavaScript("score", expression);
        /// <summary>Sets the trusted optionGroupRegister JavaScript callback.</summary>
        public TomSelectBuilder OptionGroupRegister(string expression) => SetJavaScript("optionGroupRegister", expression);
        /// <summary>Sets the trusted firstUrl JavaScript callback.</summary>
        public TomSelectBuilder FirstUrl(string expression) => SetJavaScript("firstUrl", expression);
        /// <summary>Sets the trusted shouldLoadMore JavaScript callback.</summary>
        public TomSelectBuilder ShouldLoadMore(string expression) => SetJavaScript("shouldLoadMore", expression);
    }
}
