!!! note "Reference [:octicons-link-external-16:](https://datatables.net/extensions/rowreorder/)"
	DataTables is often used to show sequential data, and naturally from that comes the desire to be able to reorder that
	data - for this the RowReorder extension is available. It provides the end user with the ability to click and drag
	(or touch and drag on mobile devices) a row in the table and change its position. 
	Full integration with Editor's multi-row editing abilities is also available to have updates automatically written to a database.

Enable the RowReorder extension for DataTables.
[:octicons-link-external-16:](https://datatables.net/reference/option/rowReorder)
```csharp
.RowReorder(true)
```
Or, configure it.
```csharp
.RowReorder(r => r.DataSrc("sequence").Editor("editor"))
```

## Cancelable
Enable / disable the canceling of the drag and drop interaction.
[:octicons-link-external-16:](https://datatables.net/reference/option/rowReorder.cancelable)
```csharp
.Cancelable(false)
```

## DataSrc
Configure the data point that will be used for the reordering data.
[:octicons-link-external-16:](https://datatables.net/reference/option/rowReorder.dataSrc)
```csharp
.DataSrc("sequence")
```

## Editor
Attach an Editor instance for database updating.
[:octicons-link-external-16:](https://datatables.net/reference/option/rowReorder.editor)
```csharp
.Editor("editor")
```

## Enable
Enable / disable RowReorder's user interaction.
[:octicons-link-external-16:](https://datatables.net/reference/option/rowReorder.enable)
```csharp
.Enable(false)
```

## FormOptions
Set the options for the Editor form when submitting data.
[:octicons-link-external-16:](https://datatables.net/reference/option/rowReorder.formOptions)
```csharp
.FormOptions("allIfChanged")
```

## Selector
Define the selector used to pick the elements that will start a drag.
[:octicons-link-external-16:](https://datatables.net/reference/option/rowReorder.selector)
```csharp
.Selector("td:last-child")
```

## SnapX
Horizontal position control of the row being dragged.
[:octicons-link-external-16:](https://datatables.net/reference/option/rowReorder.snapX)
```csharp
.SnapX(true)
```

## Update
Control automatic of data when a row is dropped.
[:octicons-link-external-16:](https://datatables.net/reference/option/rowReorder.update)
```csharp
.Update(false)
```

