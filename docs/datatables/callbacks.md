!!! note "Reference [:octicons-link-external-16:](https://datatables.net/reference/option/?extn=DataTables%20-%20Callbacks)"
	In jQuery DataTables, "callbacks" refer to functions that are executed at specific points in the DataTable's lifecycle or during user interaction. 
	These callbacks allow you to customize behavior, process data, or manipulate the table during various events, such as data loading, drawing, or user interaction.
	Callbacks give you precise control over the table's behavior and allow you to:
	
	- Manipulate data dynamically.
	- Customize table appearance or behavior.
	- Integrate additional features like custom search or row highlighting.

Callbacks configuration:
```csharp
.Callbacks(x => x.CreatedRow("createdRow").InitComplete("initComplete"))
```
```javascript
function initComplete() {
    console.log('Table initialization complete!');
}
```
```javascript
function createdRow (row, data, dataIndex) {
    if (data[4] === "Admin") {
        $(row).addClass('highlight');
    }
}
```
	
## CreatedRow
Callback for whenever a TR element is created for the table's body.
[:octicons-link-external-16:](https://datatables.net/reference/option/createdRow)
```csharp
.CreatedRow("functionName")
```

## DrawCallback
Function that is called every time DataTables performs a draw. 
[:octicons-link-external-16:](https://datatables.net/reference/option/drawCallback)
```csharp
.DrawCallback("functionName")
```

## FooterCallback
Footer display callback function.
[:octicons-link-external-16:](https://datatables.net/reference/option/footerCallback)
```csharp
.FooterCallback("functionName")
```

## FormatNumber
Number formatting callback function.
[:octicons-link-external-16:](https://datatables.net/reference/option/formatNumber)
```csharp
.FormatNumber("functionName")
```

## HeaderCallback
Header display callback function.
[:octicons-link-external-16:](https://datatables.net/reference/option/headerCallback)
```csharp
.HeaderCallback("functionName")
```

## InfoCallback
Table summary information display callback.
[:octicons-link-external-16:](https://datatables.net/reference/option/infoCallback)
```csharp
.InfoCallback("functionName")
```

## InitComplete
Initialisation complete callback.
[:octicons-link-external-16:](https://datatables.net/reference/option/initComplete)
```csharp
.InitComplete("functionName")
```

## PreDrawCallback
Pre-draw callback.
[:octicons-link-external-16:](https://datatables.net/reference/option/preDrawCallback)
```csharp
.PreDrawCallback("functionName")
```

## RowCallback
Row draw callback.
[:octicons-link-external-16:](https://datatables.net/reference/option/rowCallback)
```csharp
.RowCallback("functionName")
```

## StateLoadCallback
Callback that defines where and how a saved state should be loaded.
[:octicons-link-external-16:](https://datatables.net/reference/option/stateLoadCallback)
```csharp
.StateLoadCallback("functionName")
```

## StateLoadParams
State loaded - data manipulation callback.
[:octicons-link-external-16:](https://datatables.net/reference/option/stateLoadParams)
```csharp
.StateLoadParams("functionName")
```

## StateLoaded
State loaded callback.
[:octicons-link-external-16:](https://datatables.net/reference/option/stateLoaded)
```csharp
.StateLoaded("functionName")
```

## StateSaveCallback
Callback that defines how the table state is stored and where.
[:octicons-link-external-16:](https://datatables.net/reference/option/stateSaveCallback)
```csharp
.StateSaveCallback("functionName")
```

## StateSaveParams
State save - data manipulation callback.
[:octicons-link-external-16:](https://datatables.net/reference/option/stateSaveParams)
```csharp
.StateSaveParams("functionName")
```

