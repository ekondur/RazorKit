using HelperJS.Chart.Models;

namespace HelperJS.Chart.Builders
{
    public class TitleBuilder
    {
        private readonly ChartJs _chart;
        private readonly Title _title;

        public TitleBuilder(ChartJs chart, bool isSubtitle)
        {
            _chart = chart;

            if (isSubtitle)
            {
                _chart.Options.Plugins.Subtitle = _title = new Title();
            }
            else
            {
                _chart.Options.Plugins.Title = _title = new Title();
            }
        }

        public TitleBuilder Align(string align)
        {
            _title.Align = align;
            return this;
        }

        public TitleBuilder Color(string color)
        {
            _title.Color = color;
            return this;
        }

        public TitleBuilder Display(bool display)
        {
            _title.Display = display;
            return this;
        }

        public TitleBuilder FullSize(bool fullSize)
        {
            _title.FullSize = fullSize;
            return this;
        }

        public TitleBuilder Position(string position)
        {
            _title.Position = position;
            return this;
        }

        public TitleBuilder Font(string font)
        {
            _title.Font = font;
            return this;
        }

        public TitleBuilder Padding(int padding)
        {
            _title.Padding = padding;
            return this;
        }

        public TitleBuilder Text(params string[] text)
        {
            _title.Text = text;
            return this;
        }
    }
}
