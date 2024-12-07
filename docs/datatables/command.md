Command configuration:
```csharp
.Columns(c =>
{
    c.Command(c => c.IconClass("bi bi-trash").OnClick("onDelete").BtnClass("btn btn-sm btn-danger"));
    c.Command(c => c.Text("Edit").OnClick("onDelete").BtnClass("btn btn-sm btn-success"));
})
```

## Text
Set command text.
```csharp
.Text("Delete")
```

## OnClick
Set onClick function name.
```csharp
.OnClick("onDelete")
```

## IconClass
Set icon css class.
```csharp
.IconClass("bi bi-trash")
```

## BtnClass
Set button css class.
```csharp
.BtnClass("btn btn-sm btn-danger")
```

## Width
Set percentage of column where the command is.
```csharp
.Width("1%")
```

