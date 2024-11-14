using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace RazorKit
{
    /// <summary>
    /// Set which items are selectable (row, column, cell, row with checkbox). Default is row.
    /// </summary>
    public enum SelectItems
    {
        /// <summary>
        /// Enable row selection.
        /// </summary>
        [EnumMember(Value = "row")]
        Row,

        /// <summary>
        /// Enable column selection.
        /// </summary>
        [EnumMember(Value = "column")]
        Column,

        /// <summary>
        /// Enable cell selection.
        /// </summary>
        [EnumMember(Value = "cell")]
        Cell
    }

    /// <summary>
    /// Set select style functionalities.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SelectStyle
    {
        /// <summary>
        /// Operating System (OS) style selection. 
        /// This is the most comprehensive option and provides complex behaviours such as ctrl/cmd clicking to select / deselect individual items, 
        /// shift clicking to select ranges and an unmodified click to select a single item.
        /// </summary>
        [EnumMember(Value = "os")]
        OS,

        /// <summary>
        /// Only a single item can be selected, any other selected items will be automatically deselected when a new item is selected.
        /// </summary>
        [EnumMember(Value = "single")]
        Single,

        /// <summary>
        /// Multiple items can be selected. Selection is performed by simply clicking on the items to be selected.
        /// </summary>
        [EnumMember(Value = "multi")]
        Multi,

        /// <summary>
        /// A hybrid between the os style and multi, allowing easy multi-row selection without immediate de-selection when clicking on a row.
        /// </summary>
        [EnumMember(Value = "multi+shift")]
        MultiShift,

        /// <summary>
        /// Selection can only be performed via the API.
        /// </summary>
        [EnumMember(Value = "api")]
        Api
    }

    public enum Operand
    {
        Equal,
        NotEqual,
        GreaterThan,
        LessThan,
        GreaterThanOrEqual,
        LessThanOrEqual,
        Contains,
        StartsWith,
        EndsWith
    }

    public enum Convention
    {
        CamelCase,
        PascalCase
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum OrderBy
    {
        [EnumMember(Value = "asc")]
        Ascending,

        [EnumMember(Value = "desc")]
        Descending
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Layouts
    {
        /// <summary>
        /// Table information summary.
        /// </summary>
        [EnumMember(Value = "info")]
        Info,

        /// <summary>
        /// Page length control.
        /// </summary>
        [EnumMember(Value = "pageLength")]
        PageLength,

        /// <summary>
        /// User input control for paging.
        /// </summary>
        [EnumMember(Value = "paging")]
        Paging,

        /// <summary>
        /// Search input box.
        /// </summary>
        [EnumMember(Value = "search")]
        Search,

        /// <summary>
        /// Buttons extension.
        /// </summary>
        [EnumMember(Value = "buttons")]
        Buttons,

        /// <summary>
        /// A simple placeholder element.
        /// </summary>
        [EnumMember(Value = "div")]
        Div,

        Null
    }
}
