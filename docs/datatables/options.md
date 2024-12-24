---
icon: material/code-json
---

!!! info "Reference [:octicons-link-external-16:](https://datatables.net/reference/option/)"
	DataTables and its extensions are extremely configurable libraries and almost every aspect of the enhancements they make to HTML tables can be customised. 
	Features can be enabled, disabled or customised to meet your exact needs for your table implementations.

## Name
Default name/id is ```"DataTableId"```.
```csharp
.Name("MyDataTable")
```
If there are multiple grid in single page, different names should be given. Call grid if you need like this:
```javascript
$(document).ready(function() {
	var table = $('#MyDataTable').DataTable();
});
```

## Ordering
Disable or enable ordering, default is ```true```. 
[:octicons-link-external-16:](https://datatables.net/reference/option/ordering)
```csharp
.Ordering(true)
```

## Orders
If ordering is enabled (ordering), then DataTables will perform a first pass order during initialisation. 
Using this parameter you can define which column(s) the order is performed upon, and the ordering direction.
```csharp
.Orders(o => {
    o.Add(p => p.Name, OrderBy.Descending);
    o.Add(p => p.Age, OrderBy.Ascending);
})
```

## Searching
Disable or enable searching, default is ```true```. 
[:octicons-link-external-16:](https://datatables.net/reference/option/searching)
```csharp
.Searching(true)
```

## Dom
Dom allow to control position of datatable elements. 
[:octicons-link-external-16:](https://datatables.net/reference/option/dom)
```csharp
.Dom("lrtip")
```

## Style
Set css class of table, default is ```"display dataTable"```.
```csharp
.Style("table table-striped")
```

## Paging
Disable or enable paging, default is ```true```. 
[:octicons-link-external-16:](https://datatables.net/reference/option/paging)
```csharp
.Paging(true)
```

## Render
The Render method finalizes the control configuration and outputs the necessary HTML and scripts for the control.
```csharp
.Render()
```
It is possible to separate script and HTML rendering.
```csharp
.RenderHtml()
```
```csharp
.RenderScript()
```

## ServerSide
Enable server-side processing mode, default is ```false```. 
[:octicons-link-external-16:](https://datatables.net/reference/option/serverSide)
```csharp
.ServerSide(true)
```

## PageLength
Define table page length. default is ```10```. 
[:octicons-link-external-16:](https://datatables.net/reference/option/pageLength)
```csharp
.PageLength(20)
```

## Processing
Enable or disable the display of a 'processing' indicator when the table is being processed, default is ```true```. 
[:octicons-link-external-16:](https://datatables.net/reference/option/processing)
```csharp
.Processing(true)
```

## ScrollX
Enable horizontal scrolling. When a table is too wide to fit into a certain layout, or you have a large number of columns in the table, 
you can enable horizontal (x) scrolling to show the table in a viewport, which can be scrolled, default is ```false```. 
[:octicons-link-external-16:](https://datatables.net/reference/option/scrollX)
```csharp
.ScrollX(true)
```

## StateSave
Enable or disable state saving such as pagination position, display length, filtering and sorting information, default is ```false```.
[:octicons-link-external-16:](https://datatables.net/reference/option/stateSave)
```csharp
.StateSave(true)
```

## Caption
Set a caption for the table.
[:octicons-link-external-16:](https://datatables.net/reference/option/caption)
```csharp
.Caption("Table 1: Pupil averages")
```

## LengthMenu
Change the options in the page length select list.
```csharp
.LengthMenu(lm => lm.Items(10, 25, 50, 100))
```
```csharp
.LengthMenu(lm => lm.Items(10, 25, 50, 100).ShowAll())
```
```csharp
.LengthMenu(lm => lm.Items(10, 25, 50, 100).ShowAll("All Records"))
```