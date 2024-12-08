!!! info "Reference [:octicons-link-external-16:](https://datatables.net/extensions/fixedheader/)"
	When displaying tables with a particularly large amount of data shown on each page, 
	it can be useful to have the table's header and / or footer fixed to the top or bottom of the scrolling window. 
	This lets your users quickly determine what each column refers to rather than needing to scroll back to the top of the table.
	
Enable the FixedHeader extension for DataTables.
[:octicons-link-external-16:](https://datatables.net/reference/option/fixedHeader)
```csharp
.FixedHeader(true)
```
Or, configure it.
```csharp
.FixedHeader(fh => fh.Header(true).HeaderOffset(50))
```

## Header
Enable / disable fixed header.
[:octicons-link-external-16:](https://datatables.net/reference/option/fixedHeader.header)
```csharp
.Header(true)
```

## Footer
Enable / disable fixed footer.
[:octicons-link-external-16:](https://datatables.net/reference/option/fixedHeader.footer)
```csharp
.Footer(true)
```

## HeaderOffset
Offset the table's fixed header.
[:octicons-link-external-16:](https://datatables.net/reference/option/fixedHeader.headerOffset)
```csharp
.HeaderOffset(50)
```
Offset the table's fixed header with function.
```csharp
.HeaderOffset("functionName")
```

## FooterOffset
Offset the table's fixed footer.
[:octicons-link-external-16:](https://datatables.net/reference/option/fixedHeader.footerOffset)
```csharp
.FooterOffset(50)
```
Offset the table's fixed footer with function.
```csharp
.FooterOffset("functionName")
```

