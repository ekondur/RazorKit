---
icon: material/code-json
---

# Configuration

Methods use the upstream [Tom Select settings](https://tom-select.js.org/docs/) names in PascalCase. Unset settings are omitted, allowing Tom Select to apply its defaults. Explicit `false` and `null` values are preserved.

| Category | Fluent methods |
|---|---|
| Selection | `MaxItems`, `MaxOptions`, `Mode`, `Items`, `HideSelected`, `Duplicates`, `AllowEmptyOption`, `CloseAfterSelect`, `ClearAfterSelect`, `SelectOnTab` |
| Creation and paste | `Create(bool/string)`, `CreateOnBlur`, `CreateFilter(string/JavaScript)`, `Persist`, `AddPrecedence`, `Delimiter`, `SplitOn(string/JavaScript)` |
| Search | `SearchField`, `SearchConjunction`, `SortField`, `Score`, `Diacritics`, `Highlight`, `Nesting`, `RefreshThrottle` |
| Data | `Options`, `Optgroups`, `DataAttr`, `ValueField`, `LabelField`, `DisabledField`, `OptgroupField`, `OptgroupValueField`, `OptgroupLabelField`, `OptionGroupRegister`, `LockOptgroupOrder` |
| Loading | `DataSource`, `Load`, `ShouldLoad`, `LoadThrottle`, `Preload`, `PreloadOnFocus`, `LoadingClass` |
| Appearance | `Placeholder`, `HidePlaceholder`, `OpenOnFocus`, `ShouldOpen`, `DropdownParent`, `ControlInput`, `CopyClassesToDropdown` |
| CSS classes | `WrapperClass`, `ControlClass`, `DropdownClass`, `DropdownContentClass`, `ItemClass`, `OptionClass` |
| Virtual scrolling | `FirstUrl`, `ShouldLoadMore`, `Load`, `Plugins(p => p.VirtualScroll())` |
| HTML | `Id`, `Multiple`, `Disabled`, `Required`, `Attribute`, `HtmlAttributes`, `ScriptNonce` |

`MaxItems(null)` and `MaxOptions(null)` remove limits; `LoadThrottle(null)` disables load throttling. `ControlInput(null)` disables text entry. `Mode` accepts `single`/`multi`; `SearchConjunction` accepts `and`/`or`. For collection binding use a collection model property or `Multiple()` on an unbound helper; `Mode` alone does not change form semantics.

## Weighted search and sorting

```csharp
.SearchField(fields => fields.Add("name", 2).Add("description", 0.5))
.SortField(fields => fields.Add("$score", "desc").Add("name", "asc"))
.SearchConjunction("and")
```

`SearchField()` with no arguments disables local filtering, useful with server-ranked results. `SortField(new JavaScript("customSort"))` accepts an upstream sort function.

## Groups

```csharp
.Optgroups(groups => groups.Add("web", "Web").Add("systems", "Systems"))
.Options(options => options
    .Add("js", "JavaScript", "web")
    .Add("rs", "Rust", "systems")
    .Add("cpp", "C++", "systems", disabled: true))
.LockOptgroupOrder()
```

For additional option metadata or multiple group membership, use `Options(IEnumerable<T>)` and supply custom objects. Use the corresponding group mapping methods when your property names differ from Tom Select's defaults.

## Callbacks

```csharp
.Callbacks(callbacks => callbacks
    .OnChange("function(value) { console.log(value); }")
    .OnDelete("function(values) { return confirm('Remove selection?'); }")
    .OnInitialize("onSelectReady"))
```

Available callbacks: `OnInitialize`, `OnFocus`, `OnBlur`, `OnChange`, `OnItemAdd`, `OnItemRemove`, `OnItemSelect`, `OnClear`, `OnDelete`, `OnOptionAdd`, `OnOptionRemove`, `OnOptionClear`, `OnOptionGroupAdd`, `OnOptionGroupRemove`, `OnOptionGroupClear`, `OnDropdownOpen`, `OnDropdownClose`, `OnType`, `OnLoad`, `OnDestroy`. `OnItemSelect` and `OnDestroy` are registered through the instance event API after construction and therefore are not included in configuration-only output.

## Extension points and executable expressions

```csharp
.Set("futureOption", new { enabled = true })
.SetJavaScript("customCallback", "myCallback")
.SplitOn(new JavaScript("/[,;]+/"))
.CreateFilter(new JavaScript("function(input) { return input.length > 2; }"))
```

Import `RazorKit.TomSelect` for `JavaScript`. Only callbacks, `SetJavaScript`, and explicit `JavaScript` objects emit executable expressions; ordinary strings remain encoded JSON. Never pass untrusted input into executable expressions. HTML script delimiters in raw code are rejected; escape them inside JavaScript string literals if required. Custom render functions must escape displayed data themselves.
