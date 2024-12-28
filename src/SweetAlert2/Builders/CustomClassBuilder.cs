using RazorKit.SweetAlert2.Models;

namespace RazorKit.SweetAlert2.Builders
{
    /// <summary>
    /// CustomClass configuration.
    /// </summary>
    public class CustomClassBuilder
    {
        private readonly CustomClass _customClass;

        internal CustomClassBuilder(CustomClass customClass)
        {
            _customClass = customClass;
        }

        public CustomClassBuilder Container(string container)
        {
            _customClass.Container = container;
            return this;
        }

        public CustomClassBuilder Popup(string popup)
        {
            _customClass.Popup = popup;
            return this;
        }

        public CustomClassBuilder Header(string header)
        {
            _customClass.Header = header;
            return this;
        }

        public CustomClassBuilder Title(string title)
        {
            _customClass.Title = title;
            return this;
        }

        public CustomClassBuilder CloseButton(string closeButton)
        {
            _customClass.CloseButton = closeButton;
            return this;
        }

        public CustomClassBuilder Icon(string icon)
        {
            _customClass.Icon = icon;
            return this;
        }

        public CustomClassBuilder Image(string image)
        {
            _customClass.Image = image;
            return this;
        }

        public CustomClassBuilder HtmlContainer(string htmlContainer)
        {
            _customClass.HtmlContainer = htmlContainer;
            return this;
        }

        public CustomClassBuilder Input(string input)
        {
            _customClass.Input = input;
            return this;
        }

        public CustomClassBuilder InputLabel(string inputLabel)
        {
            _customClass.InputLabel = inputLabel;
            return this;
        }

        public CustomClassBuilder ValidationMessage(string validationMessage)
        {
            _customClass.ValidationMessage = validationMessage;
            return this;
        }

        public CustomClassBuilder Actions(string actions)
        {
            _customClass.Actions = actions;
            return this;
        }

        public CustomClassBuilder ConfirmButton(string confirmButton)
        {
            _customClass.ConfirmButton = confirmButton;
            return this;
        }

        public CustomClassBuilder DenyButton(string denyButton)
        {
            _customClass.DenyButton = denyButton;
            return this;
        }

        public CustomClassBuilder CancelButton(string cancelButton)
        {
            _customClass.CancelButton = cancelButton;
            return this;
        }

        public CustomClassBuilder Loader(string loader)
        {
            _customClass.Loader = loader;
            return this;
        }

        public CustomClassBuilder Footer(string footer)
        {
            _customClass.Footer = footer;
            return this;
        }

        public CustomClassBuilder TimerProgressBar(string timerProgressBar)
        {
            _customClass.TimerProgressBar = timerProgressBar;
            return this;
        }
    }
}
