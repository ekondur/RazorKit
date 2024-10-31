﻿#if NETCOREAPP
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Html;
#else
using System;
using System.Web.Mvc;
#endif

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using RazorKit.Datatable.Builders;
using System.Linq;
using RazorKit.Datatable.Models;

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
        /// Render both html and script
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="builder"></param>
        /// <returns></returns>
#if NETCOREAPP
        public static IHtmlContent Render<T>(this DatatableBuilder<T> builder)
#else
        public static MvcHtmlString Render<T>(this DatatableBuilder<T> builder)
#endif
        {
#if NETCOREAPP
            return new HtmlString(RenderHtmlString(builder)+ "\n" + RenderScriptString(builder));
#else
            return new MvcHtmlString(RenderHtmlString(builder)+ "\n" + RenderScriptString(builder));
#endif
        }

        /// <summary>
        /// Render only script
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="builder"></param>
        /// <returns></returns>

#if NETCOREAPP
        public static IHtmlContent RenderScript<T>(this DatatableBuilder<T> builder) 
#else
        public static MvcHtmlString RenderScript<T>(this DatatableBuilder<T> builder)
#endif
        {
            var script = RenderScriptString(builder);
#if NETCOREAPP
            return new HtmlString(script);
#else
            return new MvcHtmlString(script);
#endif
        }

        /// <summary>
        /// Render only html 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="builder"></param>
        /// <returns></returns>

#if NETCOREAPP
        public static IHtmlContent RenderHtml<T>(this DatatableBuilder<T> builder)
#else
        public static MvcHtmlString RenderHtml<T>(this DatatableBuilder<T> builder)
#endif
        {
            var html = RenderHtmlString(builder);
#if NETCOREAPP
            return new HtmlString(html);
#else
            return new MvcHtmlString(html);
#endif
        }

        private static string RenderHtmlString<T>(DatatableBuilder<T> builder)
        {
            //var tfoot = datatable._columnSearching ?
            //    $@"<tfoot style=""display: table-header-group;"">
            //                <tr class=""filters"">
            //                    {string.Join("\n", datatable._columns.Select(a => string.Format("<th>{0}</th>", a.Searchable ? $"<input type=\"{((a.Type == typeof(DateTime?) || a.Type == typeof(DateTime)) && datatable._serverSide ? "date" : "text")}\" style=\"width:100%\" placeholder=\"{a.Title}\" class=\"{datatable._columnSearchingCss}\" />" : "<input style=\"display:none\" />")))}
            //                </tr>
            //            </tfoot>"
            //    : string.Empty;

            return $@"
                    <table id=""{builder.Datatable.Name}"" class=""{builder.Datatable.Style}"" style=""width:100%"">
                        <thead>
                            <tr>
                                {string.Join("\n",
                                builder.Datatable.Columns.Select(a => true && SelectItems.Cell == SelectItems.Checkbox && a.ClassName == "select-checkbox"
                                    ? $"<th style=\"text-align:center\"><input type=\"checkbox\" id=\"{builder.Datatable.Name}_SelectAll\"></th>"
                                    : string.Format("<th>{0}</th>", a.Title)))}
                            </tr>
                        </thead>
                        
                    </table>";
        }

        private static string RenderScriptString<T>(DatatableBuilder<T> builder)
        {
            builder.Datatable.Ajax.Data = GetDataStr(builder.Datatable);
            RenderCommands(builder.Datatable);

            var contractResolver = new DefaultContractResolver
            {
                NamingStrategy = new CamelCaseNamingStrategy()
            };

            return $@"
            <script>
                $('#{builder.Datatable.Name}').DataTable(
                        {JsonConvert.SerializeObject(builder.Datatable, Formatting.Indented,
                            new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore, ContractResolver = contractResolver })}
                );
            </script>";
        }

        private static string GetDataStr(DatatableJs datatable)
        {
            if (datatable.Filters.Count == 0 && string.IsNullOrEmpty(datatable.Ajax.Data))
            {
                return null;
            }

            var filters = string.Format("d.filters = {0}{1}", JsonConvert.SerializeObject(datatable.Filters), string.IsNullOrEmpty(datatable.Ajax.Data) ? string.Empty : ",");

            return $@"function (d) {{
                    {(datatable.Filters.Count > 0 ? filters : string.Empty)}
                    {(string.IsNullOrEmpty(datatable.Ajax.Data) ? string.Empty : string.Format("d.data = {0}()", datatable.Ajax.Data))}
                    }}";
        }

        private static void RenderCommands(DatatableJs datatable)
        {
            foreach (var command in datatable.Commands)
            {
                datatable.Columns.Add(new Column
                {
                    Orderable = false,
                    Searchable = false,
                    Width = command.Width,
                    DefaultContent = $"<a href=\"#\" class=\"{command.BtnClass}\" onclick=\"{command.OnClick}(this)\"><i class=\"{command.IconClass}\"></i>{command.Text}</a>"
                });
            }
        }
    }
}
