---
icon: material/code-json
---

## Fire
In SweetAlert2, the ```fire()``` method is the core function used to create and display alerts. It is highly flexible and allows you to customize the appearance and behavior of your alerts.
A previously prepared alert configuration can be called within the desired function. Or it can be defined and triggered directly within the function.

=== "helper"
	```cs title="cshtml" linenums="1" hl_lines="16"
	<button id="alertButton">Show Alert</button>

	@using RazorKit

	@{
		var alert = 
		Html.Swal()             
		.Title("Good job!")
		.Text("You clicked the button!")
		.Icon(SwalIcon.Info)
		.ConfirmButtonText("Cool");
	}

	<script>
		document.getElementById('alertButton').addEventListener('click', function () {
			@alert.Fire()
		});
	</script>
	```

=== "js output"
	```js linenums="1"
	Swal.fire(
	{
	  "title": "Good job!",
	  "text": "You clicked the button!",
	  "icon": "info",
	  "position": "top",
	  "confirmButtonText": "Cool"
	});
	```



## Render
If it is necessary to listen to the alert response, the alert configuration can be rendered and the native fire() method can be used instead of the helper.
```csharp title="cshtml" linenums="1" hl_lines="12"
@{
    var alert = 
    Html.Swal()             
    .Title("Good job!")
    .Text("You clicked the button!")
    .Icon(SwalIcon.Info)
    .ConfirmButtonText("Cool");
}

<script>
    document.getElementById('alertButton').addEventListener('click', function () {
		Swal.fire(@alert.Render())
		.then((result) => {
		  if (result.isConfirmed) {
			// ...
		  } else if (result.isDenied) {
			// ...
		  }
		})		
    });
</script>
```



