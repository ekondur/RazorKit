---
icon: material/filter-outline
---

Filters configuration:

```csharp
.Filters(f =>
{
    f.Add(x => x.Id).GreaterThanOrEqual(1);
	f.Add(x => x.Name).Contains("Jon");
})
```

## Add
Add the specified property for filter.
```csharp
.Add(x => x.Id)
```

## Equal
Equals the specified value.
```csharp
.Equal(1)
```

## NotEqual
Nots the equal.
```csharp
.NotEqual(1)
```

## GreaterThan
Greaters the than.
```csharp
.GreaterThan(1)
```

## Contains
Determines whether this instance contains the object.
```csharp
.Contains("Jon")
```

## EndsWith
Endses the with.
```csharp
.EndsWith("Snow")
```

## GreaterThanOrEqual
Greaters the than or equal.
```csharp
.GreaterThanOrEqual(5)
```

## LessThan
Lesses the than.
```csharp
.LessThan(4)
```

## LessThanOrEqual
Lesses the than or equal.
```csharp
.LessThanOrEqual(5)
```

## StartsWith
Startses the with.
```csharp
.StartsWith("Jon")
```

