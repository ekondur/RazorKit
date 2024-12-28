using RazorKit.SweetAlert2.Models;

namespace RazorKit.SweetAlert2.Builders
{
    /// <summary>
    /// Show/Hide Class Configuration.
    /// </summary>
    public class SwalClassBuilder
    {
        private readonly SwalClass _swalClass;

        internal SwalClassBuilder(SwalClass swalClass)
        {
            _swalClass = swalClass;
        }

        /// <summary>
        /// Popup CSS
        /// </summary>
        /// <param name="popup"></param>
        /// <returns></returns>
        public SwalClassBuilder Popup(string popup)
        {
            _swalClass.Popup = popup;
            return this;
        }

        /// <summary>
        /// Backdrop CSS
        /// </summary>
        /// <param name="backdrop"></param>
        /// <returns></returns>
        public SwalClassBuilder Backdrop(string backdrop)
        {
            _swalClass.Backdrop = backdrop;
            return this;
        }

        /// <summary>
        /// Icon CSS
        /// </summary>
        /// <param name="icon"></param>
        /// <returns></returns>
        public SwalClassBuilder Icon(string icon)
        {
            _swalClass.Icon = icon;
            return this;
        }
    }
}
