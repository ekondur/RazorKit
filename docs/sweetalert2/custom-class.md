---
icon: material/language-css3
---

!!! info "Reference [:octicons-link-external-16:](https://sweetalert2.github.io/#customClass)"
	In SweetAlert2, ```customClass``` is a property that allows you to assign custom CSS classes to various elements of the popup. 
	This is particularly useful for customizing the appearance of a SweetAlert2 popup without directly modifying the default styles or themes.

```css
.my-popup-class {
  background-color: #f0f0f0;
  border: 2px solid #333;
}

.my-title-class {
  color: #ff0000;
  font-size: 24px;
}

.my-confirm-button-class {
  background-color: #4caf50;
  color: white;
}
```

=== "helper"
	```csharp
	.CustomClass(cs => cs
		.Title("my-title-class")
		.Popup("my-popup-class")
		.ConfirmButton("my-confirm-button-class"))
	```

=== "js output"
	```json
	customClass: {
	  container: '...',
	  popup: '...',
	  header: '...',
	  title: '...',
	  closeButton: '...',
	  icon: '...',
	  image: '...',
	  htmlContainer: '...',
	  input: '...',
	  inputLabel: '...',
	  validationMessage: '...',
	  actions: '...',
	  confirmButton: '...',
	  denyButton: '...',
	  cancelButton: '...',
	  loader: '...',
	  footer: '....',
	  timerProgressBar: '....',
	}
	```

## Container
```csharp
.Container("my-class")
```

## Popup
```csharp
.Popup("my-class")
```

## Header
```csharp
.Header("my-class")
```

## Title
```csharp
.Title("my-class")
```

## CloseButton
```csharp
.CloseButton("my-class")
```

## Icon
```csharp
.Icon("my-class")
```

## Image
```csharp
.Image("my-class")
```

## HtmlContainer
```csharp
.HtmlContainer("my-class")
```

## Input
```csharp
.Input("my-class")
```

## InputLabel
```csharp
.InputLabel("my-class")
```

## ValidationMessage
```csharp
.ValidationMessage("my-class")
```

## Actions
```csharp
.Actions("my-class")
```

## ConfirmButton
```csharp
.ConfirmButton("my-class")
```

## DenyButton
```csharp
.DenyButton("my-class")
```

## CancelButton
```csharp
.CancelButton("my-class")
```

## Loader
```csharp
.Loader("my-class")
```

## Footer
```csharp
.Footer("my-class")
```

## TimerProgressBar
```csharp
.TimerProgressBar("my-class")
```