using RazorKit.Datatable.Models;

namespace RazorKit.Datatable.Builders
{
    /// <summary>
    /// Command Configuration.
    /// </summary>
    public class CommandBuilder
    {
        private readonly DatatableJs _datatable;
        private Command _command;

        internal CommandBuilder(DatatableJs datatable)
        {
            _datatable = datatable;
            _command = new Command();
            _datatable.Commands.Add(_command);
        }

        /// <summary>
        /// Set command text.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public CommandBuilder Text(string text)
        {
            _command.Text = text;
            return this;
        }

        /// <summary>
        /// Set onClick function name.
        /// </summary>
        /// <param name="onClick"></param>
        /// <returns></returns>
        public CommandBuilder OnClick(string onClick)
        {
            _command.OnClick = onClick;
            return this;
        }

        /// <summary>
        /// Set icon css class.
        /// </summary>
        /// <param name="iconClass"></param>
        /// <returns></returns>
        public CommandBuilder IconClass(string iconClass)
        {
            _command.IconClass = iconClass;
            return this;
        }

        /// <summary>
        /// Set button css class.
        /// </summary>
        /// <param name="btnClass"></param>
        /// <returns></returns>
        public CommandBuilder BtnClass(string btnClass)
        {
            _command.BtnClass = btnClass;
            return this;
        }

        /// <summary>
        /// Set percentage of column where the command is.
        /// </summary>
        /// <param name="width"></param>
        /// <returns></returns>
        public CommandBuilder Width(string width)
        {
            _command.Width = width;
            return this;
        }
    }
}
