Configure columns:
```csharp
@(Html.DataTable<Person>()
	.Columns(c =>
	{
		c.Field(f => f.Id).Visible(false);
		c.Field(f => f.Name).Title("Name");
		c.Field(f => f.Age).Width("5%");
		c.Field(f => f.Title);
	})
...
```

!!! note "Reference [:octicons-link-external-16:](https://datatables.net/reference/option/columns)"
	The columns option in the initialisation parameter allows you to define details about the way individual columns behave. For a full list of column options that can be set, please see the related parameters below.
	
	Note that if you use columns to define your columns, you must have an entry in the array for every single column that you have in your table (these can be null if you don't wish to specify any options).

## Field
Make a column with defined type properties.
```csharp
.Field(f => f.Name)
```

## Title
Set column header. Default is property name.
[:octicons-link-external-16:](https://datatables.net/reference/option/columns.title)
```csharp
.Title("First Name")
```
Or use ```DisplayAttribute``` for properties.
```csharp
[Display(Name = "First Name")]
public string Name { get; set; }
```

## Name
Set a descriptive name for a column.
[:octicons-link-external-16:](https://datatables.net/reference/option/columns.name)
```csharp
.Name("personName")
```

## Visible
Set column visible or hidden, default is true.
[:octicons-link-external-16:](https://datatables.net/reference/option/columns.visible)
```csharp
.Visible(true)
```

## Orderable
Set column orderable or not, default is true.
[:octicons-link-external-16:](https://datatables.net/reference/option/columns.orderable)
```csharp
.Orderable(true)
```

## Searchable
Set column searchable or not, default is true.
[:octicons-link-external-16:](https://datatables.net/reference/option/columns.searchable)
```csharp
.Searchable(true)
```

## Width
This parameter can be used to define the width of a column, and may take any CSS value (10%, 3em, 20px etc).
[:octicons-link-external-16:](https://datatables.net/reference/option/columns.width)
```csharp
.Width("10%")
```

## ClassName
Set css class of column.
[:octicons-link-external-16:](https://datatables.net/reference/option/columns.className)
```csharp
.Class("text-danger")
```

## DefaultContent
Set default value for null data.
[:octicons-link-external-16:](https://datatables.net/reference/option/columns.defaultContent)
```csharp
.DefaultContent("No data")
```

## DisplayFormat
Customize datetime format with [Moment.js](https://momentjs.com/) expression.
```csharp
.DisplayFormat("DD-MMM-Y")
```
Or use ```DisplayFormatAttribute``` for properties. (needed also moment.js)
```csharp
[DisplayFormat(DataFormatString = "DD-MMM-Y")]
public DateTime? BirthDate { get; set; }
```

## Template
Customize column template using "data" for comparison.
```csharp
.Template("(data === true) ? '<span class=\"bi bi-bookmark-check-fill\"></span>' : '<span class=\"bi bi-bookmark-x\"></span>'");
```

## ContentPadding
Add padding to the text content used when calculating the optimal width for a table.
[:octicons-link-external-16:](https://datatables.net/reference/option/columns.contentPadding)
```csharp
.ContentPadding("mmm")
```

## CreatedCell
Cell created callback to allow DOM manipulation.
[:octicons-link-external-16:](https://datatables.net/reference/option/columns.createdCell)
```csharp
.CreatedCell("functionName")
```

## Footer
Set the column footer text.
[:octicons-link-external-16:](https://datatables.net/reference/option/columns.footer)
```csharp
.Footer("footer text")
```

## Type
Set the column type - used for filtering and sorting string processing.
[:octicons-link-external-16:](https://datatables.net/reference/option/columns.type)
```csharp
.Type(ColumnType.Date)
```

## ResponsivePriority
Set column's visibility priority.
[:octicons-link-external-16:](https://datatables.net/reference/option/columns.responsivePriority)
```csharp
.ResponsivePriority(1)
```

