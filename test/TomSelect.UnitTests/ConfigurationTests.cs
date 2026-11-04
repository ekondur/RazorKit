using Newtonsoft.Json.Linq;
using RazorKit.TomSelect.Builders;
using Xunit;

namespace RazorKit.TomSelect.UnitTests;

public class ConfigurationTests
{
    private static TomSelectBuilder Select() => new("test");
    private static JObject Config(TomSelectBuilder builder) => JObject.Parse(builder.ToConfiguration());

    [Fact]
    public void DefaultsAreLeftToTomSelect() => Assert.Empty(Config(Select()));

    [Fact]
    public void ExplicitNullAndFalseArePreserved()
    {
        var config = Config(Select().MaxItems(null).MaxOptions(null).LoadThrottle(null).Create(false).Persist(false).ControlInput(null));
        Assert.Equal(JTokenType.Null, config["maxItems"].Type);
        Assert.Equal(JTokenType.Null, config["maxOptions"].Type);
        Assert.Equal(JTokenType.Null, config["loadThrottle"].Type);
        Assert.Equal(JTokenType.Null, config["controlInput"].Type);
        Assert.False((bool)config["create"]);
        Assert.False((bool)config["persist"]);
    }

    [Fact]
    public void CustomDataFieldNamesAndTypesArePreserved()
    {
        var config = Config(Select().ValueField("Id").LabelField("Name").Options(new[] { new { Id = 7, Name = "Seven", Metadata = new { IsActive = true } } }));
        Assert.Equal(7, (int)config["options"][0]["Id"]);
        Assert.True((bool)config["options"][0]["Metadata"]["IsActive"]);
        Assert.Null(config["options"][0]["id"]);
    }

    [Fact]
    public void FluentOptionsRespectFieldMappings()
    {
        var config = Config(Select().ValueField("id").LabelField("name").OptgroupField("group")
            .OptgroupValueField("key").OptgroupLabelField("title")
            .Options(o => o.Add("a", "Alpha", "g", true)).Optgroups(g => g.Add("g", "Group")));
        Assert.Equal("Alpha", (string)config["options"][0]["name"]);
        Assert.Equal("g", (string)config["options"][0]["group"]);
        Assert.True((bool)config["options"][0]["disabled"]);
        Assert.Equal("Group", (string)config["optgroups"][0]["title"]);
    }

    [Fact]
    public void SearchAndSortSupportWeightedOrderedFields()
    {
        var config = Config(Select().SearchField(s => s.Add("name", 2).Add("description", .5))
            .SortField(s => s.Add("$score", "desc").Add("name")).SearchConjunction("or"));
        Assert.Equal(.5, (double)config["searchField"][1]["weight"]);
        Assert.Equal("desc", (string)config["sortField"][0]["direction"]);
        Assert.Equal("or", (string)config["searchConjunction"]);
        Assert.Empty(Config(Select().SearchField())["searchField"]);
    }

    [Fact]
    public void RawExpressionsAreExplicitAndOrdinaryStringsRemainQuoted()
    {
        var config = Select().Placeholder("function(){alert(1)}").Create("makeOption")
            .CreateFilter(new JavaScript("/^[a-z]+$/")).Callbacks(c => c.OnChange("onChanged"))
            .Templates(t => t.Option("renderOption")).ToConfiguration();
        Assert.Contains("\"placeholder\":\"function(){alert(1)}\"", config);
        Assert.Contains("\"create\":makeOption", config);
        Assert.Contains("\"createFilter\":/^[a-z]+$/", config);
        Assert.Contains("\"onChange\":onChanged", config);
        Assert.Contains("\"option\":renderOption", config);
    }

    [Fact]
    public void ScriptContentAndHtmlAttributesCannotBeBrokenOutOfByData()
    {
        const string attack = "</script><script>alert('x')</script>\u2028\u2029";
        var builder = Select().Id("x\" onfocus=\"alert(1)").Placeholder(attack)
            .Options(o => o.Add("\"<", attack)).Attribute("data-info", "\" onfocus=\"x");
        Assert.DoesNotContain("</script", builder.ToConfiguration());
        Assert.Contains("\\u003c", builder.ToConfiguration());
        Assert.Contains("&quot;", builder.ToHtml());
        Assert.DoesNotContain("<script>", builder.ToHtml());
        Assert.Contains("document.getElementById(\"x\\u0022", builder.ToScript());
    }

    [Theory]
    [InlineData("function(){return '</ScRiPt >';}")]
    [InlineData("<!-- ignored")]
    [InlineData("")]
    public void RawScriptRejectsHtmlDelimiters(string expression) => Assert.Throws<ArgumentException>(() => new JavaScript(expression));

    [Fact]
    public void SelectionAndHtmlFlagsAreRenderedCorrectly()
    {
        var html = Select().Multiple().Options(o => o.Add("a", "Alpha").Add("b", "Beta", disabled: true))
            .Items("a").Required().Disabled(false).HtmlAttributes(new { @class = "form-select", data_test = "value" }).ToHtml();
        Assert.Contains("multiple=\"multiple\"", html);
        Assert.Contains("required=\"required\"", html);
        Assert.Contains("data-test=\"value\"", html);
        Assert.Contains("<option value=\"a\" selected=\"selected\">Alpha</option>", html);
        Assert.Contains("<option value=\"b\" disabled=\"disabled\">Beta</option>", html);
    }

    [Fact]
    public void RemoteInitialValuesAreRenderedEvenWithoutLocalOptions()
    {
        Assert.Contains("<option value=\"42\" selected=\"selected\">42</option>", Select().Items("42").ToHtml());
    }

    [Theory]
    [InlineData("name")]
    [InlineData("ID")]
    [InlineData("multiple")]
    [InlineData("x onclick")]
    public void ReservedOrInvalidAttributesAreRejected(string name) => Assert.Throws<ArgumentException>(() => Select().Attribute(name, "value"));

    [Fact]
    public void PluginsPreserveOrderAndCustomSettings()
    {
        var config = Config(Select().Plugins(p => p.RemoveButton(o => o.Title("Remove")).ClearButton().Add("custom", o => o.Set("enabled", false))));
        Assert.Equal(new[] { "remove_button", "clear_button", "custom" }, ((JObject)config["plugins"]).Properties().Select(p => p.Name));
        Assert.Equal("Remove", (string)config["plugins"]["remove_button"]["title"]);
        Assert.False((bool)config["plugins"]["custom"]["enabled"]);
    }

    [Fact]
    public void EventsNotRecognizedByConstructorAreRegisteredOnInstance()
    {
        var builder = Select().Callbacks(c => c.OnDestroy("destroyed").OnItemSelect("selected"));
        Assert.DoesNotContain("onDestroy", builder.ToConfiguration());
        Assert.Contains("control.on(\"destroy\",destroyed)", builder.ToScript());
        Assert.Contains("control.on(\"item_select\",selected)", builder.ToScript());
    }

    [Fact]
    public void RemoteSourceSupportsNestedResultsPostHeadersAndTransforms()
    {
        var script = Select().DataSource(ds => ds.Url("/search?existing=1").Method("post").QueryParameter("term")
            .ResultsField("data.items").OptgroupsField("data.groups").MinimumQueryLength(3)
            .Header("RequestVerificationToken", "a\"b").Parameter("parent", new JavaScript("getParent()"))
            .Transform("transformResults").OnError("reportError")).ToConfiguration();
        Assert.Contains("query.length >= 3", script);
        Assert.Contains("\"method\":\"POST\"", script);
        Assert.Contains("\"results\":\"data.items\"", script);
        Assert.Contains("\"parent\":getParent()", script);
        Assert.Contains("transform = transformResults", script);
        Assert.Contains("onError = reportError", script);
    }

    [Fact]
    public void InvalidRemoteConfigurationFailsEarly()
    {
        Assert.Throws<InvalidOperationException>(() => Select().DataSource(ds => ds.MinimumQueryLength(2)));
        Assert.Throws<ArgumentException>(() => Select().DataSource(ds => ds.Url("/").Method("DELETE")));
        Assert.Throws<ArgumentOutOfRangeException>(() => Select().DataSource(ds => ds.Url("/").MinimumQueryLength(-1)));
    }

    [Fact]
    public void RenderScriptSupportsNonceAndSeparateInitialization()
    {
        var builder = Select().ScriptNonce("a\"b");
        Assert.StartsWith("<script nonce=\"a&quot;b\">", builder.ToScript());
        Assert.DoesNotContain("<script", builder.ToScript(false));
        Assert.Contains("element.tomselect", builder.ToScript());
        Assert.Contains("DOMContentLoaded", builder.ToScript());
    }
}
