---
icon: material/menu-right
---

## Enabled
If you don't have any preference for colors, you can use the built-in Colors plugin.
            It will cycle through a palette of seven Chart.js brand colors. Default true
```csharp
.Enabled(true)
```

## ForceOverride
By default, the colors plugin only works when you initialize the chart without any colors for the border or background specified.
            If you want to force the colors plugin to always color your datasets, for example,
            when using dynamic datasets at runtime you will need to set the forceOverride option to true.
```csharp
.ForceOverride(true)
```

