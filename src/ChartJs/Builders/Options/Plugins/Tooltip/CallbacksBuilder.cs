using RazorKit.ChartJs.Models;

namespace RazorKit.ChartJs.Builders
{
    /// <summary>
    /// Callbacks Builder
    /// </summary>
    public class CallbacksBuilder
    {
        private readonly Callbacks _callbacks;

        internal CallbacksBuilder(Callbacks callbacks)
        {
            _callbacks = callbacks;
        }

        /// <summary>
        /// Returns the text to render before the title.
        /// </summary>
        /// <param name="functionName"></param>
        /// <returns></returns>
        public CallbacksBuilder BeforeTitle(string functionName)
        {
            _callbacks.BeforeTitle = functionName;
            return this;
        }

        /// <summary>
        /// Returns text to render as the title of the tooltip.
        /// </summary>
        /// <param name="functionName"></param>
        /// <returns></returns>
        public CallbacksBuilder Title(string functionName)
        {
            _callbacks.Title = functionName;
            return this;
        }

        /// <summary>
        /// Returns text to render after the title.
        /// </summary>
        /// <param name="functionName"></param>
        /// <returns></returns>
        public CallbacksBuilder AfterTitle(string functionName)
        {
            _callbacks.AfterTitle = functionName;
            return this;
        }

        /// <summary>
        /// Returns text to render before the body section.
        /// </summary>
        /// <param name="functionName"></param>
        /// <returns></returns>
        public CallbacksBuilder BeforeBody(string functionName)
        {
            _callbacks.BeforeBody = functionName;
            return this;
        }

        /// <summary>
        /// Returns text to render before an individual label. This will be called for each item in the tooltip.
        /// </summary>
        /// <param name="functionName"></param>
        /// <returns></returns>
        public CallbacksBuilder BeforeLabel(string functionName)
        {
            _callbacks.BeforeLabel = functionName;
            return this;
        }

        /// <summary>
        /// Returns text to render for an individual item in the tooltip.
        /// </summary>
        /// <param name="functionName"></param>
        /// <returns></returns>
        public CallbacksBuilder Label(string functionName)
        {
            _callbacks.Label = functionName;
            return this;
        }

        /// <summary>
        /// Returns the colors to render for the tooltip item.
        /// </summary>
        /// <param name="functionName"></param>
        /// <returns></returns>
        public CallbacksBuilder LabelColor(string functionName)
        {
            _callbacks.LabelColor = functionName;
            return this;
        }

        /// <summary>
        /// Returns the colors for the text of the label for the tooltip item.
        /// </summary>
        /// <param name="functionName"></param>
        /// <returns></returns>
        public CallbacksBuilder LabelTextColor(string functionName)
        {
            _callbacks.LabelTextColor = functionName;
            return this;
        }

        /// <summary>
        /// Returns the point style to use instead of color boxes if usePointStyle is true (object with values pointStyle and rotation).
        /// Default implementation uses the point style from the dataset points.
        /// </summary>
        /// <param name="functionName"></param>
        /// <returns></returns>
        public CallbacksBuilder LabelPointStyle(string functionName)
        {
            _callbacks.LabelPointStyle = functionName;
            return this;
        }

        /// <summary>
        /// Returns text to render after an individual label.
        /// </summary>
        /// <param name="functionName"></param>
        /// <returns></returns>
        public CallbacksBuilder AfterLabel(string functionName)
        {
            _callbacks.AfterLabel = functionName;
            return this;
        }

        /// <summary>
        /// Returns text to render after the body section.
        /// </summary>
        /// <param name="functionName"></param>
        /// <returns></returns>
        public CallbacksBuilder AfterBody(string functionName)
        {
            _callbacks.AfterBody = functionName;
            return this;
        }

        /// <summary>
        /// Returns text to render before the footer section.
        /// </summary>
        /// <param name="functionName"></param>
        /// <returns></returns>
        public CallbacksBuilder BeforeFooter(string functionName)
        {
            _callbacks.BeforeFooter = functionName;
            return this;
        }

        /// <summary>
        /// Returns text to render as the footer of the tooltip.
        /// </summary>
        /// <param name="functionName"></param>
        /// <returns></returns>
        public CallbacksBuilder Footer(string functionName)
        {
            _callbacks.Footer = functionName;
            return this;
        }

        /// <summary>
        /// Text to render after the footer section.
        /// </summary>
        /// <param name="functionName"></param>
        /// <returns></returns>
        public CallbacksBuilder AfterFooter(string functionName)
        {
            _callbacks.AfterFooter = functionName;
            return this;
        }
    }
}
