
!!! note "Configuration [:octicons-link-external-16:](https://datatables.net/reference/option/language)"
	All strings that DataTables uses in its user interface are defined in this object, allowing you to modified them individually or completely replace them all as required. 
	This ensures that DataTables is fully internationalisable as strings for any language can be used.
	
	```csharp
	.Language(l => l.Search("Search By: ").EmptyTable("No records"))
	```
	
	The following is the default object that DataTables uses for its language strings (for information about each individual parameter, please see its individual documentation document):
	```json linenums="1"
		{
		"decimal":        "",
		"emptyTable":     "No data available in table",
		"info":           "Showing _START_ to _END_ of _TOTAL_ entries",
		"infoEmpty":      "Showing 0 to 0 of 0 entries",
		"infoFiltered":   "(filtered from _MAX_ total entries)",
		"infoPostFix":    "",
		"thousands":      ",",
		"lengthMenu":     "Show _MENU_ entries",
		"loadingRecords": "Loading...",
		"processing":     "",
		"search":         "Search:",
		"zeroRecords":    "No matching records found",
		"paginate": {
			"first":      "First",
			"last":       "Last",
			"next":       "Next",
			"previous":   "Previous"
		},
		"aria": {
			"orderable":  "Order by this column",
			"orderableReverse": "Reverse order this column"
		}
	}
	```

## Decimal
Set the decimal place character. [:octicons-link-external-16:](https://datatables.net/reference/option/language.decimal)
```csharp
.Decimal(",")
```

## EmptyTable
This string is shown when the table is empty of data (regardless of filtering). [:octicons-link-external-16:](https://datatables.net/reference/option/language.emptyTable)
```csharp
.EmptyTable("No data available in table")
```

## Info
This string gives information to the end user about the information that is current on display on the page. [:octicons-link-external-16:](https://datatables.net/reference/option/language.info)
```csharp
.Info("Showing page _PAGE_ of _PAGES_")
```

## InfoEmpty
Display information string for when the table is empty. [:octicons-link-external-16:](https://datatables.net/reference/option/language.infoEmpty)
```csharp
.InfoEmpty("No entries to show")
```

## InfoFiltered
When a user filters the information in a table, this string is appended to the information (info) to give an idea of how strong the filtering is. [:octicons-link-external-16:](https://datatables.net/reference/option/language.infoFiltered)
```csharp
.InfoFiltered(" - filtered from _MAX_ records")
```

## InfoPostFix
If can be useful to append extra information to the info string at times, and this variable does exactly that. [:octicons-link-external-16:](https://datatables.net/reference/option/language.infoPostFix)
```csharp
.InfoPostFix("All records shown are derived from real information.")
```

## Thousands
The thousands separator option is used for output of information only. [:octicons-link-external-16:](https://datatables.net/reference/option/language.thousands)
```csharp
.Thousands(".")
```

## LengthMenu
Detail the action that will be taken when the drop down menu for the pagination length option is changed. [:octicons-link-external-16:](https://datatables.net/reference/option/language.lengthMenu)
```csharp
.LengthMenu("Display _MENU_ records")
```

## LoadingRecords
This message is shown in an empty row in the table to indicate to the end user the the data is being loaded. [:octicons-link-external-16:](https://datatables.net/reference/option/language.loadingRecords)
```csharp
.LoadingRecords("Please wait, loading...")
```

## Processing
Text that is displayed when the table is processing a user action (usually a sort command or similar). [:octicons-link-external-16:](https://datatables.net/reference/option/language.processing)
```csharp
.Processing("DataTables is currently busy")
```

## Search
Sets the string that is used for DataTables filtering input control. [:octicons-link-external-16:](https://datatables.net/reference/option/language.search)
```csharp
.Search("Filter records:")
```

## ZeroRecords
Text shown inside the table records when the is no information to be displayed after filtering. [:octicons-link-external-16:](https://datatables.net/reference/option/language.zeroRecords)
```csharp
.ZeroRecords("No records to display")
```

## Paginate
Pagination string used by DataTables for the built-in pagination control types. [:octicons-link-external-16:](https://datatables.net/reference/option/language.paginate)
```csharp
.Paginate("first", "last", "next", "previous")
```

## Aria
Language strings used for WAI-ARIA specific attributes. [:octicons-link-external-16:](https://datatables.net/reference/option/language.aria)
```csharp
.Aria(": Sort this column", ": Reverse sort this column")
```

