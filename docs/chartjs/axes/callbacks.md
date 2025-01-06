---
icon: material/menu-right
---

!!! info "Reference [:octicons-link-external-16:](https://www.chartjs.org/docs/latest/axes/#callbacks)"
	There are a number of config callbacks that can be used to change parameters in the scale at different points in the update process. 
	The options are supplied at the top level of the axis options.
	
	Namespace: ```options.scales[scaleId]```
	
```csharp hl_lines="5" linenums="1"
.Options(o => o
    .Scales(s => s
		.ScaleId("y")
        .BeginAtZero(true)
        .Callbacks(c => c
            .BeforeUpdate("onBeforeUpdate")
            .AfterUpdate("onAfterUpdate"))))
```

## BeforeUpdate
Callback called before the update process starts.
```csharp
.BeforeUpdate("functionName")
```

## AfterUpdate
Callback that runs at the end of the update process.
```csharp
.AfterUpdate("functionName")
```

## BeforeSetDimensions
Callback that runs before dimensions are set.
```csharp
.BeforeSetDimensions("functionName")
```

## AfterSetDimensions
Callback that runs after dimensions are set.
```csharp
.AfterSetDimensions("functionName")
```

## BeforeDataLimits
Callback that runs before data limits are determined.
```csharp
.BeforeDataLimits("functionName")
```

## AfterDataLimits
Callback that runs after data limits are determined.
```csharp
.AfterDataLimits("functionName")
```

## BeforeBuildTicks
Callback that runs before ticks are created.
```csharp
.BeforeBuildTicks("functionName")
```

## AfterBuildTicks
Callback that runs after ticks are created. Useful for filtering ticks.
```csharp
.AfterBuildTicks("functionName")
```

## BeforeTickToLabelConversion
Callback that runs before ticks are converted into strings.
```csharp
.BeforeTickToLabelConversion("functionName")
```

## AfterTickToLabelConversion
Callback that runs after ticks are converted into strings.
```csharp
.AfterTickToLabelConversion("functionName")
```

## BeforeCalculateLabelRotation
Callback that runs before tick rotation is determined.
```csharp
.BeforeCalculateLabelRotation("functionName")
```

## AfterCalculateLabelRotation
Callback that runs after tick rotation is determined.
```csharp
.AfterCalculateLabelRotation("functionName")
```

## BeforeFit
Callback that runs before the scale fits to the canvas.
```csharp
.BeforeFit("functionName")
```

## AfterFit
Callback that runs after the scale fits to the canvas.
```csharp
.AfterFit("functionName")
```

