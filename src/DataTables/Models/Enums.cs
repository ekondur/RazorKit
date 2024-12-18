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

    /// <summary>
    /// Column Type
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ColumnType
    {
        /// <summary>
        /// Date / time values. Note that DataTables' built in date parsing works to an ISO 8601 format with 3 separators (/, - and ,).
        /// </summary>
        [EnumMember(Value = "date")]
        Date,

        /// <summary>
        /// Simple number sorting.
        /// </summary>
        [EnumMember(Value = "num")]
        Num,

        /// <summary>
        /// Numeric sorting of formatted numbers. Numbers which are formatted with thousands separators, 
        /// currency symbols or a percentage indicator will be sorted numerically automatically by DataTables.
        /// </summary>
        [EnumMember(Value = "num-fmt")]
        NumFmt,

        /// <summary>
        /// As per the num option, but with HTML tags also in the data.
        /// </summary>
        [EnumMember(Value = "html-num")]
        HtmlNum,

        /// <summary>
        /// As per the num-fmt option, but with HTML tags also in the data.
        /// </summary>
        [EnumMember(Value = "html-num-fmt")]
        HtmlNumFmt,

        /// <summary>
        /// Basic string processing for HTML tags.
        /// </summary>
        [EnumMember(Value = "html")]
        Html,

        /// <summary>
        /// Fall back type if the data in the column does not match the requirements for the other data types.
        /// </summary>
        [EnumMember(Value = "string")]
        String
    }

    /// <summary>
    /// Set the child row display control type.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DetailType
    {
        /// <summary>
        /// Where the first column in the table has additional padding added to it and the :before pseudo element is used to display the button.
        /// </summary>
        [EnumMember(Value = "inline")]
        Inline,

        /// <summary>
        /// Where a whole column is dedicated to the show / hide control.
        /// </summary>
        [EnumMember(Value = "column")]
        Column,

        /// <summary>
        /// Don't show the show / hide icons - typically used when the user's ability to show / hide rows is removed (responsive.details.target).
        /// </summary>
        [EnumMember(Value = "none")]
        None
    }
}
