using System;

namespace HelperJS.Chart.Builders.Line
{
    public class LineBuilder : ChartBuilder
    {
        public LineBuilder Data(Action<LineDataBuilder> action)
        {
            var builder = new LineDataBuilder(Chart);
            action(builder);
            return this;
        }

        public LineBuilder Options(Action<OptionsBuilder> action)
        {
            var builder = new OptionsBuilder(Chart);
            action(builder);
            return this;
        }

        public LineBuilder Canvas(bool useCanvas)
        {
            UseCanvas = useCanvas;
            return this;
        }
    }
}
