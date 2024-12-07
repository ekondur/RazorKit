!!! note "Reference [:octicons-link-external-16:](https://datatables.net/reference/option/layout)"
	The layout option provides the ability to control the items that surround and control the DataTable. 
	While offering a wide range of options to control the layout around the table, the basic operation of this option is quite simple:
	use the object parameter name to place a control and then the value to state what feature should be shown, and its configuration.

## Top
Positions elements above the table but centers them horizontally. 
This layout places the controls centered at the top of the table.
```csharp
.Top(Layouts.PageLength, Layouts.Search)
```

## Bottom
Positions elements above the table but centers them horizontally. 
This layout places the controls centered at the bottom of the table.
```csharp
.Bottom(Layouts.Info, Layouts.Paging)
```

## TopStart

```csharp
.TopStart(Layouts.PageLength)
```

## TopEnd

```csharp
.TopEnd(Layouts.Search)
```

## BottomStart

```csharp
.BottomStart(Layouts.Info)
```

## BottomEnd

```csharp
.BottomEnd(Layouts.Paging)
```

