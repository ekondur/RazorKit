Command Group configuration:
```csharp
.Columns(c =>
{
    c.CommandGroup(cg => cg
		.Text("Report").BtnClass("btn btn-sm btn-secondary").Width("1%")
        .Item("Excel", "getReport")
		.Item("Pdf", "getReport"));
})
```

## Text
Set command text.
```csharp
.Text("Report")
```

## IconClass
Set icon css class.
```csharp
.IconClass("bi bi-file-pdf")
```

## BtnClass
Set button css class.
```csharp
.BtnClass("btn btn-sm btn-secondary")
```

## Width
Set percentage of column where the command is.
```csharp
.Width("1%")
```

## Item
Add a Command Group item.
```csharp
.Item("Excel", "getReport")
```

