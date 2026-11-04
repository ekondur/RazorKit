namespace RazorKit.TomSelect.Builders
{
    /// <summary>Configures Tom Select lifecycle callbacks.</summary>
    public sealed class CallbacksBuilder : SettingsBuilder<CallbacksBuilder>
    {
        /// <summary>Sets the trusted onInitialize function or function reference.</summary>
        public CallbacksBuilder OnInitialize(string expression) => SetJavaScript("onInitialize", expression);
        /// <summary>Sets the trusted onFocus function or function reference.</summary>
        public CallbacksBuilder OnFocus(string expression) => SetJavaScript("onFocus", expression);
        /// <summary>Sets the trusted onBlur function or function reference.</summary>
        public CallbacksBuilder OnBlur(string expression) => SetJavaScript("onBlur", expression);
        /// <summary>Sets the trusted onChange function or function reference.</summary>
        public CallbacksBuilder OnChange(string expression) => SetJavaScript("onChange", expression);
        /// <summary>Sets the trusted onItemAdd function or function reference.</summary>
        public CallbacksBuilder OnItemAdd(string expression) => SetJavaScript("onItemAdd", expression);
        /// <summary>Sets the trusted onItemRemove function or function reference.</summary>
        public CallbacksBuilder OnItemRemove(string expression) => SetJavaScript("onItemRemove", expression);
        /// <summary>Sets the trusted onItemSelect function or function reference.</summary>
        public CallbacksBuilder OnItemSelect(string expression) => SetJavaScript("onItemSelect", expression);
        /// <summary>Sets the trusted onClear function or function reference.</summary>
        public CallbacksBuilder OnClear(string expression) => SetJavaScript("onClear", expression);
        /// <summary>Sets the trusted onDelete function or function reference.</summary>
        public CallbacksBuilder OnDelete(string expression) => SetJavaScript("onDelete", expression);
        /// <summary>Sets the trusted onOptionAdd function or function reference.</summary>
        public CallbacksBuilder OnOptionAdd(string expression) => SetJavaScript("onOptionAdd", expression);
        /// <summary>Sets the trusted onOptionRemove function or function reference.</summary>
        public CallbacksBuilder OnOptionRemove(string expression) => SetJavaScript("onOptionRemove", expression);
        /// <summary>Sets the trusted onOptionClear function or function reference.</summary>
        public CallbacksBuilder OnOptionClear(string expression) => SetJavaScript("onOptionClear", expression);
        /// <summary>Sets the trusted onOptionGroupAdd function or function reference.</summary>
        public CallbacksBuilder OnOptionGroupAdd(string expression) => SetJavaScript("onOptionGroupAdd", expression);
        /// <summary>Sets the trusted onOptionGroupRemove function or function reference.</summary>
        public CallbacksBuilder OnOptionGroupRemove(string expression) => SetJavaScript("onOptionGroupRemove", expression);
        /// <summary>Sets the trusted onOptionGroupClear function or function reference.</summary>
        public CallbacksBuilder OnOptionGroupClear(string expression) => SetJavaScript("onOptionGroupClear", expression);
        /// <summary>Sets the trusted onDropdownOpen function or function reference.</summary>
        public CallbacksBuilder OnDropdownOpen(string expression) => SetJavaScript("onDropdownOpen", expression);
        /// <summary>Sets the trusted onDropdownClose function or function reference.</summary>
        public CallbacksBuilder OnDropdownClose(string expression) => SetJavaScript("onDropdownClose", expression);
        /// <summary>Sets the trusted onType function or function reference.</summary>
        public CallbacksBuilder OnType(string expression) => SetJavaScript("onType", expression);
        /// <summary>Sets the trusted onLoad function or function reference.</summary>
        public CallbacksBuilder OnLoad(string expression) => SetJavaScript("onLoad", expression);
        /// <summary>Sets the trusted onDestroy function or function reference.</summary>
        public CallbacksBuilder OnDestroy(string expression) => SetJavaScript("onDestroy", expression);
    }
}
