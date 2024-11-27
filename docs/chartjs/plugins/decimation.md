## Enabled
Is decimation enabled?
```csharp
.Enabled(true)
```

## Algorithm

```csharp
.Algorithm(default)
```

## Samples
If the 'lttb' algorithm is used, this is the number of samples in the output dataset. 
            Defaults to the canvas width to pick 1 sample per pixel.
```csharp
.Samples(15)
```

## Threshold
If the number of samples in the current axis range is above this value, the decimation will be triggered. 
            Defaults to 4 times the canvas width.
            The number of point after decimation can be higher than the threshold value.
```csharp
.Threshold(15)
```

