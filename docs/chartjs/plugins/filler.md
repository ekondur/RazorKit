---
icon: material/menu-right
---

!!! info "Reference [:octicons-link-external-16:](https://www.chartjs.org/docs/latest/api/interfaces/FillerOptions.html)"
	Filler configuration.
	
=== "helper"
	```csharp hl_lines="3" linenums="1"
	.Options(o => o
		.Plugins(p => p
			.Filler(f => f
				.Propagate(true)
				.DrawTime(DrawTime.BeforeDraw))))
	```

=== "js output"
	```js linenums="1"
	"options": {
		"plugins": {
		  "filler": {
			"propagate": true,
			"drawTime": "beforeDraw"
		  }
		}
	  }
	```

## Propagate
Fill propagation when target is hidden.
```csharp
.Propagate(true)
```

## DrawTime
```csharp
.DrawTime(DrawTime.BeforeDraw)
```

