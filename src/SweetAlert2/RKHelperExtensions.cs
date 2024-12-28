#if NETCOREAPP
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Html;
#else
using System;
using System.Web.Mvc;
#endif

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using RazorKit.SweetAlert2.Builders;

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
        /// <returns></returns>

#if NETCOREAPP
        public static SwalBuilder Swal(this IHtmlHelper htmlHelper)
#else
        public static SwalBuilder Swal(this HtmlHelper htmlHelper)
#endif
        {
            return new SwalBuilder();
        }

        /// <summary>
        /// Fire swal.
        /// </summary>
        /// <param name="builder"></param>
        /// <returns></returns>

#if NETCOREAPP
        public static IHtmlContent Fire(this SwalBuilder builder) 
#else
        public static MvcHtmlString Fire(this SwalBuilder builder)
#endif
        {
            var contractResolver = new DefaultContractResolver
            {
                NamingStrategy = new CamelCaseNamingStrategy()
            };

            var script = $@"
    Swal.fire(
            {JsonConvert.SerializeObject(builder.Swal, Formatting.Indented,
                new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore, ContractResolver = contractResolver })}
    );";

#if NETCOREAPP
            return new HtmlString(script);
#else
            return new MvcHtmlString(script);
#endif
        }

        /// <summary>
        /// Fire swal.
        /// </summary>
        /// <param name="builder"></param>
        /// <returns></returns>

#if NETCOREAPP
        public static IHtmlContent Render(this SwalBuilder builder) 
#else
        public static MvcHtmlString Render(this SwalBuilder builder)
#endif
        {
            var contractResolver = new DefaultContractResolver
            {
                NamingStrategy = new CamelCaseNamingStrategy()
            };

            var script = JsonConvert.SerializeObject(builder.Swal, Formatting.Indented,
        new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore, ContractResolver = contractResolver });

#if NETCOREAPP
            return new HtmlString(script);
#else
            return new MvcHtmlString(script);
#endif
        }
    }
}
