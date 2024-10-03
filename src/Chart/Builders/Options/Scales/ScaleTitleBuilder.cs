using HelperJS.Chart.Models;

namespace HelperJS.Chart.Builders
{
    /// <summary>
    /// ScaleTitle Builder
    /// </summary>
    public class ScaleTitleBuilder
    {
        private readonly Scale _scale;
        private readonly ScaleTitle _scaleTitle;

        internal ScaleTitleBuilder(Scale scale)
        {
            _scale = scale;
            _scale.Title = _scaleTitle = new ScaleTitle();
        }
    }
}
