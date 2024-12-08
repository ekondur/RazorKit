!!! info "Reference [:octicons-link-external-16:](https://datatables.net/extensions/colreorder/)"
	ColReorder adds the ability for the end user to be able to reorder columns in a DataTable through a click and drag operation.
	This can be useful when presenting data in a table, letting the user move columns that they wish to compare next to each other for easier comparison.

Enable the ColReorder extension for DataTables.
[:octicons-link-external-16:](https://datatables.net/reference/option/colReorder)
```csharp
.ColReorder(true)
```
Or, configure it.
```csharp
.ColReorder(x => x.Order(5, 4, 3, 2, 1, 0))
```

## Enable
Initial enablement state of ColReorder.
[:octicons-link-external-16:](https://datatables.net/reference/option/colReorder.enable)
```csharp
.Enable(true)
```

## Order
Set a default order for the columns in the table.
[:octicons-link-external-16:](https://datatables.net/reference/option/colReorder.order)
```csharp
.Order(5, 4, 3, 2, 1, 0)
```

## Columns
Select which columns can be reordered.
[:octicons-link-external-16:](https://datatables.net/reference/option/colReorder.columns)
```csharp
.Columns(":gt(1)")
```

