#if NETCOREAPP
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Html;
#else
using System;
using System.Web.Mvc;
#endif

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using RazorKit.Chart.Builders;

namespace RazorKit
{
    /// <summary>
    /// JSHelper
    /// </summary>
    public partial class RKHelper
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

    /// <summary>
    /// RazorKit Html helper extension.
    /// </summary>
    public static class RKHelperExtension
    {
#if NETCOREAPP
        /// <summary>
        /// Get an instance of RazorKit Html Helper.
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <returns></returns>
        public static RKHelper RK(this IHtmlHelper htmlHelper)
        {
            return new RKHelper();
        }
#else
        /// <summary>
        /// Get an instance of RazorKit Html helper.
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <returns></returns>
        public static RKHelper RK(this HtmlHelper htmlHelper)
        {
            return new RKHelper();
        }
#endif

#if NETCOREAPP
        /// <summary>
        /// Get Html string of chart.
        /// </summary>
        /// <param name="builder"></param>
        /// <returns></returns>
        public static IHtmlContent Render(this ChartBuilder builder) 
#else
        /// <summary>
        /// Get Html string of chart.
        /// </summary>
        /// <param name="builder"></param>
        /// <returns></returns>
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
