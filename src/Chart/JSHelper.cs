#if NETCOREAPP
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Html;
#else
using System;
using System.Web.Mvc;
#endif

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using HelperJS.Chart.Builders;

namespace HelperJS
{
    public partial class JSHelper
    {
        public ChartBuilder Chart()
        {
            return new ChartBuilder();
        }
    }

    public static class JSHelperExtension
    {
#if NETCOREAPP
        public static JSHelper JS(this IHtmlHelper htmlHelper)
        {
            return new JSHelper();
        }
#else
        public static JSHelper JS(this HtmlHelper htmlHelper)
        {
            return new JSHelper();
        }
#endif

#if NETCOREAPP
        public static IHtmlContent Render(this ChartBuilder builder) 
#else
        public static MvcHtmlString Render(this ChartBuilder builder)
#endif
        {
            var contractResolver = new DefaultContractResolver
            {
                NamingStrategy = new CamelCaseNamingStrategy()
            };

            var canvas = $@"<canvas id=""{builder.CanvasId}""></canvas>";

            var script = $@"
<script>
    new Chart(document.getElementById('{builder.CanvasId}'),
            {JsonConvert.SerializeObject(builder.Chart, Formatting.Indented, 
                new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore, ContractResolver = contractResolver })
            }
    );
</script>
";
#if NETCOREAPP
            return new HtmlString(builder.UseCanvas ? canvas + script : script);
#else
            return new MvcHtmlString(builder.UseCanvas ? canvas + script : script);
#endif
        }
    }
}
