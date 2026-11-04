---
icon: material/cloud-download-outline
---

# Remote data

```cshtml
@(Html.TomSelectFor(m => m.PersonId)
    .ValueField("id").LabelField("name").SearchField("name")
    .Options(Model.SelectedPeople)
    .DataSource(ds => ds
        .Url(Url.Action("Search", "People"))
        .QueryParameter("q")
        .ResultsField("results")
        .MinimumQueryLength(2))
    .LoadThrottle(300)
    .Render())
```

The GET endpoint receives `q` and returns `{ "results": [{ "id": "42", "name": "Ada" }] }`. Omit `ResultsField` for a top-level array. Dotted paths such as `data.items` and optional `OptgroupsField("data.groups")` support response envelopes. `Transform("function(data, query) { ... }")` can adapt another response shape before extracting these arrays.

Provide initial selected records in `Options` so their labels appear before searching. If an initial selection has no matching option, the helper renders the value as a fallback label. Option names/casing must match the configured value and label fields.

## Request options

```csharp
.DataSource(ds => ds
    .Url("/People/Search")
    .Method("POST")
    .QueryParameter("query")
    .Parameter("department", new JavaScript("document.getElementById('Department').value"))
    .Header("RequestVerificationToken", antiforgeryToken)
    .Credentials("same-origin")
    .ResultsField("results")
    .OnError("function(error, query) { console.error(error); }"))
```

GET adds URL-encoded query parameters while preserving the URL's existing parameters. POST sends JSON with `Content-Type: application/json`. `Parameter` adds JSON values or explicit trusted expressions evaluated on every request. `Header` accepts static header values; `Credentials` supports `omit`, `same-origin` and `include`. Configure your server's antiforgery header and request model accordingly.

Network failures, unsuccessful HTTP responses and malformed option/group arrays release Tom Select's loading state by calling its completion callback, then invoke the optional error handler. The handler receives the error and query, with the control as `this`.

## Custom loading and pagination

`Load`, `ShouldLoad`, `FirstUrl` and `ShouldLoadMore` accept trusted functions. They let you implement custom transports, cancellation, dependent selects and [virtual scrolling](https://tom-select.js.org/plugins/virtual_scroll/). `DataSource` implements ordinary GET/POST loading, not automatic pagination; later `Load`/`ShouldLoad` calls override its generated callbacks.

```csharp
.Plugins(p => p.VirtualScroll())
.FirstUrl("function(query) { return '/People/Search?q=' + encodeURIComponent(query); }")
.Load(@"function(query, callback) {
    var self = this;
    fetch(self.getUrl(query))
        .then(function(response) {
            if (!response.ok) throw new Error(response.status);
            return response.json();
        })
        .then(function(data) {
            self.setNextUrl(query, data.next);
            callback(data.results);
        }, function() { callback(); });
}")
```

The paged endpoint returns a next-page URL or `null`. Set the next URL before calling the completion callback. The shared test application contains a working 80-person paged endpoint and a scroll test.
