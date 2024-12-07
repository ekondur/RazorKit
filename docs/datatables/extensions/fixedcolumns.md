!!! note "Reference [:octicons-link-external-16:](https://datatables.net/extensions/fixedColumns/)"
	When making use of DataTables' x-axis scrolling feature (```scrollX```), you may wish to fix the left or right most columns in place.
	This extension for DataTables provides exactly this option (for non-scrolling tables, please use the FixedHeader extension,
	which will create sticky headers and footers for tables).

Enable the FixedColumns extension for DataTables.
[:octicons-link-external-16:](https://datatables.net/reference/option/fixedColumns)
```csharp
.FixedColumns(true)
```
Or, configure it.
```csharp
.FixedColumns(f => f.Start(0).End(1))
```

## Start
Number of columns to fix to the start of the table.
[:octicons-link-external-16:](https://datatables.net/reference/option/fixedColumns.start)
```csharp
.Start(0)
```

## End
Number of columns to fix to the end of the table.
[:octicons-link-external-16:](https://datatables.net/reference/option/fixedColumns.end)
```csharp
.End(1)
```

## Left
Number of columns to fix to the left of the table.
[:octicons-link-external-16:](https://datatables.net/reference/option/fixedColumns.left)
```csharp
.Left(2)
```

## Right
Number of columns to fix to the right of the table.
[:octicons-link-external-16:](https://datatables.net/reference/option/fixedColumns.right)
```csharp
.Right(1)
```

## LeftColumns
Number of columns to fix to the left of the table.
[:octicons-link-external-16:](https://datatables.net/reference/option/fixedColumns.leftColumns)
```csharp
.LeftColumns(2)
```

## RightColumns
Number of columns to fix to the right of the table.
[:octicons-link-external-16:](https://datatables.net/reference/option/fixedColumns.rightColumns)
```csharp
.RightColumns(1)
```

