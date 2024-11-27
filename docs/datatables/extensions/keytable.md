## Blurable
Allow KeyTable's focus to be blurred (removed) from a table.
```csharp
.Blurable(true)
```

## ClassName
Set the class name used for the focused cell.
```csharp
.ClassName("example")
```

## Clipboard
Enable / disable clipboard interaction with KeyTable.
```csharp
.Clipboard(true)
```

## ClipboardOrthogonal
Set the orthogonal data to copy to clipboard.
```csharp
.ClipboardOrthogonal("example")
```

## Columns
Select the columns that can gain focus.
```csharp
.Columns("example")
```

## EditOnFocus
Control if editing should be activated immediately upon focus.
```csharp
.EditOnFocus(true)
```

## Editor
Attach an Editor instance for Excel like editing.
```csharp
.Editor("example")
```

## Focus
Cell to receive initial focus in the table.
```csharp
.Focus("example")
```

## Keys
Limit the keys that KeyTable will listen for and take action on.
```csharp
.Keys(default)
```

## TabIndex
Set the table's tab index for when it will receive focus.
```csharp
.TabIndex(15)
```

