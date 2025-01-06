---
icon: material/menu-right
---

!!! info "Reference [:octicons-link-external-16:](https://www.chartjs.org/docs/latest/configuration/animations.html)"
	Chart.js animates charts out of the box. A number of options are provided to configure how the animation looks and how long it takes.
	
	Namespace: ```options.animation``` or ```options.animations[animation]```
	
```csharp linenums="1"
.Options(o => o
    .Animations(a => a
        .Animation("tension")
        .Duration(1000)
        .Easing(AnimationEasing.Linear)
        .Loop(true)
        .From(1)
        .To(0))
    .Scales(s => s
        .ScaleId("y")
        .Min(0)
        .Max(100)
    )
)
```

## Animation
Set animation like: ```"x"```, ```"y"```, ```"borderWidth"```, ```"radius"```, ```"tension"```
[:octicons-link-external-16:](https://www.chartjs.org/docs/latest/configuration/animations.html#default-animations)
```csharp
.Animation("tension")
```

## Duration
The number of milliseconds an animation takes. Default ```1000```
```csharp
.Duration(2000)
```

## Easing
Easing function to use. Default ```'easeOutQuart'```
[:octicons-link-external-16:](https://www.chartjs.org/docs/latest/configuration/animations.html#easing)
```csharp
.Easing(AnimationEasing.Linear)
```

## Delay
Delay before starting the animations.
```csharp
.Delay(500)
```

## Loop
If set to ```true```, the animations loop endlessly.
```csharp
.Loop(true)
```

## OnProgress
Callback called on each step of an animation.
```csharp
.OnProgress("functionName")
```

## OnComplete
Callback called when all animations are completed.
```csharp
.OnComplete("functionName")
```

## From
Start value for the animation. Current value is used when undefined.
```csharp
.From(true)
```
Or, number:
```csharp
.From(0)
```
Or, color:
```csharp
.From("green")
```

## To
End value for the animation. Updated value is used when undefined
```csharp
.To(true)
```
Or, number:
```csharp
.To(1)
```
Or, color:
```csharp
.To("yellow")
```

