﻿using Newtonsoft.Json;
using RazorKit.Datatable.Converters;
using System.Collections.Generic;

namespace RazorKit.Datatable.Models
{
    internal class DatatableJs
    {
        public bool? Processing { get; set; }
        public bool? ScrollX { get; set; }
        public bool? StateSave { get; set; }
        public bool? ServerSide { get; set; }
        public bool? Ordering { get; set; }
        public bool? Searching { get; set; }
        public bool? Paging { get; set; }
        public string Dom { get; set; }
        public string Caption { get; set; }
        public int? PageLength { get; set; }

        public IList<object[]> Order { get; set; }
        public IList<object> Data { get; set; }
        public IList<Column> Columns { get; set; } = new List<Column>();
        public IList<IList<object>> LengthMenu { get; set; }
        public IList<object> Buttons { get; set; }

        public Language Language { get; set; }
        public AjaxSource Ajax { get; set; }
        public Layout Layout { get; set; }

        [JsonConverter(typeof(ObjectOrTypeConverter<FixedColumns>))]
        public object FixedColumns { get; set; }

        [JsonConverter(typeof(NoQuotesStringConverter))]
        public string CreatedRow { get; set; }

        [JsonConverter(typeof(NoQuotesStringConverter))]
        public string DrawCallback { get; set; }

        [JsonConverter(typeof(NoQuotesStringConverter))]
        public string FooterCallback { get; set; }

        [JsonConverter(typeof(NoQuotesStringConverter))]
        public string FormatNumber { get; set; }

        [JsonConverter(typeof(NoQuotesStringConverter))]
        public string HeaderCallback { get; set; }

        [JsonConverter(typeof(NoQuotesStringConverter))]
        public string InfoCallback { get; set; }

        [JsonConverter(typeof(NoQuotesStringConverter))]
        public string PreDrawCallback { get; set; }

        [JsonConverter(typeof(NoQuotesStringConverter))]
        public string RowCallback { get; set; }

        [JsonConverter(typeof(NoQuotesStringConverter))]
        public string StateLoadCallback { get; set; }

        [JsonConverter(typeof(NoQuotesStringConverter))]
        public string StateLoadParams { get; set; }

        [JsonConverter(typeof(NoQuotesStringConverter))]
        public string StateLoaded { get; set; }

        [JsonConverter(typeof(NoQuotesStringConverter))]
        public string StateSaveCallback { get; set; }

        [JsonConverter(typeof(NoQuotesStringConverter))]
        public string StateSaveParams { get; set; }

        [JsonConverter(typeof(ObjectOrTypeConverter<Select>))]
        public object Select { get; set; }

        [JsonConverter(typeof(ObjectOrTypeConverter<ColReorder>))]
        public object ColReorder { get; set; }

        [JsonConverter(typeof(ObjectOrTypeConverter<RowReorder>))]
        public object RowReorder { get; set; }

        [JsonConverter(typeof(ObjectOrTypeConverter<KeyTable>))]
        public object Keys { get; set; }

        [JsonConverter(typeof(NoQuotesStringConverter))]
        public string InitComplete { get; set; }

        [JsonConverter(typeof(ObjectOrTypeConverter<FixedHeader>))]
        public object FixedHeader { get; set; }

        [JsonConverter(typeof(ObjectOrTypeConverter<Responsive>))]
        public object Responsive { get; set; }

        internal string Style { get; set; } = "display dataTable";
        internal IList<Filter> Filters { get; set; } = new List<Filter>();
        internal string Name { get; set; } = "DataTableId";
        internal IList<Command> Commands { get; set; } = new List<Command>();
        internal CommandGroup CommandGroup { get; set; }
    }
}
