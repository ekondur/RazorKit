using RazorKit.Datatable.Models;

namespace RazorKit.Datatable.Builders
{
    /// <summary>
    /// Command Group Configuration
    /// </summary>
    public class CommandGroupBuilder
    {
        private CommandGroup _commandGroup;

        internal CommandGroupBuilder(CommandGroup commandGroup)
        {
            _commandGroup = commandGroup;
        }

        /// <summary>
        /// Set command text.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public CommandGroupBuilder Text(string text)
        {
            _commandGroup.Text = text;
            return this;
        }

        /// <summary>
        /// Set icon css class.
        /// </summary>
        /// <param name="iconClass"></param>
        /// <returns></returns>
        public CommandGroupBuilder IconClass(string iconClass)
        {
            _commandGroup.IconClass = iconClass;
            return this;
        }

        /// <summary>
        /// Set button css class.
        /// </summary>
        /// <param name="btnClass"></param>
        /// <returns></returns>
        public CommandGroupBuilder BtnClass(string btnClass)
        {
            _commandGroup.BtnClass = btnClass;
            return this;
        }

        /// <summary>
        /// Set percentage of column where the command is.
        /// </summary>
        /// <param name="width"></param>
        /// <returns></returns>
        public CommandGroupBuilder Width(int width)
        {
            _commandGroup.Width = width;
            return this;
        }

        /// <summary>
        /// Add a Command Group item.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="onClick"></param>
        /// <returns></returns>
        public CommandGroupBuilder Item(string text, string onClick)
        {
            _commandGroup.Items.Add(new CommandGroupItem(text, onClick));
            return this;
        }
    }
}
