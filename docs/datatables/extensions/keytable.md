---
icon: material/menu-right
---

!!! info "Reference [:octicons-link-external-16:](https://datatables.net/extensions/keytable/)"
	Spreadsheet navigation of a DataTable makes for an attractive and rapid data input interface, 
	and also a very familiar one for those users experienced in Excel, OpenOffice or similar, who are now transitioning to web based apps.
	
	KeyTable adds keyboard navigation to DataTables, operating in exactly the same way as traditional spreadsheet applications.

Enable the KeyTable extension for DataTables.
[:octicons-link-external-16:](https://datatables.net/reference/option/keys)
```csharp
.KeyTable(true)
```
Or, configure it.
```csharp
.KeyTable(kt => kt.Blurable(false).Clipboard(false))
```

## Blurable
Allow KeyTable's focus to be blurred (removed) from a table.
[:octicons-link-external-16:](https://datatables.net/reference/option/keys.blurable)
```csharp
.Blurable(false)
```

## ClassName
Set the class name used for the focused cell.
[:octicons-link-external-16:](https://datatables.net/reference/option/keys.className)
```csharp
.ClassName("highlight")
```

## Clipboard
Enable / disable clipboard interaction with KeyTable.
[:octicons-link-external-16:](https://datatables.net/reference/option/keys.clipboard)
```csharp
.Clipboard(false)
```

## ClipboardOrthogonal
Set the orthogonal data to copy to clipboard.
[:octicons-link-external-16:](https://datatables.net/reference/option/keys.clipboardOrthogonal)
```csharp
.ClipboardOrthogonal("export")
```

## Columns
Select the columns that can gain focus.
[:octicons-link-external-16:](https://datatables.net/reference/option/keys.columns)
```csharp
.Columns(":not(:last-child)")
```

## EditOnFocus
Control if editing should be activated immediately upon focus.
[:octicons-link-external-16:](https://datatables.net/reference/option/keys.editOnFocus)
```csharp
.EditOnFocus(true)
```

## Editor
Attach an Editor instance for Excel like editing.
[:octicons-link-external-16:](https://datatables.net/reference/option/keys.editor)
```csharp
.Editor("editor")
```

## Focus
Cell to receive initial focus in the table.
[:octicons-link-external-16:](https://datatables.net/reference/option/keys.focus)
```csharp
.Focus(":eq(0)")
```

## Keys
Limit the keys that KeyTable will listen for and take action on.
[:octicons-link-external-16:](https://datatables.net/reference/option/keys.keys)
```csharp
.Keys(0, 1)
```

## TabIndex
Set the table's tab index for when it will receive focus.
[:octicons-link-external-16:](https://datatables.net/reference/option/keys.tabIndex)
```csharp
.TabIndex(-1)
```

