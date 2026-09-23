---
icon: material/layers-outline
---

!!! info "Reference [:octicons-link-external-16:](https://datatables.net/reference/option/layout)"
	The layout option provides the ability to control the items that surround and control the DataTable. 
	While offering a wide range of options to control the layout around the table, the basic operation of this option is quite simple:
	use the object parameter name to place a control and then the value to state what feature should be shown, and its configuration.
	
```csharp
.Layout(x => x
	.Set("bottomEnd", "paging")
	.Set("bottomStart", null)
	.Top("info", "div"))
```

## Position

Configure buttons and the search input at a layout position. Built-in buttons can
be added before or after custom buttons.

```csharp
.Search(search => search.Return(true).Smart(true))
.Layout(layout => layout
    .Position("topStart", position => position
        .Buttons("copy", "excel")
        .Button(button => button.Text("Refresh").Action("function(e, dt) { dt.ajax.reload(); }")))
    .Position("topEnd", position => position
        .Search(search => search.Placeholder("Search records..."))))
```

Layout search uses `LayoutSearchOptionsBuilder` for input presentation.
Use the table's `Search(...)` method for `Return`, `DefaultSearch`,
`CaseInsensitive`, `Regex`, `Boundary`, and `Smart`.
DataTables reads these behavior options from the root `search` object.

If migrating from the shared `SearchOptionsBuilder`, move behavior options out
of layout search callbacks and move `Placeholder(...)` into layout search.
Explicitly typed layout callbacks should use `LayoutSearchOptionsBuilder`.

## Set
Set a new position for feature.
```csharp
.Set("bottomEnd", "paging")
```
Or, disable a feature.
```csharp
.Set("bottomStart", null)
```

## Top
Positions elements above the table but centers them horizontally. 
This layout places the controls centered at the top of the table.
```csharp
.Top("pageLength", "search")
```

## Bottom
Positions elements above the table but centers them horizontally. 
This layout places the controls centered at the bottom of the table.
```csharp
.Bottom("info", "paging")
```

