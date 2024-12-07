DataSource configuration:
```csharp
.DataSource(ds => ds
    .URL(Url.Action("GetDataResult"))
    .Method("POST"))
```

## URL
Set data source URL.
```csharp
.URL("/Home/GetAll")
```

## Method
Set Ajax Http method.
```csharp
.Method("POST")
```

## Data
=== "cshtml"
	Passing additional data to action and set the name of javascript function.
	```csharp
	.Data("addParam")
	```
	```javascript
	function addParam() {
	   return { param1: "test1", param2: true, param3: 5 };
	}
	```
=== "controller"
	Get parameters with object named "data".
	```csharp
	public JsonResult GetAll(DataRequest request, AddData data)
	{
		//
	}
	```

## Naming
Set naming convention strategy. If not set uses default.
```csharp
.Naming(Convention.CamelCase)
```

