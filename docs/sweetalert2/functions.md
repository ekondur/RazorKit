---
icon: material/function
---

!!! info
	These functions provide a convenient way to interact with and control the behavior of SweetAlert2 popups. 
	They are predefined and ready to use, making it easy to customize and handle different scenarios without additional coding effort.

## PreConfirm
Function to execute before confirming, may be async (Promise-returning) or sync.
[:octicons-link-external-16:](https://sweetalert2.github.io/#preConfirm)
```csharp
.PreConfirm("functionName")
```

## PreDeny
Function to execute before denying, may be async (Promise-returning) or sync.
[:octicons-link-external-16:](https://sweetalert2.github.io/#preDeny)
```csharp
.PreDeny("functionName")
```

## InputValidator
Validator for input field, may be async (Promise-returning) or sync.
[:octicons-link-external-16:](https://sweetalert2.github.io/#inputValidator)
```csharp
.InputValidator("functionName")
```

## DidRender
Popup lifecycle hook. Synchronously runs after the popup DOM has been updated (i.e. just before the popup is repainted on the screen). 
```didRender``` is called before willOpen.  Provides popup DOM element as the argument. Typically, this will happen after ```Swal.fire()``` or ```Swal.update()```.
If you want to perform changes in the popup's DOM, that survive ```Swal.update()```, prefer ```didRender``` over ```willOpen```. In previous versions, this hook was named onRender.
[:octicons-link-external-16:](https://sweetalert2.github.io/#didRender)
```csharp
.DidRender("functionName")
```

## WillOpen
Popup lifecycle hook. Synchronously runs before the popup is shown on screen. 
Provides popup DOM element as the argument. In previous versions, this hook was named ```onBeforeOpen```.
[:octicons-link-external-16:](https://sweetalert2.github.io/#willOpen)
```csharp
.WillOpen("functionName")
```

## DidOpen
Popup lifecycle hook. Asynchronously runs after the popup has been shown on screen. 
Provides popup DOM element as the argument. In previous versions, this hook was named ```onOpen```.
[:octicons-link-external-16:](https://sweetalert2.github.io/#didOpen)
```csharp
.DidOpen("functionName")
```

## WillClose
Popup lifecycle hook. Synchronously runs when the popup closes by user interaction (and not due to another popup being fired). 
Provides popup DOM element as the argument. In previous versions, this hook was named ```onClose```.
[:octicons-link-external-16:](https://sweetalert2.github.io/#willClose)
```csharp
.WillClose("functionName")
```

## DidClose
Popup lifecycle hook. Asynchronously runs after the popup has been disposed by user interaction (and not due to another popup being fired). 
In previous versions, this hook was named ```onAfterClose```.
[:octicons-link-external-16:](https://sweetalert2.github.io/#didClose)
```csharp
.DidClose("functionName")
```

## DidDestroy
Popup lifecycle hook. Synchronously runs after popup has been destroyed either by user interaction or by another popup.
If you have cleanup operations that you need to reliably execute each time a popup is closed, prefer ```didDestroy``` over ```didClose```.
In previous versions, this hook was named ```onDestroy```.
[:octicons-link-external-16:](https://sweetalert2.github.io/#didDestroy)
```csharp
.DidDestroy("functionName")
```