using RazorKit.Datatable.Models;

namespace RazorKit.Datatable.Builders
{
    /// <summary>
    /// KeyTable Configuration.
    /// </summary>
    public class KeyTableBuilder
    {
        private readonly KeyTable _keyTable;

        internal KeyTableBuilder(KeyTable keyTable)
        {
            _keyTable = keyTable;
        }

        /// <summary>
        /// Allow KeyTable's focus to be blurred (removed) from a table.
        /// </summary>
        /// <param name="blurable"></param>
        /// <returns></returns>
        public KeyTableBuilder Blurable(bool blurable)
        {
            _keyTable.Blurable = blurable;
            return this;
        }

        /// <summary>
        /// Set the class name used for the focused cell.
        /// </summary>
        /// <param name="className"></param>
        /// <returns></returns>
        public KeyTableBuilder ClassName(string className)
        {
            _keyTable.ClassName = className;
            return this;
        }

        /// <summary>
        /// Enable / disable clipboard interaction with KeyTable.
        /// </summary>
        /// <param name="clipboard"></param>
        /// <returns></returns>
        public KeyTableBuilder Clipboard(bool clipboard)
        {
            _keyTable.Clipboard = clipboard;
            return this;
        }

        /// <summary>
        /// Set the orthogonal data to copy to clipboard.
        /// </summary>
        /// <param name="clipboardOrthogonal"></param>
        /// <returns></returns>
        public KeyTableBuilder ClipboardOrthogonal(string clipboardOrthogonal)
        {
            _keyTable.ClipboardOrthogonal = clipboardOrthogonal;
            return this;
        }

        /// <summary>
        /// Select the columns that can gain focus.
        /// </summary>
        /// <param name="columns"></param>
        /// <returns></returns>
        public KeyTableBuilder Columns(string columns)
        {
            _keyTable.Columns = columns;
            return this;
        }

        /// <summary>
        /// Control if editing should be activated immediately upon focus.
        /// </summary>
        /// <param name="editOnFocus"></param>
        /// <returns></returns>
        public KeyTableBuilder EditOnFocus(bool editOnFocus)
        {
            _keyTable.EditOnFocus = editOnFocus;
            return this;
        }

        /// <summary>
        /// Attach an Editor instance for Excel like editing.
        /// </summary>
        /// <param name="editor"></param>
        /// <returns></returns>
        public KeyTableBuilder Editor(string editor)
        {
            _keyTable.Editor = editor;
            return this;
        }

        /// <summary>
        /// Cell to receive initial focus in the table.
        /// </summary>
        /// <param name="focus"></param>
        /// <returns></returns>
        public KeyTableBuilder Focus(string focus)
        {
            _keyTable.Focus = focus;
            return this;
        }

        /// <summary>
        /// Limit the keys that KeyTable will listen for and take action on.
        /// </summary>
        /// <param name="keys"></param>
        /// <returns></returns>
        public KeyTableBuilder Keys(params int[] keys)
        {
            _keyTable.Keys = keys;
            return this;
        }

        /// <summary>
        /// Set the table's tab index for when it will receive focus.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public KeyTableBuilder TabIndex(int index)
        {
            _keyTable.TabIndex = index;
            return this;
        }
    }
}
