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
        Cell,

        /// <summary>
        /// Enable row selection with checkbox.
        /// </summary>
        [EnumMember(Value = "row")]
        Checkbox
    }

    /// <summary>
    /// Set select style functionalities.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SelectStyle
    {
        /// <summary>
        /// Select just for single item, to select multiple just click with CTRL button.
        /// </summary>
        [EnumMember(Value = "os")]
        Default,

        /// <summary>
        /// Only single item can be selected.
        /// </summary>
        [EnumMember(Value = "single")]
        Single,

        /// <summary>
        /// Multiple selectable with one click 
        /// </summary>
        [EnumMember(Value = "multi")]
        Multi,

        /// <summary>
        /// Multi-item with rangle selection 
        /// </summary>
        [EnumMember(Value = "multi+shift")]
        MultiShift
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
}
