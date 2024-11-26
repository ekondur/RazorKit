#if NETCOREAPP
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Html;
#else
using System;
using System.Web.Mvc;
#endif

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using RazorKit.ChartJs.Builders;

namespace RazorKit
{
    /// <summary>
    /// RazorKit Html helper extension.
    /// </summary>
    public static partial class RKHelperExtensions
    {
        /// <summary>
        /// Chart Configuration.
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <param name="canvasId"></param>
        /// <returns></returns>

#if NETCOREAPP
        public static ChartBuilder Chart(this IHtmlHelper htmlHelper, string canvasId)
#else
        public static ChartBuilder Chart(this HtmlHelper htmlHelper, string canvasId)
#endif
        {
            return new ChartBuilder(canvasId);
        }

        /// <summary>
        /// Chart Configuration.
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <param name="canvasId"></param>
        /// <param name="useCanvas"></param>
        /// <returns></returns>
#if NETCOREAPP
        public static ChartBuilder Chart(this IHtmlHelper htmlHelper, string canvasId, bool useCanvas)
#else
        public static ChartBuilder Chart(this HtmlHelper htmlHelper, string canvasId, bool useCanvas)
#endif
        {
            return new ChartBuilder(canvasId, useCanvas);
        }

        /// <summary>
        /// Get Html string of chart.
        /// </summary>
        /// <param name="builder"></param>
        /// <returns></returns>

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
