## Name
Default name/id is "DataTableId".
```csharp
.Name("MyDataTable")
```

## Language
Specify language json url from cdn or local. Or [configure.](../language/)
```csharp
.Language("//cdn.datatables.net/plug-ins/1.10.22/i18n/Turkish.json")
```

## FixedColumns
Enable and configure the FixedColumns extension for DataTables.
```csharp
.FixedColumns(true)
```

## LengthMenu

```csharp
.LengthMenu(lm => lm.Items(10, 25, 50, 100))
```
```csharp
.LengthMenu(lm => lm.Items(10, 25, 50, 100).ShowAll())
```
```csharp
.LengthMenu(lm => lm.Items(10, 25, 50, 100).ShowAll("All Records"))
```

## FixedHeader
Is FixedHeader enabled?
```csharp
.FixedHeader(true)
```

## ColReorder
Enable the ColReorder extension for DataTables.
```csharp
.ColReorder(true)
```

## RowReorder
Enable the RowReorder extension for DataTables.
```csharp
.RowReorder(true)
```

## KeyTable
Enable the KeyTable extension for DataTables.
```csharp
.KeyTable(true)
```

## Select
Enable selection.
```csharp
.Select(true)
```

## Buttons
Add built-in buttons.
```csharp
.Buttons(default)
```

## Ordering
Disable or enable ordering, default is true.
```csharp
.Ordering(true)
```

## Searching
Disable or enable searching, default is true.
```csharp
.Searching(true)
```

## Dom
Dom allow to control position of datatable elements
```csharp
.Dom("example")
```

## Style
Set css class of table.
```csharp
.Style("example")
```

## Paging
Disable or enable paging, default is true.
```csharp
.Paging(true)
```

## ServerSide
Enable server-side processing mode.
```csharp
.ServerSide(true)
```

## PageLength
Define table page length.
```csharp
.PageLength(15)
```

## Processing
Enable or disable the display of a 'processing' indicator when the table is being processed, Default is true.
```csharp
.Processing(true)
```

## ScrollX
Enable horizontal scrolling. When a table is too wide to fit into a certain layout, or you have a large number of columns in the table, you can enable horizontal (x) scrolling to show the table in a viewport, which can be scrolled.
```csharp
.ScrollX(true)
```

## StateSave
Enable or disable state saving such as pagination position, display length, filtering and sorting information.
```csharp
.StateSave(true)
```

## Caption
Set a caption for the table.
```csharp
.Caption("example")
```

## Responsive
Enable the Responsive extension for DataTables.
```csharp
.Responsive(true)
```
