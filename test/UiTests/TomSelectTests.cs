using Microsoft.Playwright;
using Xunit;
using static Microsoft.Playwright.Assertions;

namespace RazorKit.UiTests;

public class TomSelectTests(BrowserFixture fixture) : IClassFixture<BrowserFixture>, IAsyncLifetime
{
    private IBrowserContext _context = null!;
    private IPage _page = null!;
    private readonly List<string> _errors = [];

    public async Task InitializeAsync()
    {
        _context = await fixture.Browser.NewContextAsync(new() { ViewportSize = new() { Width = 1280, Height = 900 } });
        _context.SetDefaultTimeout(10000);
        await _context.Tracing.StartAsync(new() { Screenshots = true, Snapshots = true, Sources = true });
        _page = await _context.NewPageAsync();
        _page.PageError += (_, error) => _errors.Add(error);
        var response = await _page.GotoAsync(fixture.BaseUrl + "/TomSelect");
        Assert.True(response?.Ok, "Example page did not load.");
        await _page.WaitForFunctionAsync("() => document.getElementById('Country')?.tomselect");
    }

    public async Task DisposeAsync()
    {
        var output = Path.Combine(fixture.Root, "artifacts", "playwright");
        Directory.CreateDirectory(output);
        await _context.Tracing.StopAsync(new() { Path = Path.Combine(output, Guid.NewGuid() + ".zip") });
        await _context.CloseAsync();
        Assert.Empty(_errors);
    }

    private ILocator Input(string id) => _page.Locator($"#{id}-ts-control");
    private ILocator Wrapper(string id) => _page.Locator($"#{id} + .ts-wrapper");
    private ILocator Option(string id, string value) => _page.Locator($"#{id}-ts-dropdown [data-value='{value}'][data-selectable]");
    private async Task Choose(string id, string value)
    {
        if (!await Option(id, value).IsVisibleAsync()) await Wrapper(id).Locator(".ts-control").ClickAsync();
        await Option(id, value).ClickAsync();
    }

    [Fact]
    public async Task HomeLinksToEveryLibraryAndChartExample()
    {
        await _page.GotoAsync(fixture.BaseUrl);
        foreach (var path in new[] { "/Home/DataTables", "/ChartJs", "/Home/SweetAlert2", "/TomSelect" })
            Assert.True(await _page.Locator($"main a[href='{path}']").CountAsync() > 0, path);
        await _page.Locator("main a[href='/ChartJs']").ClickAsync();
        await Expect(_page.Locator("main li a")).ToHaveCountAsync(10);
    }

    [Fact]
    public async Task AllExamplesInitializeWithoutJavaScriptErrors()
    {
        await _page.WaitForFunctionAsync("() => [...document.querySelectorAll('main select')].every(el => !!el.tomselect)");
        Assert.Equal(12, await _page.Locator("[data-plugin]").CountAsync());
        await Expect(Wrapper("Country").Locator(".item")).ToHaveTextAsync("Türkiye");
        await Expect(_page.Locator("#Country")).ToHaveValueAsync("tr");
        await Expect(_page.Locator("#Languages")).ToHaveValuesAsync(["cs", "js"]);
        await Expect(Wrapper("Remote").Locator(".item")).ToHaveTextAsync("Person 42");
        await Expect(_page.Locator("#Address_Country")).ToHaveAttributeAsync("name", "Address.Country");
        await Expect(_page.Locator("#Country")).ToHaveAttributeAsync("data-val-required", "Choose a country.");
        await _page.ScreenshotAsync(new() { Path = Path.Combine(fixture.Root, "artifacts", "tom-select.png"), FullPage = true });
    }

    [Fact]
    public async Task KeyboardSearchSelectsAndTabMovesFocus()
    {
        await Input("Country").FillAsync("Japan");
        await Expect(Option("Country", "jp")).ToHaveClassAsync(new System.Text.RegularExpressions.Regex("\\bactive\\b"));
        await Input("Country").PressAsync("Enter");
        await Expect(_page.Locator("#Country")).ToHaveValueAsync("jp");
        await Input("Country").PressAsync("Tab");
        await Expect(Wrapper("Country").Locator(".clear-button")).ToBeFocusedAsync();
        await _page.Keyboard.PressAsync("Tab");
        await Expect(Input("Languages")).ToBeFocusedAsync();
    }

    [Fact]
    public async Task FormPostsScalarCollectionAndNestedValuesAndPreservesModelState()
    {
        await Choose("Country", "jp");
        await Wrapper("Languages").Locator(".item[data-value='cs'] .remove").ClickAsync();
        await Choose("Languages", "py");
        await _page.GetByRole(AriaRole.Button, new() { Name = "Submit selections" }).ClickAsync();
        await Expect(_page.Locator("#submitted")).ToContainTextAsync("Country: jp; Languages: js,py; Remote: 42; Address: de");
        await Expect(_page.Locator("#Country")).ToHaveValueAsync("jp");
        await Expect(_page.Locator("#Languages")).ToHaveValuesAsync(["js", "py"]);
    }

    [Fact]
    public async Task InvalidPostRetainsEmptySelectionAndValidationError()
    {
        await Wrapper("Country").Locator(".clear-button").ClickAsync();
        await _page.GetByRole(AriaRole.Button, new() { Name = "Submit selections" }).ClickAsync();
        await Expect(_page.Locator("[data-valmsg-for='Country']")).ToHaveTextAsync("Choose a country.");
        await Expect(_page.Locator("#Country")).ToHaveValueAsync("");
        await Expect(_page.Locator("#submitted")).ToHaveCountAsync(0);
    }

    [Fact]
    public async Task TagsCanBeCreatedRemovedAndFiltered()
    {
        await Input("tags").FillAsync("Razor");
        await Input("tags").PressAsync("Enter");
        await Expect(_page.Locator("#tags")).ToHaveValuesAsync(["Razor"]);
        await Wrapper("tags").Locator(".remove").ClickAsync();
        await Expect(_page.Locator("#tags")).ToHaveValuesAsync(Array.Empty<string>());
        await Input("tags").FillAsync("123");
        await Expect(_page.Locator("#tags-ts-dropdown .create")).ToHaveCountAsync(0);
    }

    [Fact]
    public async Task GroupsAndDisabledOptionsAreRespected()
    {
        await Input("groups").ClickAsync();
        await Expect(_page.Locator("#groups-ts-dropdown .optgroup-header")).ToHaveTextAsync(["Web", "Systems"]);
        await Expect(_page.Locator("#groups-ts-dropdown [data-value='cpp']")).Not.ToHaveAttributeAsync("data-selectable", "");
        await Option("groups", "rs").ClickAsync();
        await Expect(_page.Locator("#groups")).ToHaveValueAsync("rs");
        await Expect(Input("disabled")).ToBeDisabledAsync();
    }

    [Fact]
    public async Task CustomTemplatesEscapeHtmlAndCallbacksRun()
    {
        await Input("custom").ClickAsync();
        await Expect(_page.Locator("#custom-ts-dropdown img")).ToHaveCountAsync(0);
        await Expect(Option("custom", "safe")).ToContainTextAsync("<img src=x onerror=alert(1)>");
        await Option("custom", "safe").ClickAsync();
        await Expect(_page.Locator("#event-log")).ToHaveTextAsync("Selected: safe");
    }

    [Fact]
    public async Task WeightedSearchFindsDescription()
    {
        await Input("custom").FillAsync("Searchable");
        await Expect(Option("custom", "normal")).ToBeVisibleAsync();
        await Expect(Option("custom", "safe")).ToHaveCountAsync(0);
    }

    [Fact]
    public async Task SelectionLimitAndRemoveButtonWork()
    {
        await Choose("limited", "cs");
        await Choose("limited", "js");
        await Expect(_page.Locator("#limited")).ToHaveValuesAsync(["cs", "js"]);
        Assert.True(await _page.EvaluateAsync<bool>("() => document.getElementById('limited').tomselect.isFull()"));
        await Wrapper("limited").Locator(".item[data-value='cs'] .remove").ClickAsync();
        await Choose("limited", "py");
        await Expect(_page.Locator("#limited")).ToHaveValuesAsync(["js", "py"]);
    }

    [Fact]
    public async Task RemoteGetEncodesQueryAndHonorsMinimumLength()
    {
        var requests = new List<string>();
        _page.Request += (_, request) => { if (request.Url.Contains("/TomSelect/Search?")) requests.Add(request.Url); };
        await Input("Remote").FillAsync("P");
        await Expect(_page.Locator("#Remote-ts-dropdown .no-results")).ToHaveCountAsync(0);
        Assert.Empty(requests);
        await Input("Remote").FillAsync("Person 01");
        await Option("Remote", "1").ClickAsync();
        await Expect(_page.Locator("#Remote")).ToHaveValueAsync("1");
        Assert.Contains(requests, url => url.Contains("q=Person+01") || url.Contains("q=Person%2001"));
    }

    [Fact]
    public async Task PostSearchSendsJsonAndAntiforgeryHeader()
    {
        var responseTask = _page.WaitForResponseAsync(response => response.Url.EndsWith("/TomSelect/SearchPost"));
        await Input("remote-post").FillAsync("Person 02");
        var response = await responseTask;
        Assert.True(response.Ok);
        Assert.Equal("POST", response.Request.Method);
        Assert.Contains("\"query\":\"Person 02\"", response.Request.PostData);
        Assert.True(response.Request.Headers.ContainsKey("requestverificationtoken"));
        await Option("remote-post", "2").ClickAsync();
        await Expect(_page.Locator("#remote-post")).ToHaveValueAsync("2");
    }

    [Theory]
    [InlineData(false)]
    [InlineData(true)]
    public async Task FailedOrMalformedRemoteResponsesAllowRetryingTheSameQuery(bool malformed)
    {
        var requestUrl = fixture.BaseUrl + "/TomSelect/Failure?q=retry";
        var input = Input("remote-error");
        if (malformed) await _page.RouteAsync(requestUrl, route => route.FulfillAsync(new() { ContentType = "application/json", Body = "{\"bad\":true}" }));
        await input.FillAsync("retry");
        await Expect(_page.Locator("#remote-status")).ToContainTextAsync("loading released");
        await Expect(Wrapper("remote-error")).Not.ToHaveClassAsync(new System.Text.RegularExpressions.Regex("\\bloading\\b"));
        await input.ClearAsync();
        await _page.UnrouteAsync(requestUrl);
        await _page.RouteAsync(requestUrl, route => route.FulfillAsync(new() { ContentType = "application/json", Body = "[{\"value\":\"ok\",\"text\":\"retry\"}]" }));
        await input.FillAsync("retry");
        await Option("remote-error", "ok").ClickAsync();
        await Expect(_page.Locator("#remote-error")).ToHaveValueAsync("ok");
    }

    [Fact]
    public async Task VirtualScrollLoadsSecondPage()
    {
        await Input("virtual").FillAsync("Person");
        await Expect(Option("virtual", "10")).ToBeVisibleAsync();
        await _page.Locator("#virtual-ts-dropdown").EvaluateAsync("el => { el.scrollTop = el.scrollHeight; el.dispatchEvent(new Event('scroll')); }");
        await Option("virtual", "11").ClickAsync();
        await Expect(_page.Locator("#virtual")).ToHaveValueAsync("11");
    }

    [Fact]
    public async Task DuplicateInitializationIsHarmlessAndTabCanSelect()
    {
        Assert.Equal(1, await _page.Locator("#split-render + .ts-wrapper").CountAsync());
        await Input("split-render").FillAsync("Germany");
        await Expect(Option("split-render", "de")).ToHaveClassAsync(new System.Text.RegularExpressions.Regex("\\bactive\\b"));
        await Input("split-render").PressAsync("Tab");
        await Expect(_page.Locator("#split-render")).ToHaveValueAsync("de");
    }

    [Fact]
    public async Task ChangeListenerSynchronizesNativeSelectChanges()
    {
        await _page.Locator("#plugin-change_listener").SelectOptionAsync(["py"], new() { Force = true });
        await Expect(Wrapper("plugin-change_listener").Locator(".item")).ToHaveTextAsync("Python");
    }

    [Fact]
    public async Task ClearButtonAndNoBackspacePluginsWork()
    {
        await Wrapper("plugin-clear_button").Locator(".clear-button").ClickAsync();
        await Expect(_page.Locator("#plugin-clear_button")).ToHaveValuesAsync(Array.Empty<string>());
        await Input("plugin-no_backspace_delete").ClickAsync();
        await Input("plugin-no_backspace_delete").PressAsync("Backspace");
        await Expect(_page.Locator("#plugin-no_backspace_delete")).ToHaveValuesAsync(["cs", "js"]);
    }

    [Fact]
    public async Task MobileViewportHasNoHorizontalOverflow()
    {
        await _page.SetViewportSizeAsync(390, 844);
        await Wrapper("Country").Locator(".ts-control").ClickAsync();
        await Expect(Option("Country", "jp")).ToBeVisibleAsync();
        Assert.True(await _page.EvaluateAsync<bool>("() => document.documentElement.scrollWidth <= window.innerWidth"));
    }

    [Fact]
    public async Task NumericEnumRemoteAndEditorPrefixBindingSurvivePost()
    {
        await _page.GotoAsync(fixture.BaseUrl + "/TomSelect/Binding");
        await Expect(_page.Locator("#Number")).ToHaveValueAsync("2");
        await Expect(_page.Locator("#Numbers")).ToHaveValuesAsync(["1", "3"]);
        await Expect(_page.Locator("#Choice")).ToHaveValueAsync("2");
        await Expect(Wrapper("Unknown").Locator(".item")).ToHaveTextAsync("remote-value");
        await Expect(_page.Locator("#Shipping_Country")).ToHaveAttributeAsync("name", "Shipping.Country");
        await Expect(_page.Locator("#Shipping_Country")).ToHaveValueAsync("de");
        await _page.GetByRole(AriaRole.Button, new() { Name = "Submit binding examples" }).ClickAsync();
        await Expect(_page.Locator("#Number")).ToHaveValueAsync("2");
        await Expect(_page.Locator("#Numbers")).ToHaveValuesAsync(["1", "3"]);
        await Expect(_page.Locator("#Shipping_Country")).ToHaveValueAsync("de");
    }

    [Fact]
    public async Task CheckboxHeaderAndDropdownInputPluginsRenderTheirControls()
    {
        await Wrapper("plugin-checkbox_options").Locator(".ts-control").ClickAsync();
        await Expect(_page.Locator("#plugin-checkbox_options-ts-dropdown input[type='checkbox']")).ToHaveCountAsync(3);
        await _page.Keyboard.PressAsync("Escape");
        await Wrapper("plugin-dropdown_header").Locator(".ts-control").ClickAsync();
        await Expect(Wrapper("plugin-dropdown_header").Locator(".dropdown-header")).ToBeVisibleAsync();
        await _page.Keyboard.PressAsync("Escape");
        await Wrapper("plugin-dropdown_input").Locator(".ts-control").ClickAsync();
        await Expect(Wrapper("plugin-dropdown_input").Locator(".dropdown-input")).ToBeVisibleAsync();
    }

    [Fact]
    public async Task RestoreOnBackspaceReturnsRemovedLabelToSearch()
    {
        await Input("plugin-restore_on_backspace").FocusAsync();
        await Input("plugin-restore_on_backspace").PressAsync("Backspace");
        await Expect(Input("plugin-restore_on_backspace")).ToHaveValueAsync("JavaScript");
        await Expect(_page.Locator("#plugin-restore_on_backspace")).ToHaveValuesAsync(["cs"]);
    }

    [Theory]
    [InlineData("Line")]
    [InlineData("Bar")]
    [InlineData("Bubble")]
    [InlineData("Doughnut")]
    [InlineData("Pie")]
    [InlineData("Mixed")]
    [InlineData("PolarArea")]
    [InlineData("Radar")]
    [InlineData("Scatter")]
    [InlineData("Animation")]
    public async Task MigratedChartsRender(string action)
    {
        var response = await _page.GotoAsync(fixture.BaseUrl + "/ChartJs/" + action);
        Assert.True(response?.Ok);
        await _page.WaitForFunctionAsync("() => typeof Chart !== 'undefined' && !!Chart.getChart('canvasId')");
        await Expect(_page.Locator("#canvasId")).ToBeVisibleAsync();
    }

    [Fact]
    public async Task MigratedSweetAlertExampleOpensAndCloses()
    {
        await _page.GotoAsync(fixture.BaseUrl + "/Home/SweetAlert2");
        await _page.GetByRole(AriaRole.Button, new() { Name = "Show Alert" }).ClickAsync();
        await Expect(_page.Locator(".swal2-title")).ToHaveTextAsync("Good job!");
        await _page.Locator(".swal2-confirm").ClickAsync();
        await Expect(_page.Locator(".swal2-popup")).ToHaveCountAsync(0);
    }

    [Fact]
    public async Task MigratedDataTableLoadsAndSearchesServerData()
    {
        await _page.GotoAsync(fixture.BaseUrl + "/Home/DataTables");
        await Expect(_page.Locator("#DataTableId tbody")).ToContainTextAsync("Jon Snow");
        await Expect(_page.Locator("#DataTableId tbody")).ToContainTextAsync("Arya Stark");
        var search = _page.Locator(".dt-search input");
        await search.FillAsync("Arya");
        await search.PressAsync("Enter");
        await Expect(_page.Locator("#DataTableId tbody")).ToContainTextAsync("Arya Stark");
        await Expect(_page.Locator("#DataTableId tbody")).Not.ToContainTextAsync("Jon Snow");
    }
}
