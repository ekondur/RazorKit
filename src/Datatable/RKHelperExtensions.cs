#if NETCOREAPP
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Html;
#else
using System;
using System.Web.Mvc;
#endif

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using RazorKit.Datatable.Builders;

namespace RazorKit
{
    /// <summary>
    /// RazorKit Html helper extension.
    /// </summary>
    public static partial class RKHelperExtensions
    {
        /// <summary>
        /// Datatable Configuration.
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <returns></returns>

#if NETCOREAPP
        public static DatatableBuilder<T> DataTable<T>(this IHtmlHelper htmlHelper) where T : class
#else
        public static DatatableBuilder<T> DataTable<T>(this HtmlHelper htmlHelper) where T : class
#endif
        {
            return new DatatableBuilder<T>();
        }

        /// <summary>
        /// Get Html string of chart.
        /// </summary>
        /// <param name="builder"></param>
        /// <returns></returns>

#if NETCOREAPP
        public static IHtmlContent Render<T>(this DatatableBuilder<T> builder) 
#else
        public static MvcHtmlString Render<T>(this DatatableBuilder<T> builder)
#endif
        {
            var contractResolver = new DefaultContractResolver
            {
                NamingStrategy = new CamelCaseNamingStrategy()
            };

            var script = $@"
<script>
    $('#{builder.Id}').DataTable(
            {JsonConvert.SerializeObject(builder.Datatable, Formatting.Indented,
                new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore, ContractResolver = contractResolver })}
    );
</script>
";
#if NETCOREAPP
            return new HtmlString(script);
#else
            return new MvcHtmlString(script);
#endif
        }
    }
}
