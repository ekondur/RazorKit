!!! info "Reference [:octicons-link-external-16:](https://www.chartjs.org/docs/latest/configuration/legend.html#legend-title-configuration)"
	Set the legent title configuration.
	
	Namespace: ```options.plugins.legend.title```
	
=== "razor"
	```csharp hl_lines="3 5" linenums="1"
	.Options(o => o
    .Plugins(p => p
        .Legend(l => l
            .Display(true)
            .Title(t => t
                .Text("Legend Title")
                .Color("rgb(75, 192, 192)")))))
	```

=== "js"
	The script is produced:
	```js linenums="1"
	"options": {
		"plugins": {
		  "legend": {
			"display": true,
			"title": {
			  "color": "rgb(75, 192, 192)",
			  "text": "Legend Title"
			}
		  }
		}
	}
	```

## Color
Color of text.
```csharp
.Color("example")
```

## Display
Is the legend title displayed.
```csharp
.Display(true)
```

## Font

```csharp
.Font(default)
```

## Padding
Padding around the title.
```csharp
.Padding(15)
```

## Padding

```csharp
.Padding(default)
```

## Text
The string title.
```csharp
.Text("example")
```

