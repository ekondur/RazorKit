!!! note "Reference [:octicons-link-external-16:](https://datatables.net/extensions/responsive/)"
	In the modern world of responsive web design tables can often cause a particular problem for designers due to their row based layout.
	Responsive is an extension for DataTables that resolves that problem by optimising the table's layout for different screen sizes
	through the dynamic insertion and removal of columns from the table.

Enable the Responsive extension for DataTables.
[:octicons-link-external-16:](https://datatables.net/reference/option/responsive)
```csharp
.Responsive(true)
```
Or, configure it.
```csharp
.Responsive(r => r.Details(true).Orthogonal("responsive"))
```

## Orthogonal
Set the orthogonal data request type for the hidden information display.
[:octicons-link-external-16:](https://datatables.net/reference/option/responsive.orthogonal)
```csharp
.Orthogonal("responsive")
```

## Breakpoints
Configure the breakpoints for a Responsive instance.
[:octicons-link-external-16:](https://datatables.net/reference/option/responsive.breakpoints)
```csharp
.Breakpoints(b => b.Add("mobile-p", 320).Add("mobile-l", 480))
```

## Details
Enable the child rows shown by Responsive for collapsed tables.
[:octicons-link-external-16:](https://datatables.net/reference/option/responsive.details)
```csharp
.Details(true)
```
Or, configure it.

### Display
Define how the hidden information should be displayed to the end user.
[:octicons-link-external-16:](https://datatables.net/reference/option/responsive.details.display)
```csharp
.Details(d => d.Display("DataTable.Responsive.display.childRowImmediate"))
```

### Renderer
Define the renderer used to display the child rows.
[:octicons-link-external-16:](https://datatables.net/reference/option/responsive.details.renderer)
```csharp
.Details(d => d.Renderer("DataTable.Responsive.renderer.tableAll()"))
```

### Target
Column / selector for child row display control when using 'column' details type.
[:octicons-link-external-16:](https://datatables.net/reference/option/responsive.details.target)
```csharp
.Details(d => d.Target(-1))
```

### Type
Set the child row display control type.
[:octicons-link-external-16:](https://datatables.net/reference/option/responsive.details.type)
```csharp
.Details(d => d.Type(DetailType.Column))
```