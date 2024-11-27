## Labels
Assigns labels to represent data.
```csharp
.Labels(default)
```

## Datasets

```csharp
.Datasets(default)
```

## Responsive
Resizes the chart canvas when its container does. Default true
```csharp
.Responsive(true)
```

## MaintainAspectRatio
Maintain the original canvas aspect ratio (width / height) when resizing. Default true
```csharp
.MaintainAspectRatio(true)
```

## AspectRatio
Canvas aspect ratio (i.e. width / height, a value of 1 representing a square canvas).
            Note that this option is ignored if the height is explicitly defined either as attribute or via the style.
            The default value varies by chart type; Radial charts (doughnut, pie, polarArea, radar) default to 1 and others default to 2.
```csharp
.AspectRatio(15)
```

## OnResize
Called when a resize occurs. Gets passed two arguments: the chart instance and the new size.
```csharp
.OnResize("example")
```

## OnHover
Called when any of the events fire over chartArea. 
            Passed the event, an array of active elements (bars, points, etc), and the chart.
```csharp
.OnHover("example")
```

## Events
The events option defines the browser events that the chart should listen to for. 
            Each of these events trigger hover and are passed to plugins.
```csharp
.Events(default)
```

## OnClick
Called if the event is of type 'mouseup', 'click' or 'contextmenu' over chartArea. 
            Passed the event, an array of active elements, and the chart.
```csharp
.OnClick("example")
```

## ResizeDelay
Delay the resize update by the given amount of milliseconds.
            This can ease the resize process by debouncing the update of the elements.
            Default 0
```csharp
.ResizeDelay(15)
```

## Locale
Set a language code.
```csharp
.Locale("example")
```

## Plugins

```csharp
.Plugins(default)
```

## Layout

```csharp
.Layout(default)
```

## Animation

```csharp
.Animation(default)
```

## Interaction

```csharp
.Interaction(default)
```

## Scales

```csharp
.Scales(default, default)
```

## Scales

```csharp
.Scales("example", default)
```

## Animations

```csharp
.Animations(default, default)
```

## Elements

```csharp
.Elements(default)
```

## Parsing
How to parse the dataset. The parsing can be disabled by specifying parsing: false at chart options or dataset. 
            If parsing is disabled, data must be sorted and in the formats the associated chart type and scales use internally.
```csharp
.Parsing(true)
```

## Parsing
Parsing with key.
```csharp
.Parsing("example")
```

## Parsing
Parsing with x and y axis keys.
```csharp
.Parsing("example", "example")
```

