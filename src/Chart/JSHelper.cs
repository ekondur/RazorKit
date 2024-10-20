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
    /// <summary>
    /// JSHelper
    /// </summary>
    public partial class JSHelper
    {
        /// <summary>
        /// Chart Configuration.
        /// </summary>
        /// <param name="canvasId"></param>
        /// <returns></returns>
        public ChartBuilder Chart(string canvasId)
        {
            return new ChartBuilder(canvasId);
        }

        /// <summary>
        /// Chart Configuration.
        /// </summary>
        /// <param name="canvasId"></param>
        /// <param name="useCanvas"></param>
        /// <returns></returns>
        public ChartBuilder Chart(string canvasId, bool useCanvas)
        {
            return new ChartBuilder(canvasId, useCanvas);
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
