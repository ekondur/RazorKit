# Plugins and templates

Load `tom-select.complete` or explicitly load each plugin you enable. RazorKit configures plugins; it does not download their scripts.

```csharp
.Plugins(plugins => plugins
    .RemoveButton(options => options.Title("Remove item"))
    .ClearButton(options => options.Title("Clear all"))
    .CheckboxOptions())
```

All bundled plugins have fluent methods:

| Method | Upstream plugin |
|---|---|
| `CaretPosition` | `caret_position` |
| `ChangeListener` | `change_listener` |
| `CheckboxOptions` | `checkbox_options` |
| `ClearButton` | `clear_button` |
| `DragDrop` | `drag_drop` |
| `DropdownHeader` | `dropdown_header` |
| `DropdownInput` | `dropdown_input` |
| `InputAutogrow` | `input_autogrow` |
| `NoActiveItems` | `no_active_items` |
| `NoBackspaceDelete` | `no_backspace_delete` |
| `OptgroupColumns` | `optgroup_columns` |
| `RemoveButton` | `remove_button` |
| `RestoreOnBackspace` | `restore_on_backspace` |
| `VirtualScroll` | `virtual_scroll` |

Each method accepts an optional settings callback. `Plugins("remove_button", "clear_button")` is also supported. Registration order is preserved, and a repeated plugin name replaces its settings without duplicating it. Use `Add("custom_plugin", options => options.Set("customSetting", value))` for custom plugins; register their JavaScript implementation before initialization. `SetJavaScript` passes function-valued plugin options.

The shared example application demonstrates every bundled plugin. Virtual scrolling needs custom paged loading; see [remote data](remote-data.md).

## Templates

```csharp
.Templates(templates => templates
    .Option("function(data, escape) { return '<div><strong>' + escape(data.text) + '</strong></div>'; }")
    .Item("renderSelectedItem")
    .NoResults("function(data, escape) { return '<div>No matches for ' + escape(data.input) + '</div>'; }"))
```

Available template methods: `Option`, `Item`, `OptionCreate`, `OptgroupHeader`, `Optgroup`, `NoResults`, `NotLoading`, `Loading`, `Dropdown`, `LoadingMore`, `NoMoreResults`. Use `Set(name, null)` to explicitly disable a template where Tom Select supports it. Functions must return a single root element or an appropriate DOM node. Use the provided `escape` function for user-supplied text.

For further plugin-specific behavior and available settings, consult the [upstream plugin examples](https://tom-select.js.org/plugins/).
