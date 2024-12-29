---
icon: material/button-pointer
---

## ShowConfirmButton
If set to ```false```, a "Confirm"-button will not be shown. Default ```true```
[:octicons-link-external-16:](https://sweetalert2.github.io/#showConfirmButton)
```csharp
.ShowConfirmButton(false)
```

## ShowDenyButton
If set to ```true```, a "Deny"-button will be shown. It can be useful when you want a popup with 3 buttons. Default ```false```
[:octicons-link-external-16:](https://sweetalert2.github.io/#showDenyButton)
```csharp
.ShowDenyButton(true)
```

## ShowCancelButton
If set to ```true```, a "Cancel"-button will be shown, which the user can click on to dismiss the modal. Default ```false```
[:octicons-link-external-16:](https://sweetalert2.github.io/#showCancelButton)
```csharp
.ShowCancelButton(true)
```

## ConfirmButtonText
Use this to change the text on the "Confirm"-button. Default ```'OK'```
[:octicons-link-external-16:](https://sweetalert2.github.io/#confirmButtonText)
```csharp
.ConfirmButtonText("Yes")
```

## DenyButtonText
Use this to change the text on the "Deny"-button. Default ```'No'```
[:octicons-link-external-16:](https://sweetalert2.github.io/#denyButtonText)
```csharp
.DenyButtonText("Nope")
```

## CancelButtonText
Use this to change the text on the "Cancel"-button. Default ```'Cancel'```
[:octicons-link-external-16:](https://sweetalert2.github.io/#cancelButtonText)
```csharp
.CancelButtonText("Exit")
```

## ConfirmButtonColor
Use this to change the background color of the "Confirm"-button. The default color is ```#3085d6```
[:octicons-link-external-16:](https://sweetalert2.github.io/#confirmButtonColor)
```csharp
.ConfirmButtonColor("#3085d6")
```

## DenyButtonColor
Use this to change the background color of the "Deny"-button. The default color is ```#dd6b55```
[:octicons-link-external-16:](https://sweetalert2.github.io/#denyButtonColor)
```csharp
.DenyButtonColor("#dd6b55")
```

## CancelButtonColor
Use this to change the background color of the "Cancel"-button. The default color is ```#aaa```
[:octicons-link-external-16:](https://sweetalert2.github.io/#cancelButtonColor)
```csharp
.CancelButtonColor("#aaa")
```

## ConfirmButtonAriaLabel
Use this to change the ```aria-label``` for the "Confirm"-button.
[:octicons-link-external-16:](https://sweetalert2.github.io/#confirmButtonAriaLabel)
```csharp
.ConfirmButtonAriaLabel("confirm")
```

## DenyButtonAriaLabel
Use this to change the ```aria-label``` for the "Deny"-button.
[:octicons-link-external-16:](https://sweetalert2.github.io/#denyButtonAriaLabel)
```csharp
.DenyButtonAriaLabel("deny")
```

## CancelButtonAriaLabel
Use this to change the ```aria-label``` for the "Cancel"-button.
[:octicons-link-external-16:](https://sweetalert2.github.io/#cancelButtonAriaLabel)
```csharp
.CancelButtonAriaLabel("cancel")
```

## ButtonsStyling
Apply default styling to buttons. If you want to use your own classes (e.g. Bootstrap classes) set this parameter to ```false```. Default ```true```
[:octicons-link-external-16:](https://sweetalert2.github.io/#buttonsStyling)
```csharp
.ButtonsStyling(false)
```

## ReverseButtons
Set to ```true``` if you want to invert default buttons positions ("Confirm"-button on the right side). Default ```false```
[:octicons-link-external-16:](https://sweetalert2.github.io/#reverseButtons)
```csharp
.ReverseButtons(true)
```

## FocusConfirm
Set to ```false``` if you want to focus the first element in tab order instead of "Confirm"-button by default. Default ```true```
[:octicons-link-external-16:](https://sweetalert2.github.io/#focusConfirm)
```csharp
.FocusConfirm(false)
```

## ReturnFocus
Set to ```false``` if you don't want to return the focus to the element that invoked the modal after the modal is closed. Default ```true```
[:octicons-link-external-16:](https://sweetalert2.github.io/#returnFocus)
```csharp
.ReturnFocus(false)
```

## FocusDeny
Set to ```true``` if you want to focus the "Deny"-button by default. Default ```false```
[:octicons-link-external-16:](https://sweetalert2.github.io/#focusDeny)
```csharp
.FocusDeny(true)
```

## FocusCancel
Set to ```true``` if you want to focus the "Cancel"-button by default. Default ```false```
[:octicons-link-external-16:](https://sweetalert2.github.io/#focusCancel)
```csharp
.FocusCancel(true)
```

## ShowCloseButton
Set to ```true``` to show close button in top right corner of the popup. Default ```false```
[:octicons-link-external-16:](https://sweetalert2.github.io/#showCloseButton)
```csharp
.ShowCloseButton(true)
```

## CloseButtonHtml
Use this to change the content of the close button. Default ```'&times;'```
[:octicons-link-external-16:](https://sweetalert2.github.io/#closeButtonHtml)
```csharp
.CloseButtonHtml("<i class="fas fa-times-circle"></i>")
```

## CloseButtonAriaLabel
Use this to change the aria-label for the close button. Default ```'Close this dialog'```
[:octicons-link-external-16:](https://sweetalert2.github.io/#closeButtonAriaLabel)
```csharp
.CloseButtonAriaLabel("Close the dialog")
```