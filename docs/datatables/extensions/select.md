---
icon: material/menu-right
---

!!! info "Reference [:octicons-link-external-16:](https://datatables.net/extensions/select/)"
	Select adds item selection capabilities to a DataTable. Items can be rows, columns or cells, which can be selected independently, or together. 
	Item selection can be particularly useful in interactive tables where users can perform some action on the table, 
	such as editing rows or marking items to perform an action on.

Enable selection. [:octicons-link-external-16:](https://datatables.net/reference/option/select)
```csharp
.Select(true)
```
Or, configure it.
```csharp
.Select(s => s.Style(SelectStyle.Multi).HeaderCheckbox())
```

## ClassName
Set the class name that will be applied to selected items.
[:octicons-link-external-16:](https://datatables.net/reference/option/select.className)
```csharp
.ClassName("row-selected")
```

## Blurable
Indicate if the selected items will be removed when clicking outside of the table.
[:octicons-link-external-16:](https://datatables.net/reference/option/select.blurable)
```csharp
.Blurable(true)
```

## HeaderCheckbox
Control automatic addition of header checkbox.
[:octicons-link-external-16:](https://datatables.net/reference/option/select.headerCheckbox)
```csharp
.HeaderCheckbox()
```
Limit with page selection.
```csharp
.HeaderCheckbox(selectPage: true)
```

## Info
Enable / disable the display for item selection information in the table summary.
[:octicons-link-external-16:](https://datatables.net/reference/option/select.info)
```csharp
.Info(false)
```

## Items
Set which table items to select (rows, columns or cells).
[:octicons-link-external-16:](https://datatables.net/reference/option/select.items)
```csharp
.Items(SelectItems.Row)
```

## Selector
Set the element selector used for mouse event capture to select items.
[:octicons-link-external-16:](https://datatables.net/reference/option/select.selector)
```csharp
.Selector("td:first-child")
```

## Style
Set the selection style for end user interaction with the table.
[:octicons-link-external-16:](https://datatables.net/reference/option/select.style)
```csharp
.Style(SelectStyle.Multi)
```

## Toggleable
Disable the deselection of selected rows when clicked.
[:octicons-link-external-16:](https://datatables.net/reference/option/select.toggleable)
```csharp
.Toggleable(false)
```

## Selectable
Set a function that will determine if a row should be selectable.
[:octicons-link-external-16:](https://datatables.net/reference/option/select.selectable)
```csharp
.Selectable("selectAction")
```

