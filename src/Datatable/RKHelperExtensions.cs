#if NETCOREAPP
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Html;
#else
using System.Web.Mvc;
#endif

using System;
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
            return new MvcHtmlString(RenderHtmlString(builder) + "\n" + RenderScriptString(builder));
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
                                {string.Join("\n", builder.Datatable.Columns.Select(a => string.Format("<th>{0}</th>", a.Title)))}
                            </tr>
                        </thead>
                    </table>";
        }

        private static string RenderScriptString<T>(DatatableBuilder<T> builder)
        {
            builder.Datatable.Ajax.Data = GetDataStr(builder.Datatable);
            RenderCommands(builder.Datatable);
            RenderCommandGroup(builder.Datatable);
            RenderDataNames(builder.Datatable);

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

        private static void RenderCommandGroup(DatatableJs datatable)
        {
            if (datatable.CommandGroup == null)
            {
                return;
            }

            datatable.Columns.Add(new Column
            {
                Orderable = false,
                Searchable = false,
                Width = datatable.CommandGroup.Width,
                DefaultContent = $@"<div class=""btn-group"">
                        <button type=""button"" class=""{datatable.CommandGroup.BtnClass} dropdown-toggle"" data-toggle=""dropdown"" data-bs-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                            {datatable.CommandGroup.Text ?? ""} <span class=""{datatable.CommandGroup.IconClass}""></span>
                        </button>
                        <div class=""dropdown-menu"">
                        {string.Join(Environment.NewLine,
                    datatable.CommandGroup.Items.Select(a => $@"<a class=""dropdown-item"" href=""#"" onclick=""{a.OnClick}();return false;"">{a.Text}</a>"))}
                        </div>
                    </div>"
            });
        }

        private static void RenderDataNames(DatatableJs datatable)
        {
            foreach (var column in datatable.Columns.Where(x => x.Data != null))
            {
                switch (datatable.Ajax.Convention)
                {
                    case Convention.CamelCase:
                        column.Data = char.ToLowerInvariant(column.Data[0]) + column.Data.Substring(1);
                        break;
                    case Convention.PascalCase:
                        column.Data = char.ToUpperInvariant(column.Data[0]) + column.Data.Substring(1);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
