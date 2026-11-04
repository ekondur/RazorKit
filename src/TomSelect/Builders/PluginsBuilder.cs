using System;

namespace RazorKit.TomSelect.Builders
{
    /// <summary>Configures all bundled Tom Select plugins and custom plugins.</summary>
    public sealed class PluginsBuilder : SettingsBuilder<PluginsBuilder>
    {
        /// <summary>Adds a plugin with optional settings; plugin scripts must already be loaded.</summary>
        public PluginsBuilder Add(string name, Action<PluginOptionsBuilder> configure = null)
        {
            var builder = new PluginOptionsBuilder(); configure?.Invoke(builder); return Set(name, builder.Settings);
        }
        /// <summary>Enables the caret_position plugin.</summary>
        public PluginsBuilder CaretPosition(Action<PluginOptionsBuilder> configure = null) => Add("caret_position", configure);
        /// <summary>Enables the change_listener plugin.</summary>
        public PluginsBuilder ChangeListener(Action<PluginOptionsBuilder> configure = null) => Add("change_listener", configure);
        /// <summary>Enables the checkbox_options plugin.</summary>
        public PluginsBuilder CheckboxOptions(Action<PluginOptionsBuilder> configure = null) => Add("checkbox_options", configure);
        /// <summary>Enables the clear_button plugin.</summary>
        public PluginsBuilder ClearButton(Action<PluginOptionsBuilder> configure = null) => Add("clear_button", configure);
        /// <summary>Enables the drag_drop plugin.</summary>
        public PluginsBuilder DragDrop(Action<PluginOptionsBuilder> configure = null) => Add("drag_drop", configure);
        /// <summary>Enables the dropdown_header plugin.</summary>
        public PluginsBuilder DropdownHeader(Action<PluginOptionsBuilder> configure = null) => Add("dropdown_header", configure);
        /// <summary>Enables the dropdown_input plugin.</summary>
        public PluginsBuilder DropdownInput(Action<PluginOptionsBuilder> configure = null) => Add("dropdown_input", configure);
        /// <summary>Enables the input_autogrow plugin.</summary>
        public PluginsBuilder InputAutogrow(Action<PluginOptionsBuilder> configure = null) => Add("input_autogrow", configure);
        /// <summary>Enables the no_active_items plugin.</summary>
        public PluginsBuilder NoActiveItems(Action<PluginOptionsBuilder> configure = null) => Add("no_active_items", configure);
        /// <summary>Enables the no_backspace_delete plugin.</summary>
        public PluginsBuilder NoBackspaceDelete(Action<PluginOptionsBuilder> configure = null) => Add("no_backspace_delete", configure);
        /// <summary>Enables the optgroup_columns plugin.</summary>
        public PluginsBuilder OptgroupColumns(Action<PluginOptionsBuilder> configure = null) => Add("optgroup_columns", configure);
        /// <summary>Enables the remove_button plugin.</summary>
        public PluginsBuilder RemoveButton(Action<PluginOptionsBuilder> configure = null) => Add("remove_button", configure);
        /// <summary>Enables the restore_on_backspace plugin.</summary>
        public PluginsBuilder RestoreOnBackspace(Action<PluginOptionsBuilder> configure = null) => Add("restore_on_backspace", configure);
        /// <summary>Enables the virtual_scroll plugin.</summary>
        public PluginsBuilder VirtualScroll(Action<PluginOptionsBuilder> configure = null) => Add("virtual_scroll", configure);
    }

    /// <summary>Plugin settings, including an escape hatch for future or third-party plugins.</summary>
    public sealed class PluginOptionsBuilder : SettingsBuilder<PluginOptionsBuilder>
    {
        /// <summary>Sets the plugin's title option.</summary>
        public PluginOptionsBuilder Title(string value) => Set("title", value);
        /// <summary>Sets the plugin's label option.</summary>
        public PluginOptionsBuilder Label(string value) => Set("label", value);
        /// <summary>Sets the plugin's className option.</summary>
        public PluginOptionsBuilder ClassName(string value) => Set("className", value);
        /// <summary>Sets the plugin's headerClass option.</summary>
        public PluginOptionsBuilder HeaderClass(string value) => Set("headerClass", value);
        /// <summary>Sets the plugin's titleRowClass option.</summary>
        public PluginOptionsBuilder TitleRowClass(string value) => Set("titleRowClass", value);
        /// <summary>Sets the plugin's labelClass option.</summary>
        public PluginOptionsBuilder LabelClass(string value) => Set("labelClass", value);
        /// <summary>Sets the plugin's closeClass option.</summary>
        public PluginOptionsBuilder CloseClass(string value) => Set("closeClass", value);
        /// <summary>Sets the trusted plugin HTML rendering function.</summary>
        public PluginOptionsBuilder Html(string expression) => SetJavaScript("html", expression);
        /// <summary>Sets classes added to checked options by checkbox_options.</summary>
        public PluginOptionsBuilder CheckedClassNames(params string[] values) => Set("checkedClassNames", values);
        /// <summary>Sets classes added to unchecked options by checkbox_options.</summary>
        public PluginOptionsBuilder UncheckedClassNames(params string[] values) => Set("uncheckedClassNames", values);
        /// <summary>Sets the button's accessibility role.</summary>
        public PluginOptionsBuilder Role(string value) => Set("role", value);
        /// <summary>Sets the button's keyboard tab index.</summary>
        public PluginOptionsBuilder TabIndex(int value) => Set("tabindex", value);
        /// <summary>Sets the trusted text function used by restore_on_backspace.</summary>
        public PluginOptionsBuilder Text(string expression) => SetJavaScript("text", expression);
        /// <summary>Sets a trusted plugin rendering function.</summary>
        public PluginOptionsBuilder Html(JavaScript expression) => Set("html", expression);
    }
}
