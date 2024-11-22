using Newtonsoft.Json;
using RazorKit.Datatable.Converters;
using System.Collections.Generic;

namespace RazorKit.Datatable.Models
{
    internal class Button
    {
        [JsonConverter(typeof(NoQuotesStringConverter))]
        public string Action { get; set; }

        public int? Async { get; set; }
        public ButtonAttr Attr { get; set; }

        [JsonConverter(typeof(NoQuotesStringConverter))]
        public string Available { get; set; }

        public string ClassName { get; set; }

        [JsonConverter(typeof(NoQuotesStringConverter))]
        public string Destroy { get; set; }

        public bool? DropIcon { get; set; }
        public bool? Enabled { get; set; }
        public string Extend { get; set; }

        [JsonConverter(typeof(NoQuotesStringConverter))]
        public string Init { get; set; }

        [JsonConverter(typeof(ObjectOrTypeConverter<ButtonKey>))]
        public object Key { get; set; }

        public string Name { get; set; }
        public string Namespace { get; set; }
        public IList<object> Split { get; set; }
        public IList<object> Buttons { get; set; }
        public string Tag { get; set; }
        public string Text { get; set; }
        public string TitleAttr { get; set; }
    }

    internal class ButtonAttr
    {
        public string Title { get; set; }
        public string Id { get; set; }
    }

    internal class ButtonKey
    {
        public string Key { get; set; }
        public bool? AltKey { get; set; }
    }
}
