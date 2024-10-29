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
        public FixedColumns FixedColumns { get; set; }
        public IList<object[]> Order { get; set; }
        public bool? Ordering { get; set; }
        public bool? Searching { get; set; }
        public bool? Paging { get; set; }
        public string Dom { get; set; }

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

        public int? PageLength { get; set; }
        public Language Language { get; set; }
        public Ajax Ajax { get; set; }
        public IList<Column> Columns { get; set; } = new List<Column>();
        public Select Select { get; set; }

        [JsonConverter(typeof(ObjectOrTypeConverter<ColReorder>))]
        public object ColReorder { get; set; }

        [JsonConverter(typeof(NoQuotesStringConverter))]
        public string InitComplete { get; set; }

        public object[] LengthMenu { get; set; }
        internal string Style { get; set; }
    }
}