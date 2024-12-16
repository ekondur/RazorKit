---
icon: material/menu-right
---

!!! info "Reference [:octicons-link-external-16:](https://datatables.net/extensions/rowgroup/)"
	The ability to group rows in a table can let an end user quickly and easily see the structure of the data shown, 
	and also present them with summaries of the data shown in each group. 
	RowGroup adds this ability to DataTables with the ability to customise the start and end grouping rows displayed in the DataTable, 
	letting you integrate the summarised data to fit perfectly in with your site.

Enable the RowGroup extension for DataTables.
[:octicons-link-external-16:](https://datatables.net/reference/option/rowGroup)
```csharp
.RowGroup(true)
```
Or, configure it.
```csharp
.RowGroup(rg => rg.DataSrc("age").ClassName("table-group"))
```

## ClassName
Set the class name to be used for the grouping rows.
[:octicons-link-external-16:](https://datatables.net/reference/option/rowGroup.className)
```csharp
.ClassName("table-group")
```

## DataSrc
Set the data point to use as the grouping data source.
[:octicons-link-external-16:](https://datatables.net/reference/option/rowGroup.dataSrc)
```csharp
.DataSrc(2)
```
```csharp
.DataSrc("age")
```
```csharp
.DataSrc("age", "name")
```

## EmptyDataGroup
Text to show for rows which have null, undefined or empty string group data.
[:octicons-link-external-16:](https://datatables.net/reference/option/rowGroup.emptyDataGroup)
```csharp
.EmptyDataGroup("No categories assigned yet")
```

## Enable
Provides the ability to disable row grouping at initialisation.
[:octicons-link-external-16:](https://datatables.net/reference/option/rowGroup.enable)
```csharp
.Enable(false)
```

## EndClassName
Set the class name to be used for the grouping end rows.
[:octicons-link-external-16:](https://datatables.net/reference/option/rowGroup.endClassName)
```csharp
.EndClassName("table-end-group")
```

## EndRender
Provide a function that can be used to control the data shown in the end grouping row.
[:octicons-link-external-16:](https://datatables.net/reference/option/rowGroup.endRender)
```csharp
.EndRender("functionName")
```

## StartClassName
Set the class name to be used for the grouping start rows.
[:octicons-link-external-16:](https://datatables.net/reference/option/rowGroup.startClassName)
```csharp
.StartClassName("table-start-group")
```

## StartRender
Provide a function that can be used to control the data shown in the start grouping row.
[:octicons-link-external-16:](https://datatables.net/reference/option/rowGroup.startRender)
```csharp
.StartRender("functionName")
```

