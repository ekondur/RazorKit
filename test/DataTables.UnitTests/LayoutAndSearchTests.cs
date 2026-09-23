using Newtonsoft.Json.Linq;
using RazorKit.DataTables.Builders;
using RazorKit.DataTables.Models;
using Xunit;

namespace RazorKit.DataTables.UnitTests;

public class LayoutAndSearchTests
{
    [Fact]
    public void BuiltInButtonsCanBeTheFirstAndOnlyLayoutConfiguration()
    {
        var config = Configuration(Table().Layout(layout =>
            layout.Position("topStart", position => position.Buttons("copy", "excel"))));

        AssertJson("[[\"copy\",\"excel\"]]", config["layout"]["topStart"]["buttons"]);
    }

    [Theory]
    [InlineData(true)]
    [InlineData(false)]
    public void BuiltInAndCustomButtonsPreserveCallOrder(bool builtInsFirst)
    {
        var config = Configuration(Table().Layout(layout => layout.Position("topStart", position =>
        {
            if (builtInsFirst)
                position.Buttons("copy", "excel");

            position.Button(button => button.Text("Custom"));

            if (!builtInsFirst)
                position.Buttons("copy", "excel");

            position.Buttons("print");
        })));

        var expected = builtInsFirst
            ? "[[\"copy\",\"excel\"],{\"text\":\"Custom\"},[\"print\"]]"
            : "[{\"text\":\"Custom\"},[\"copy\",\"excel\"],[\"print\"]]";
        AssertJson(expected, config["layout"]["topStart"]["buttons"]);
    }

    [Fact]
    public void EmptyButtonsCanBeFollowedByCustomAndBuiltInButtons()
    {
        var config = Configuration(Table().Layout(layout => layout.Position("topStart", position =>
            position.Buttons().Button(button => button.Text("Custom")).Buttons("copy"))));

        AssertJson("[[],{\"text\":\"Custom\"},[\"copy\"]]", config["layout"]["topStart"]["buttons"]);
    }

    [Fact]
    public void LayoutPositionsKeepIndependentButtonsAndPlaceholders()
    {
        var config = Configuration(Table().Layout(layout => layout
            .Position("topStart", position => position.Buttons("copy").Search(s => s.Placeholder("Top")))
            .Position("bottomEnd", position => position.Buttons("print").Search(s => s.Placeholder("Bottom")))));

        AssertJson("{\"buttons\":[[\"copy\"]],\"search\":{\"placeholder\":\"Top\"}}", config["layout"]["topStart"]);
        AssertJson("{\"buttons\":[[\"print\"]],\"search\":{\"placeholder\":\"Bottom\"}}", config["layout"]["bottomEnd"]);
        Assert.Null(config["search"]);
    }

    [Theory]
    [InlineData(true)]
    [InlineData(false)]
    public void SearchBehaviorAndInputOptionsRenderAtTheirRespectiveLevels(bool searchFirst)
    {
        var table = Table();
        if (searchFirst)
            table.Search(search => search.Return(true).DefaultSearch("Alice"));

        table.Layout(layout => layout.Position("topEnd", position => position.Search(s => s.Placeholder("Find"))));

        if (!searchFirst)
            table.Search(search => search.Return(true).DefaultSearch("Alice"));

        var config = Configuration(table);
        AssertJson("{\"return\":true,\"search\":\"Alice\"}", config["search"]);
        AssertJson("{\"search\":{\"placeholder\":\"Find\"}}", config["layout"]["topEnd"]);
    }

    [Theory]
    [InlineData("return", true)]
    [InlineData("return", false)]
    [InlineData("regex", true)]
    [InlineData("regex", false)]
    [InlineData("smart", true)]
    [InlineData("smart", false)]
    [InlineData("boundary", true)]
    [InlineData("boundary", false)]
    [InlineData("caseInsensitive", true)]
    [InlineData("caseInsensitive", false)]
    public void ExplicitSearchFlagsArePreservedWithoutAddingOtherOptions(string option, bool value)
    {
        var config = Configuration(Table().Search(search =>
        {
            switch (option)
            {
                case "return": search.Return(value); break;
                case "regex": search.Regex(value); break;
                case "smart": search.Smart(value); break;
                case "boundary": search.Boundary(value); break;
                case "caseInsensitive": search.CaseInsensitive(value); break;
            }
        }));

        AssertJson(new JObject { [option] = value }.ToString(), config["search"]);
        Assert.Null(config["layout"]);
    }

    [Fact]
    public void UnconfiguredSearchOptionsAreOmitted()
    {
        var config = Configuration(Table().Layout(layout => layout.Position("topStart", p => p.Buttons("copy"))));
        Assert.Null(config["search"]);
        Assert.Null(config["layout"]["topStart"]["search"]);
    }

    [Fact]
    public void EmptySearchCallbacksDoNotOverrideDataTablesDefaults()
    {
        var config = Configuration(Table().Search(_ => { }).Layout(layout =>
            layout.Position("topEnd", position => position.Search(_ => { }))));

        AssertJson("{}", config["search"]);
        AssertJson("{\"search\":{}}", config["layout"]["topEnd"]);
    }

    [Theory]
    [InlineData("")]
    [InlineData("Ara: \"İstanbul\" \\ kayıt\n次")]
    public void SearchStringsRoundTripThroughTheActualScriptRenderer(string text)
    {
        var config = Configuration(Table().Search(search => search.DefaultSearch(text)).Layout(layout =>
            layout.Position("topEnd", position => position.Search(search => search.Placeholder(text)))));

        Assert.Equal(text, (string)config["search"]["search"]);
        Assert.Equal(text, (string)config["layout"]["topEnd"]["search"]["placeholder"]);
    }

    [Theory]
    [InlineData("Return")]
    [InlineData("Regex")]
    [InlineData("Smart")]
    [InlineData("Boundary")]
    [InlineData("CaseInsensitive")]
    [InlineData("DefaultSearch")]
    public void LayoutSearchDoesNotExposeIgnoredBehaviorOptions(string method)
    {
        Assert.Null(typeof(LayoutSearchOptionsBuilder).GetMethod(method));
    }

    [Fact]
    public void GlobalSearchDoesNotExposeIgnoredPlaceholderOption()
    {
        Assert.Null(typeof(SearchOptionsBuilder).GetMethod("Placeholder"));
        Assert.Null(typeof(SearchOptions).GetProperty("Placeholder"));
    }

    [Fact]
    public void CollectionButtonsKeepTheirConfigurationInsideTheLayout()
    {
        var config = Configuration(Table().Layout(layout => layout.Position("topStart", position =>
            position.Buttons("copy").Button(button => button.Extend("collection").Text("Export")
                .Buttons(collection => collection
                    .Button(child => child.Extend("pdf").Text("PDF"))
                    .Button(child => child.Extend("excel").Text("Excel")))))));

        AssertJson("{\"extend\":\"collection\",\"text\":\"Export\",\"buttons\":[{\"extend\":\"pdf\",\"text\":\"PDF\"},{\"extend\":\"excel\",\"text\":\"Excel\"}]}",
            config["layout"]["topStart"]["buttons"][1]);
    }

    [Fact]
    public void CustomButtonActionIsRenderedAsJavaScript()
    {
        const string action = "function () { window.clicked = true; }";
        var script = Table().Layout(layout => layout.Position("topStart", position =>
            position.Buttons("copy").Button(button => button.Text("Custom").Action(action))))
            .RenderScript().ToString();

        Assert.Contains("\"action\": " + action, script);
        Assert.DoesNotContain("\"action\": \"function", script);
    }

    [Fact]
    public void ExistingLayoutAndTopLevelButtonsRemainUsable()
    {
        var config = Configuration(Table().Buttons("copy").Layout(layout => layout
            .Set("bottomEnd", "paging").Top("info", "div")
            .Position("topEnd", position => position.Search(search => search.Placeholder("Find")))));

        AssertJson("[\"copy\"]", config["buttons"]);
        AssertJson("[\"info\",\"div\"]", config["layout"]["top"]);
        Assert.Equal("paging", (string)config["layout"]["bottomEnd"]);
    }

    private static DatatableBuilder<Row> Table() => RKHelperExtensions.DataTable<Row>(null)
        .Name("testTable")
        .Columns(columns => columns.Field(row => row.Name))
        .DataSource(source => source.URL("/data"));

    private static JObject Configuration(DatatableBuilder<Row> table)
    {
        var script = table.RenderScript().ToString();
        var start = script.IndexOf('{');
        var end = script.LastIndexOf('}');
        return JObject.Parse(script.Substring(start, end - start + 1));
    }

    private static void AssertJson(string expected, JToken actual) =>
        Assert.True(JToken.DeepEquals(JToken.Parse(expected), actual), $"Expected: {expected}\nActual: {actual}");

    public class Row
    {
        public string Name { get; set; }
    }
}
