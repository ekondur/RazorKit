#if NETCOREAPP
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Html;
#else
using System;
using System.Web.Mvc;
#endif

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
        public static DatatableBuilder Datatable(this IHtmlHelper htmlHelper)
#else
        public static DatatableBuilder Datatable(this HtmlHelper htmlHelper)
#endif
        {
            return new DatatableBuilder();
        }
    }
}
