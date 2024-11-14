using RazorKit.Datatable.Models;
using System.Collections.Generic;

namespace RazorKit.Datatable.Builders
{
    /// <summary>
    /// Buttons Configuration.
    /// </summary>
    public class ButtonBuilder
    {
        private readonly Button _button;
        private readonly DatatableJs _datatableJs;

        internal ButtonBuilder(DatatableJs datatable)
        {
            _button = new Button();
            if (datatable.Buttons == null)
            {
                datatable.Buttons = new List<object>();
            }
            datatable.Buttons.Add(_button);
        }

        /// <summary>
        /// Action to take when the button is activated.
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        public ButtonBuilder Action(string action)
        {
            _button.Action = action;
            return this;
        }

        /// <summary>
        /// Indicate that a button's action processing should be performed asynchronously.
        /// </summary>
        /// <param name="async"></param>
        /// <returns></returns>
        public ButtonBuilder Async(int async)
        {
            _button.Async = async;
            return this;
        }

        /// <summary>
        /// Collection of attribute key / values to set for a button
        /// </summary>
        /// <param name="title"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public ButtonBuilder Attr(string title, string id)
        {
            _button.Attr = new ButtonAttr { Title = title, Id = id };
            return this;
        }

        /// <summary>
        /// Ensure that any requirements have been satisfied before initialising a button.
        /// </summary>
        /// <param name="available"></param>
        /// <returns></returns>
        public ButtonBuilder Available(string available)
        {
            _button.Available = available;
            return this;
        }

        /// <summary>
        /// Set the class name for the button.
        /// </summary>
        /// <param name="className"></param>
        /// <returns></returns>
        public ButtonBuilder ClassName(string className)
        {
            _button.ClassName = className;
            return this;
        }

        /// <summary>
        /// Function that is called when the button is destroyed.
        /// </summary>
        /// <param name="destroy"></param>
        /// <returns></returns>
        public ButtonBuilder Destroy(string destroy)
        {
            _button.Destroy = destroy;
            return this;
        }

        /// <summary>
        /// Show a dropdown (further action) icon.
        /// </summary>
        /// <param name="dropIcon"></param>
        /// <returns></returns>
        public ButtonBuilder DropIcon(bool dropIcon)
        {
            _button.DropIcon = dropIcon;
            return this;
        }

        /// <summary>
        /// Set a button's initial enabled state.
        /// </summary>
        /// <param name="enabled"></param>
        /// <returns></returns>
        public ButtonBuilder Enabled(bool enabled)
        {
            _button.Enabled = enabled;
            return this;
        }

        /// <summary>
        /// Define which button type the button should be based on.
        /// </summary>
        /// <param name="ext"></param>
        /// <returns></returns>
        public ButtonBuilder Extend(string ext)
        {
            _button.Extend = ext;
            return this;
        }

        /// <summary>
        /// Initialisation function that can be used to add events specific to this button.
        /// </summary>
        /// <param name="init"></param>
        /// <returns></returns>
        public ButtonBuilder Init(string init)
        {
            _button.Init = init;
            return this;
        }

        /// <summary>
        /// Define an activation key for a button.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public ButtonBuilder Key(string key)
        {
            _button.Key = key;
            return this;
        }

        /// <summary>
        /// Define an activation key for a button.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="altKey"></param>
        /// <returns></returns>
        public ButtonBuilder Key(string key, bool altKey)
        {
            _button.Key = new ButtonKey { Key = key, AltKey = altKey };
            return this;
        }

        /// <summary>
        /// Set a name for each selection.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public ButtonBuilder Name(string name)
        {
            _button.Name = name;
            return this;
        }

        /// <summary>
        /// Unique namespace for every button.
        /// </summary>
        /// <param name="nspace"></param>
        /// <returns></returns>
        public ButtonBuilder Namespace(string nspace)
        {
            _button.Namespace = nspace;
            return this;
        }

        /// <summary>
        /// Split dropdown buttons.
        /// </summary>
        /// <param name="buttons"></param>
        /// <returns></returns>
        public ButtonBuilder Split(params string[] buttons)
        {
            _button.Split = buttons;
            return this;
        }

        /// <summary>
        /// Split dropdown buttons.
        /// </summary>
        /// <param name="buttons"></param>
        /// <returns></returns>
        public ButtonBuilder Buttons(params string[] buttons)
        {
            _button.Buttons = buttons;
            return this;
        }

        /// <summary>
        /// Set the tag for the button.
        /// </summary>
        /// <param name="tag"></param>
        /// <returns></returns>
        public ButtonBuilder Tag(string tag)
        {
            _button.Tag = tag;
            return this;
        }

        /// <summary>
        /// The text to show in the button.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public ButtonBuilder Text(string text)
        {
            _button.Text = text;
            return this;
        }

        /// <summary>
        /// Button title attribute text.
        /// </summary>
        /// <param name="attr"></param>
        /// <returns></returns>
        public ButtonBuilder TitleAttr(string attr)
        {
            _button.TitleAttr = attr;
            return this;
        }
    }
}
