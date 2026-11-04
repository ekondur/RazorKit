# RazorKit.TomSelect

Fluent Razor helpers for [Tom Select](https://tom-select.js.org/), targeting ASP.NET MVC 5 (.NET Framework 4.8) and ASP.NET Core MVC (.NET 8 / .NET 10).

```powershell
Install-Package RazorKit.TomSelect
```

Load Tom Select's CSS and JavaScript yourself. The example application and browser tests use **Tom Select 2.6.2**, with locally stored assets.

```html
<link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/tom-select@2.6.2/dist/css/tom-select.default.min.css" />
<script src="https://cdn.jsdelivr.net/npm/tom-select@2.6.2/dist/js/tom-select.complete.min.js"></script>
```

```cshtml
@using RazorKit

@(Html.TomSelectFor(m => m.CategoryId)
    .Options(o => o.Add("1", "Books").Add("2", "Music"))
    .Placeholder("Choose a category")
    .Plugins(p => p.ClearButton())
    .Render())
```

`TomSelectFor` uses MVC's native select helpers, including field prefixes, validation attributes, scalar/collection binding and ModelState precedence. A collection property automatically produces a multiple select. `.Items(...)` is for unbound controls; model-bound selections come from the model or posted ModelState. Use `Html.TomSelect("tags").Multiple().Create()` for an unbound tag editor.

## Remote options

```cshtml
@(Html.TomSelectFor(m => m.PersonId)
    .ValueField("id")
    .LabelField("name")
    .SearchField("name")
    .Options(Model.SelectedPeople)
    .DataSource(ds => ds
        .Url(Url.Action("Search", "People"))
        .ResultsField("results")
        .MinimumQueryLength(2))
    .Plugins(p => p.ClearButton())
    .Render())
```

The endpoint returns `{ "results": [{ "id": "42", "name": "Ada" }] }`. Supply selected records through `Options` to display their labels before the first search. Missing selected records fall back to their value as the label. Property names are preserved; match `ValueField`/`LabelField` to your data.

## Coverage

- Core selection, creation, search, sorting, grouping, appearance and loading settings.
- Weighted search fields, ordered sorting, arbitrary option/group data.
- Constructor callbacks plus `item_select`/`destroy` event handlers.
- All render templates, including virtual-scroll loading templates.
- All 14 bundled plugins, configurable through `Plugins`.
- GET/JSON POST remote data, query parameters, headers, credentials, response envelopes, groups, transforms and error handlers.
- Separate HTML/script rendering, configuration-only rendering, CSP nonces and idempotent initialization.
- `Set(name, value)` and `SetJavaScript(name, expression)` for custom or future options.

Callback strings and `JavaScript` instances are trusted executable code. Never construct them from user input. Ordinary strings and option data are HTML-safe JSON encoded. In custom render functions, use Tom Select's `escape` argument for displayed data.

Load the scripts before initialization. `Render()` initializes on DOMContentLoaded or immediately if the document is ready. Access the native runtime API through `document.getElementById('CategoryId').tomselect`; dynamic partials should execute `RenderScript()` after insertion. Dispose replaced controls with `destroy()`.

See the [full documentation](https://ekondur.github.io/RazorKit/tomselect/) and the repository's `test/Web` application for working examples.
