---
icon: material/star-settings-outline
---

!!! info "Reference [:octicons-link-external-16:](https://sweetalert2.github.io/#configuration)"
	Here are the keys that you can use if you pass an object into sweetAlert2:

## Title
The title of the popup, as HTML.
[:octicons-link-external-16:](https://sweetalert2.github.io/#title)
```csharp
.Title("title")
```

## TitleText
The title of the popup, as text. Useful to avoid HTML injection.
[:octicons-link-external-16:](https://sweetalert2.github.io/#titleText)
```csharp
.TitleText("example")
```

## Html
A HTML description for the popup.
If ```text``` and ```html``` parameters are provided in the same time, html will be used.
[:octicons-link-external-16:](https://sweetalert2.github.io/#html)
```csharp
.Html("<p>text</p>")
```

## Text
A description for the popup. If ```text``` and ```html``` parameters are provided in the same time, ```html``` will be used.
[:octicons-link-external-16:](https://sweetalert2.github.io/#text)
```csharp
.Text("popup text")
```

## Icon
The icon of the popup. SweetAlert2 comes with 5 built-in icon which will show a corresponding icon animation.
[:octicons-link-external-16:](https://sweetalert2.github.io/#icon)
```csharp
.Icon("info")
```

## IconColor
Use this to change the color of the icon.
[:octicons-link-external-16:](https://sweetalert2.github.io/#iconColor)
```csharp
.IconColor("blue")
```

## IconHtml
The custom HTML content for an icon.
[:octicons-link-external-16:](https://sweetalert2.github.io/#iconHtml)
```csharp
.IconHtml("؟")
```

## Animation
If set to ```false```, the popup animation will be disabled. Default ```true```
[:octicons-link-external-16:](https://sweetalert2.github.io/#animation)
```csharp
.Animation(false)
```

## Theme
Theme of the popup.
[:octicons-link-external-16:](https://sweetalert2.github.io/#theme)
```csharp
.Theme("dark")
```

## ShowClass
CSS classes for animations when showing a popup (fade in).
[:octicons-link-external-16:](https://sweetalert2.github.io/#showClass)
```csharp
.ShowClass(sc => sc
    .Popup("swal2-show")
    .Backdrop("swal2-backdrop-show")
    .Icon("swal2-icon-show"))
```

## HideClass
CSS classes for animations when hiding a popup (fade out).
[:octicons-link-external-16:](https://sweetalert2.github.io/#hideClass)
```csharp
.ShowClass(sc => sc
    .Popup("swal2-hide")
    .Backdrop("swal2-backdrop-hide")
    .Icon("swal2-icon-hide"))
```

## Footer
The footer of the popup. Can be either plain text or HTML.
[:octicons-link-external-16:](https://sweetalert2.github.io/#footer)
```csharp
.Footer("footer text")
```

## Backdrop
Whether or not SweetAlert2 should show a full screen click-to-dismiss backdrop. Default ```true```
[:octicons-link-external-16:](https://sweetalert2.github.io/#backdrop)
```csharp
.Backdrop(false)
```
Can be either a ```boolean``` or a ```string``` which will be assigned to the CSS ```background``` property.
```csharp
.Backdrop("no-repeat")
```

## Toast
Whether or not an alert should be treated as a toast notification. 
This option is normally coupled with the ```position``` parameter and a timer. Toasts are NEVER autofocused.
Default ```false```
[:octicons-link-external-16:](https://sweetalert2.github.io/#toast)
```csharp
.Toast(true)
```

## Target
The container element for adding popup into. Default ```'body'```
[:octicons-link-external-16:](https://sweetalert2.github.io/#target)
```csharp
.Target("body")
```

## Input
Input field type.
[:octicons-link-external-16:](https://sweetalert2.github.io/#input-types)
```csharp
.Input("email")
```

## Width
Popup window width, including paddings (box-sizing: border-box). Can be in any CSS unit (```px```, ```em/rem```, ```%```).
Default ```'32em'```
[:octicons-link-external-16:](https://sweetalert2.github.io/#width)
```csharp
.Width("5px")
```

## Padding
Popup window padding. Can be in any CSS unit (```px```, ```em/rem```, ```%```). Default ```'0 0 1.25em'```
[:octicons-link-external-16:](https://sweetalert2.github.io/#padding)
```csharp
.Padding("3em")
```

## Color
Color for title, content and footer (CSS ```color``` property). The default color is ```'#545454'```.
[:octicons-link-external-16:](https://sweetalert2.github.io/#color)
```csharp
.Color("#545454")
```

## Background
Popup window background (CSS background property). The default background is ```'#fff'```.
[:octicons-link-external-16:](https://sweetalert2.github.io/#background)
```csharp
.Background("#fff")
```

## Position
Popup window position. Default ```'center'```
[:octicons-link-external-16:](https://sweetalert2.github.io/#position)
```csharp
.Position("top")
```

## Draggable
Enable draggable modal. Default ```false```
[:octicons-link-external-16:](https://sweetalert2.github.io/#examples)
```csharp
.Draggable(true)
```

## Grow
Paired with window position, sets the direction the popup should grow in, can be set to ```false```.
[:octicons-link-external-16:](https://sweetalert2.github.io/#grow)
```csharp
.Grow(true)
```
Or, can be set to ```'row'```, ```'column'```, ```'fullscreen'```.
```csharp
.Grow("row")
```

## Timer
Auto close timer of the popup. Set in ms (milliseconds).
[:octicons-link-external-16:](https://sweetalert2.github.io/#timer)
```csharp
.Timer(1000)
```

## TimerProgressBar
If set to ```true```, the timer will have a progress bar at the bottom of a popup. Mostly, this feature is useful with toasts. Default ```false```
[:octicons-link-external-16:](https://sweetalert2.github.io/#timerProgressBar)
```csharp
.TimerProgressBar(true)
```

## HeightAuto
By default, SweetAlert2 sets html's and body's CSS ```height``` to ```auto !important```. 
If this behavior isn't compatible with your project's layout, set ```heightAuto``` to ```false```.
Default ```true```
[:octicons-link-external-16:](https://sweetalert2.github.io/#heightAuto)
```csharp
.HeightAuto(false)
```

## AllowOutsideClick
If set to ```false```, the user can't dismiss the popup by clicking outside it.
You can also pass a custom function returning a boolean value, e.g. if you want to disable outside clicks for the loading state of a popup.
Default ```true```
[:octicons-link-external-16:](https://sweetalert2.github.io/#allowOutsideClick)
```csharp
.AllowOutsideClick(false)
```

## AllowEscapeKey
If set to ```false```, the user can't dismiss the popup by pressing the Esc key. You can also pass a custom function returning a boolean value, 
e.g. if you want to disable the Esc key for the loading state of a popup. Default ```true```
[:octicons-link-external-16:](https://sweetalert2.github.io/#allowEscapeKey)
```csharp
.AllowEscapeKey(false)
```

## StopKeydownPropagation
If set to ```false```, SweetAlert2 will allow ```keydown``` events propagation to the document. Default ```true```
[:octicons-link-external-16:](https://sweetalert2.github.io/#stopKeydownPropagation)
```csharp
.StopKeydownPropagation(false)
```

## KeydownListenerCapture
Useful for those who are using SweetAlert2 along with Bootstrap modals. 
By default ```keydownListenerCapture``` is ```false``` which means when a user hits Esc, both SweetAlert2 and Bootstrap modals will be closed. 
Set ```keydownListenerCapture``` to ```true``` to fix that behavior. Default ```false```
[:octicons-link-external-16:](https://sweetalert2.github.io/#keydownListenerCapture)
```csharp
.KeydownListenerCapture(true)
```

## LoaderHtml
Use this to change the HTML content of the loader.
[:octicons-link-external-16:](https://sweetalert2.github.io/#loaderHtml)
```csharp
.LoaderHtml("<div class="custom-loader">Loading...</div>")
```

## ShowLoaderOnConfirm
Set to ```true``` to disable buttons and show the loader instead of the Confirm button. Use it in combination with the ```preConfirm``` parameter. Default ```false```
[:octicons-link-external-16:](https://sweetalert2.github.io/#showLoaderOnConfirm)
```csharp
.ShowLoaderOnConfirm(true)
```

## ShowLoaderOnDeny
Set to ```true``` to disable buttons and show the loader instead of the Deny button. Use it in combination with the ```preDeny``` parameter. Default ```false```
[:octicons-link-external-16:](https://sweetalert2.github.io/#showLoaderOnDeny)
```csharp
.ShowLoaderOnDeny(true)
```

## ReturnInputValueOnDeny
If you want to return the input value as ```result.value``` when denying the popup, set to ```true```. 
Otherwise, the denying will set ```result.value``` to ```false```. Default ```false```
[:octicons-link-external-16:](https://sweetalert2.github.io/#returnInputValueOnDeny)
```csharp
.ReturnInputValueOnDeny(true)
```

## ImageUrl
Add a customized icon for the popup. Should contain a string with the path or URL to the image.
[:octicons-link-external-16:](https://sweetalert2.github.io/#imageUrl)
```csharp
.ImageUrl("https://unsplash.it/400/200")
```

## ImageWidth
If imageUrl is set, you can specify imageWidth to describes image width. Can be in any CSS unit (```px```, ```em/rem```, ```%```).
[:octicons-link-external-16:](https://sweetalert2.github.io/#imageWidth)
```csharp
.ImageWidth("32px")
```

## ImageHeight
Custom image height. Can be in any CSS unit (```px```, ```em/rem```, ```%```).
[:octicons-link-external-16:](https://sweetalert2.github.io/#imageHeight)
```csharp
.ImageHeight("32px")
```

## ImageAlt
An alternative text for the custom image icon.
[:octicons-link-external-16:](https://sweetalert2.github.io/#imageAlt)
```csharp
.ImageAlt("image alt text")
```

## InputLabel
Input field label.
[:octicons-link-external-16:](https://sweetalert2.github.io/#inputLabel)
```csharp
.InputLabel("Your IP address")
```

## InputPlaceholder
Input field placeholder.
[:octicons-link-external-16:](https://sweetalert2.github.io/#inputPlaceholder)
```csharp
.InputPlaceholder("password")
```

## InputValue
Input field initial value.
If the input type is ```select```, ```inputValue``` will represent the selected ```<option>``` tag.
If the input type is ```checkbox```, ```inputValue``` will represent the ```checked``` state.
If the input type is ```email```, ```number```, ```tel```, ```text```, ```email```, ```number```, ```tel``` or ```textarea```, a Promise can be accepted as ```inputValue```.
[:octicons-link-external-16:](https://sweetalert2.github.io/#inputValue)
```csharp
.InputValue("value")
```

## InputOptions
If ```input``` parameter is set to ```select``` or ```radio```, you can provide options. 
Can be a Map or a plain object, with keys that represent option values and values that represent option text. 
You can also provide plain object or Map as values that will represented a group of options, being the label of this ```<optgroup>``` the key. 
Finally, you can also provide a Promise that resolves with one of those types.
[:octicons-link-external-16:](https://sweetalert2.github.io/#inputOptions)
```csharp
.InputOptions(Viewbag.MyOptions)
```

## InputAutoFocus
Automatically focus the input when popup is shown. Set this parameter to ```false``` to disable auto-focusing. Default ```true```
[:octicons-link-external-16:](https://sweetalert2.github.io/#inputAutoFocus)
```csharp
.InputAutoFocus(false)
```

## InputAutoTrim
Automatically remove whitespaces from both ends of a result string. Set this parameter to ```false``` to disable auto-trimming. Default ```true```
[:octicons-link-external-16:](https://sweetalert2.github.io/#inputAutoTrim)
```csharp
.InputAutoTrim(false)
```

## InputAttributes
HTML input attributes (e.g. ```min```, ```max```, ```autocomplete```, ```accept```), that are added to the input field. 
Object keys will represent attributes names, object values will represent attributes values.
[:octicons-link-external-16:](https://sweetalert2.github.io/#inputAttributes)
```csharp
.InputAttributes(ia => ia
    .Add("maxlength", "10")
    .Add("autocapitalize", "off")
    .Add("autocorrect", "off"))
```

## ValidationMessage
A custom validation message for default validators (```email```, ```url```).
[:octicons-link-external-16:](https://sweetalert2.github.io/#validationMessage)
```csharp
.ValidationMessage("Custom validation message!")
```

## ProgressSteps
Progress steps, useful for queues.
[:octicons-link-external-16:](https://sweetalert2.github.io/#progressSteps)
```csharp
.ProgressSteps("1", "2", "3")
```

## CurrentProgressStep
Current active progress step.
[:octicons-link-external-16:](https://sweetalert2.github.io/#currentProgressStep)
```csharp
.CurrentProgressStep("1")
```

## ProgressStepsDistance
Distance between progress steps. Can be in any CSS unit (```px```, ```em/rem```, ```%```).
[:octicons-link-external-16:](https://sweetalert2.github.io/#progressStepsDistance)
```csharp
.ProgressStepsDistance("1em")
```