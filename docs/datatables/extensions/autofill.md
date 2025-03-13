---
icon: material/menu-right
---

!!! info "Reference [:octicons-link-external-16:](https://datatables.net/extensions/autofill/)"
	Spreadsheets such as Excel and Google Docs have a very handy data duplication option of an auto fill tool. 
	The AutoFill library for DataTables provides a similar interface for DataTables and extends upon this interface
	paradigm to provide complex data interaction options that the user can select between.

Enable the AutoFill extension for DataTables.
[:octicons-link-external-16:](https://datatables.net/reference/option/?extn=autofill)
```csharp
.AutoFill(true)
```
Or, configure it.
```csharp
.AutoFill(af => af.AlwaysAsk(false).Columns(":not(:last-child)"))
```

## AlwaysAsk
Always ask the end user if an action should be taken or not. Default ```false```
[:octicons-link-external-16:](https://datatables.net/reference/option/autoFill.alwaysAsk)

- ```false``` - Proceed with the fill, without asking the end user if there is only one option.
- ```true``` - Always ask the end user, before doing the fill, even if there is only one option.

```csharp
.AlwaysAsk(true)
```

## Columns
Select the columns that can be auto filled.
[:octicons-link-external-16:](https://datatables.net/reference/option/autoFill.columns)
```csharp
.Columns(":not(:last-child)")
```

## Editor
Attach an Editor instance for database updating. Default ```null```
[:octicons-link-external-16:](https://datatables.net/reference/option/autoFill.editor)
```csharp
.Editor("editor")
```

## Enable
Initial enablement state of AutoFill. Default ```true```
[:octicons-link-external-16:](https://datatables.net/reference/option/autoFill.enable)

- ```true``` - AutoFill is enabled when the DataTable is created.
- ```false``` - AutoFill is not enabled, and can later be enabled via the API.

```csharp
.Enable(false)
```

## Focus
Action that will cause the auto fill drag handle to appear in a cell. Default ```null```
[:octicons-link-external-16:](https://datatables.net/reference/option/autoFill.focus)

- ```click``` - Display when a cell is clicked upon.
- ```focus``` - Display when a cell gains focus - for integration with KeyTable.
- ```hover``` - Display when a cell is hovered over.
- ```null``` - Automatic detection - focus if KeyTable is enabled on a table and hover otherwise.

```csharp
.Focus("click")
```

## Horizontal
Enable / disable user ability to horizontally drag and fill. Default ```true```
[:octicons-link-external-16:](https://datatables.net/reference/option/autoFill.horizontal)

- ```true``` - Horizontal drag and fill is enabled.
- ```false``` - Horizontal drag and fill is disabled.

```csharp
.Horizontal(false)
```

## Update
Control automatic update of data when a fill drag is completed. Default ```true```
[:octicons-link-external-16:](https://datatables.net/reference/option/autoFill.update)

- ```true``` - DataTables data is automatically updated as a result of the auto fill action and the table redrawn.
- ```false``` - No data update or draw is performed.

```csharp
.Update(false)
```

## Vertical
Enable / disable user ability to vertically drag and fill. Default ```true```
[:octicons-link-external-16:](https://datatables.net/reference/option/autoFill.vertical)

- ```true``` - vertical drag and fill is enabled.
- ```false``` - vertical drag and fill is disabled.

```csharp
.Vertical(false)
```

