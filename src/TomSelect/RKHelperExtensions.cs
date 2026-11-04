using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using RazorKit.TomSelect.Builders;
#if NETCOREAPP
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Html;
using Microsoft.Extensions.DependencyInjection;
using System.IO;
using System.Text.Encodings.Web;
using HtmlResult = Microsoft.AspNetCore.Html.IHtmlContent;
#else
using System.Web.Mvc;
using System.Web.Mvc.Html;
using HtmlResult = System.Web.Mvc.MvcHtmlString;
#endif

namespace RazorKit
{
    /// <summary>Razor helpers for Tom Select.</summary>
    public static partial class RKHelperExtensions
    {
        /// <summary>Creates an unbound Tom Select control with the given form field name.</summary>
#if NETCOREAPP
        public static TomSelectBuilder TomSelect(this IHtmlHelper html, string name)
#else
        public static TomSelectBuilder TomSelect(this HtmlHelper html, string name)
#endif
            => new TomSelectBuilder(name);

        /// <summary>Creates a model-bound select with MVC naming, validation and ModelState precedence.</summary>
#if NETCOREAPP
        public static TomSelectBuilder TomSelectFor<TModel, TValue>(this IHtmlHelper<TModel> html, Expression<Func<TModel, TValue>> expression)
#else
        public static TomSelectBuilder TomSelectFor<TModel, TValue>(this HtmlHelper<TModel> html, Expression<Func<TModel, TValue>> expression)
#endif
        {
            if (expression == null) throw new ArgumentNullException(nameof(expression));
            var name = html.NameFor(expression).ToString();
            var builder = new TomSelectBuilder(name).Id(html.IdFor(expression).ToString());
            builder.ModelBound = true;
            builder.IsMultiple = typeof(TValue) != typeof(string) && typeof(IEnumerable).IsAssignableFrom(typeof(TValue));
            builder.HtmlFactory = current =>
            {
                object value;
#if NETCOREAPP
                var provider = html.ViewContext.HttpContext.RequestServices.GetRequiredService<IModelExpressionProvider>();
                value = provider.CreateModelExpression(html.ViewData, expression).ModelExplorer.Model;
                if (html.ViewData.ModelState.TryGetValue(name, out var state) && state.RawValue != null) value = state.RawValue;
#else
                value = ModelMetadata.FromLambdaExpression(expression, html.ViewData).Model;
                if (html.ViewData.ModelState.TryGetValue(name, out var state) && state.Value != null) value = state.Value.RawValue;
#endif
                var options = current.SelectOptions(TomSelectBuilder.Values(value)).Select(option => new SelectListItem
                {
                    Value = option.Value, Text = option.Text, Selected = option.Selected, Disabled = option.Disabled
                }).ToList();
                var attributes = new Dictionary<string, object>(current.Attributes) { ["id"] = current.ElementId };
                var result = current.IsMultiple
                    ? html.ListBoxFor(expression, options, attributes)
                    : html.DropDownListFor(expression, options, attributes);
#if NETCOREAPP
                using (var writer = new StringWriter())
                {
                    result.WriteTo(writer, HtmlEncoder.Default);
                    return writer.ToString();
                }
#else
                return result.ToHtmlString();
#endif
            };
            return builder;
        }

        /// <summary>Renders the select and its initialization script. Load Tom Select separately.</summary>
        public static HtmlResult Render(this TomSelectBuilder builder) => Content(builder.ToHtml() + "\n" + builder.ToScript());
        /// <summary>Renders only the select element.</summary>
        public static HtmlResult RenderHtml(this TomSelectBuilder builder) => Content(builder.ToHtml());
        /// <summary>Renders only the initialization, with an optional script tag.</summary>
        public static HtmlResult RenderScript(this TomSelectBuilder builder, bool includeScriptTag = true) => Content(builder.ToScript(includeScriptTag));
        /// <summary>Renders a JavaScript configuration object for custom initialization.</summary>
        public static HtmlResult RenderConfiguration(this TomSelectBuilder builder) => Content(builder.ToConfiguration());

        private static HtmlResult Content(string value)
        {
#if NETCOREAPP
            return new HtmlString(value);
#else
            return MvcHtmlString.Create(value);
#endif
        }
    }
}
