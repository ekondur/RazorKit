namespace RazorKit.TomSelect.Builders
{
    /// <summary>Configures Tom Select render templates.</summary>
    public sealed class TemplatesBuilder : SettingsBuilder<TemplatesBuilder>
    {
        /// <summary>Sets the trusted option function or function reference.</summary>
        public TemplatesBuilder Option(string expression) => SetJavaScript("option", expression);
        /// <summary>Sets the trusted item function or function reference.</summary>
        public TemplatesBuilder Item(string expression) => SetJavaScript("item", expression);
        /// <summary>Sets the trusted option_create function or function reference.</summary>
        public TemplatesBuilder OptionCreate(string expression) => SetJavaScript("option_create", expression);
        /// <summary>Sets the trusted optgroup_header function or function reference.</summary>
        public TemplatesBuilder OptgroupHeader(string expression) => SetJavaScript("optgroup_header", expression);
        /// <summary>Sets the trusted optgroup function or function reference.</summary>
        public TemplatesBuilder Optgroup(string expression) => SetJavaScript("optgroup", expression);
        /// <summary>Sets the trusted no_results function or function reference.</summary>
        public TemplatesBuilder NoResults(string expression) => SetJavaScript("no_results", expression);
        /// <summary>Sets the trusted not_loading function or function reference.</summary>
        public TemplatesBuilder NotLoading(string expression) => SetJavaScript("not_loading", expression);
        /// <summary>Sets the trusted loading function or function reference.</summary>
        public TemplatesBuilder Loading(string expression) => SetJavaScript("loading", expression);
        /// <summary>Sets the trusted dropdown function or function reference.</summary>
        public TemplatesBuilder Dropdown(string expression) => SetJavaScript("dropdown", expression);
        /// <summary>Sets the trusted loading_more function or function reference.</summary>
        public TemplatesBuilder LoadingMore(string expression) => SetJavaScript("loading_more", expression);
        /// <summary>Sets the trusted no_more_results function or function reference.</summary>
        public TemplatesBuilder NoMoreResults(string expression) => SetJavaScript("no_more_results", expression);
    }
}
