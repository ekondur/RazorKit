using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace RazorKit
{
    /// <summary>
    /// Icons
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SwalIcon
    {
        [EnumMember(Value = "success")]
        Success,

        [EnumMember(Value = "error")]
        Error,

        [EnumMember(Value = "warning")]
        Warning,

        [EnumMember(Value = "info")]
        Info,

        [EnumMember(Value = "question")]
        Question
    }

    /// <summary>
    /// Input Types
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SwalInput
    {
        [EnumMember(Value = "text")]
        Text,

        [EnumMember(Value = "email")]
        Email,

        [EnumMember(Value = "password")]
        Password,

        [EnumMember(Value = "number")]
        Number,

        [EnumMember(Value = "tel")]
        Tel,

        [EnumMember(Value = "url")]
        Url,

        [EnumMember(Value = "textarea")]
        TextArea,

        [EnumMember(Value = "select")]
        Select,

        [EnumMember(Value = "radio")]
        Radio,

        [EnumMember(Value = "checkbox")]
        CheckBox,

        [EnumMember(Value = "date")]
        Date,

        [EnumMember(Value = "datetime-local")]
        DateTimeLocal,

        [EnumMember(Value = "time")]
        Time,

        [EnumMember(Value = "week")]
        Week,

        [EnumMember(Value = "month")]
        Month,

        [EnumMember(Value = "file")]
        File,

        [EnumMember(Value = "range")]
        Range,

        [EnumMember(Value = "search")]
        Search
    }

    /// <summary>
    /// Positions.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SwalPosition
    {
        [EnumMember(Value = "top")]
        Top,

        [EnumMember(Value = "top-start")]
        TopStart,

        [EnumMember(Value = "top-end")]
        TopEnd,

        [EnumMember(Value = "center")]
        Center,

        [EnumMember(Value = "center-start")]
        CenterStart,

        [EnumMember(Value = "center-end")]
        CenterEnd,

        [EnumMember(Value = "bottom")]
        Bottom,

        [EnumMember(Value = "bottom-start")]
        BottomStart,

        [EnumMember(Value = "bottom-end")]
        BottomEnd
    }

    /// <summary>
    /// Theme of the popup.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SwalTheme
    {
        [EnumMember(Value = "light")]
        Light,

        [EnumMember(Value = "dark")]
        Dark,

        [EnumMember(Value = "auto")]
        Auto,

        [EnumMember(Value = "borderless")]
        Borderless
    }
}
