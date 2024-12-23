---
icon: material/menu-right
---

!!! info "Reference [:octicons-link-external-16:](https://www.chartjs.org/docs/latest/configuration/interactions.html)"
	Namespace: ```options.interaction```. To configure which events trigger chart interactions, see [events](configuration.md#events).
	
=== "helper"
	```csharp hl_lines="2" linenums="1"
	.Options(o => o
		.Interaction(i => i
			.Mode(InteractionMode.Index)
			.Axis(Axis.X)))
	```

=== "js output"
	```js linenums="1"
	"options": {
		"interaction": {
		  "mode": 2,
		  "axis": "x"
		}
	  }
	```

## Mode
Sets which elements appear in the interaction. Default ```'nearest'```
[:octicons-link-external-16:](https://www.chartjs.org/docs/latest/configuration/interactions.html#modes)
```csharp
.Mode(InteractionMode.Index)
```

## Intersect
if true, the interaction mode only applies when the mouse position intersects an item on the chart.
Default ```true```
```csharp
.Intersect(true)
```

## Axis
Can be set to ```'x'```, ```'y'```, ```'xy'``` or ```'r'``` to define which directions are used in calculating distances.
Defaults to ```'x'``` for ```'index'``` mode and ```'xy'``` in dataset and ```'nearest'``` modes.
```csharp
.Axis(Axis.X)
```

## IncludeInvisible
if ```true```, the invisible points that are outside of the chart area will also be included when evaluating interactions.
 Default ```false```
```csharp
.IncludeInvisible(true)
```

