namespace RazorKit.Datatable.Models
{
    public class Command
    {
        internal string Text { get; private set; }
        internal string OnClick { get; private set; }

        internal Command(string text, string onClick)
        {
            Text = text;
            OnClick = onClick;
        }
    }
}
