# RazorKit.SweetAlert2

[RazorKit.SweetAlert2](https://www.nuget.org/packages/RazorKit.SweetAlert2) is a lightweight and intuitive library that allows developers to create and configure beautiful 
[SweetAlert2](https://sweetalert2.github.io/) alerts directly in Razor views using a fluent builder style. Simplify the process of creating highly customizable and interactive alerts in your ASP.NET MVC projects!

## Features
- **Fluent Builder API:** Easily chain methods to configure alerts with minimal code.
- **SweetAlert2 Integration:** Supports the full range of SweetAlert2 features, including icons, animations, input fields, and more.
- **HTML Helper Support:** Seamlessly integrate with Razor views using the Html helper.
- **Dynamic Attributes:** Add custom input attributes, animations, and styling effortlessly.
- **Clean and Readable Code:** Focus on functionality without sacrificing code readability.

## Setup

Install the NuGet package:

```bash
dotnet add package RazorKit.SweetAlert2
```
Or via the NuGet Package Manager:
```bash
PM> Install-Package RazorKit.SweetAlert2
```

Add needed script and style links to layout: [Reference:](https://sweetalert2.github.io/#download)

```html
<script src="https://cdn.jsdelivr.net/npm/sweetalert2@11"></script>
```

## Usage
It is easy to implement with html helper:

```cs title="cshtml" linenums="1" hl_lines="16"
<button id="alertButton">Show Alert</button>

@using RazorKit

@{
    var alert = 
    Html.Swal()             
    .Title("Good job!")
    .Text("You clicked the button!")
    .Icon(SwalIcon.Question)
    .Footer("footer of the alert");
}

<script>
    document.getElementById('alertButton').addEventListener('click', function () {
        @alert.Fire()
    });
</script>
```