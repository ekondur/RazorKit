---
icon: material/menu-right
---

!!! info "Reference [:octicons-link-external-16:](https://datatables.net/extensions/buttons/)"
	A common UI paradigm to use with interactive tables is to present buttons that will trigger some action - that may be to alter the table's state, 
	modify the data in the table, gather the data from the table or even to activate some external process. 
	Showing such buttons is an interface that end users are comfortable with, making them feel at home with the table.

Use built-in buttons:
[:octicons-link-external-16:](https://datatables.net/reference/option/buttons.buttons)
```csharp
.Buttons("copy", "csv", "print")
```
Or, configure it:
```csharp
.Button(b => b.Text("Report").Action("getReport"))
```

## Action
Action to take when the button is activated.
[:octicons-link-external-16:](https://datatables.net/reference/option/buttons.buttons.action)
```csharp
.Action("actionName")
```

## Async
Indicate that a button's action processing should be performed asynchronously.
[:octicons-link-external-16:](https://datatables.net/reference/option/buttons.buttons.async)
```csharp
.Async(100)
```

## Attr
Collection of attribute key / values to set for a button
[:octicons-link-external-16:](https://datatables.net/reference/option/buttons.buttons.attr)
```csharp
.Attr("Title", "id")
```

## Available
Ensure that any requirements have been satisfied before initialising a button.
[:octicons-link-external-16:](https://datatables.net/reference/option/buttons.buttons.available)
```csharp
.Available("functionName")
```

## ClassName
Set the class name for the button.
[:octicons-link-external-16:](https://datatables.net/reference/option/buttons.buttons.className)
```csharp
.ClassName("copyButton")
```

## Destroy
Function that is called when the button is destroyed.
[:octicons-link-external-16:](https://datatables.net/reference/option/buttons.buttons.destroy)
```csharp
.Destroy("functionName")
```

## DropIcon
Show a dropdown (further action) icon.
[:octicons-link-external-16:](https://datatables.net/reference/option/buttons.buttons.dropIcon)
```csharp
.DropIcon(true)
```

## Enabled
Set a button's initial enabled state.
[:octicons-link-external-16:](https://datatables.net/reference/option/buttons.buttons.enabled)
```csharp
.Enabled(false)
```

## Extend
Define which button type the button should be based on.
[:octicons-link-external-16:](https://datatables.net/reference/option/buttons.buttons.extend)
```csharp
.Extend("excel")
```

## Init
Initialisation function that can be used to add events specific to this button.
[:octicons-link-external-16:](https://datatables.net/reference/option/buttons.buttons.init)
```csharp
.Init("functionName")
```

## Key
Define an activation key for a button.
[:octicons-link-external-16:](https://datatables.net/reference/option/buttons.buttons.key)
```csharp
.Key("p")
```
```csharp
.Key("p", altKey: true)
```

## Name
Set a name for each selection.
[:octicons-link-external-16:](https://datatables.net/reference/option/buttons.buttons.name)
```csharp
.Name("copy")
```

## Namespace
Unique namespace for every button.
[:octicons-link-external-16:](https://datatables.net/reference/option/buttons.buttons.namespace)
```csharp
.Namespace("example")
```

## Split
Split dropdown buttons (built-in).
[:octicons-link-external-16:](https://datatables.net/reference/option/buttons.buttons.split)
```csharp
.Split("copy", "csv", "print")
```

Split dropdown buttons with configuration.
```csharp
.Split(x => x.Add("pdf", "report").Add("word", "report"))
```

## Buttons
Dropdown buttons (built-in).
[:octicons-link-external-16:](https://datatables.net/reference/option/buttons.buttons.split)
```csharp
.Buttons("copy", "csv", "print")
```
Dropdown buttons with configuration.
```csharp
.Buttons(x => x.Add("pdf", "report").Add("word", "report"))
```

## Tag
Set the tag for the button.
[:octicons-link-external-16:](https://datatables.net/reference/option/buttons.buttons.tag)
```csharp
.Tag("a")
```

## Text
The text to show in the button.
[:octicons-link-external-16:](https://datatables.net/reference/option/buttons.buttons.text)
```csharp
.Text("Print")
```

## TitleAttr
Button title attribute text.
[:octicons-link-external-16:](https://datatables.net/reference/option/buttons.buttons.titleAttr)
```csharp
.TitleAttr("Copy")
```

