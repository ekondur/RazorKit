---
icon: material/menu-right
---

!!! info "Reference [:octicons-link-external-16:](https://www.chartjs.org/docs/latest/general/padding.html)"
	Padding values in Chart options can be supplied in a couple of different formats.

## Number
If this value is a number, it is applied to all sides (left, top, right, bottom).
[:octicons-link-external-16:](https://www.chartjs.org/docs/latest/general/padding.html#number)
```csharp
.Padding(20)
```

## Object ```{top, left, bottom, right}```
If this value is an object, the ```left``` property defines the ```left``` padding. 
Similarly, the ```right```, ```top``` and ```bottom``` properties can also be specified. Omitted properties default to ```0```.
[:octicons-link-external-16:](https://www.chartjs.org/docs/latest/general/padding.html#top-left-bottom-right-object)
```csharp
.Padding(p => p.Left(5).Right(10).Top(20).Bottom(15))
```

## Object ```{x, y}```
This is a shorthand for defining ```left/right``` and ```top/bottom``` to the same values.
[:octicons-link-external-16:](https://www.chartjs.org/docs/latest/general/padding.html#x-y-object)
```csharp
.Padding(p => p.X(5).Y(10))
```

