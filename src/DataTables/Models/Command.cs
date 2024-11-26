using System.Collections.Generic;

namespace RazorKit.DataTables.Models
{
    internal class Command
    {
        public string Text { get; set; }
        public string OnClick { get; set; }
        public string IconClass { get; set; }
        public string BtnClass { get; set; }
        public string Width { get; set; }
    }

    internal class CommandGroup
    {
        public string Text { get; set; }
        public string IconClass { get; set; }
        public string BtnClass { get; set; }
        public string Width { get; set; }
        public IList<CommandGroupItem> Items { get; set; } = new List<CommandGroupItem>();
    }

    internal class CommandGroupItem
    {
        public CommandGroupItem(string text, string onClick)
        {
            Text = text;
            OnClick = onClick;
        }

        internal string Text { get; private set; }
        internal string OnClick { get; private set; }
    }
}
