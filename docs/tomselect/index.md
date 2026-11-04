# Tom Select

RazorKit.TomSelect brings fluent C# configuration and Razor model binding to [Tom Select](https://tom-select.js.org/). It targets MVC 5 on .NET Framework 4.8 and ASP.NET Core MVC on .NET 8 and .NET 10. Examples and browser tests use Tom Select **2.6.2**.

## Installation

```powershell
Install-Package RazorKit.TomSelect
```

Load assets in your layout before the generated initialization runs:

```html
<link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/tom-select@2.6.2/dist/css/tom-select.default.min.css" />
<script src="https://cdn.jsdelivr.net/npm/tom-select@2.6.2/dist/js/tom-select.complete.min.js"></script>
```

The complete bundle includes all bundled plugins. Assets are not injected automatically by the helper.

## Model-bound controls

```cshtml
@using RazorKit

@(Html.TomSelectFor(m => m.CategoryId)
    .Options(o => o.Add("1", "Books").Add("2", "Music"))
    .Placeholder("Choose a category")
    .Plugins(p => p.ClearButton())
    .Render())
```

The native MVC select helpers handle field names, IDs, editor prefixes, validation metadata and ModelState. A collection property automatically produces a multiple select. On a failed POST, submitted values take precedence over model values. `.Items(...)` only supplies selections for unbound controls; use the model for `TomSelectFor`. Changing `MaxItems` controls the widget's limit; it does not change whether the underlying form field is scalar or a collection.

## Unbound controls

```cshtml
@(Html.TomSelect("tags")
    .Multiple()
    .Create()
    .CreateFilter("^[A-Za-z]+$")
    .Plugins(p => p.RemoveButton().CaretPosition())
    .Render())
```

Use `Multiple()` when the field should submit repeated values. `Options` accepts arbitrary objects without renaming their properties. Configure `ValueField`, `LabelField`, `DisabledField` and group field mappings to match your data. Fluent option/group builders use the field mappings configured **before** the `Options`/`Optgroups` call.

## Rendering and lifecycle

| Method | Output |
|---|---|
| `Render()` | Select element and initialization script |
| `RenderHtml()` | Select element only |
| `RenderScript()` | Initialization wrapped in a script tag |
| `RenderScript(false)` | Initialization JavaScript for an existing script block |
| `RenderConfiguration()` | Settings JavaScript object for custom initialization |
| `ToHtml()`, `ToScript()`, `ToConfiguration()` | String equivalents |

Initialization waits for DOMContentLoaded when necessary and skips an element already initialized. Script/CSS loading remains the application's responsibility. Use `ScriptNonce(nonce)` for a CSP nonce on generated script tags. To use a custom ID, call `Id(...)`; `Attribute` and `HtmlAttributes` set other attributes while reserving `name`, `id` and `multiple` for the helper.

For dynamically inserted partials, execute initialization after inserting the HTML; dispose old instances before replacing them. The native runtime API is available directly:

```javascript
const control = document.getElementById('CategoryId').tomselect;
control.setValue('2');
control.addOption({ value: '3', text: 'Games' });
control.disable();
control.enable();
control.destroy();
```

See [configuration](configuration.md), [remote data](remote-data.md), and [plugins/templates](plugins.md). Run the repository's shared `test/Web` application for working examples.
