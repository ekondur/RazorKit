using Newtonsoft.Json;

namespace RazorKit.DataTables.Models
{
    internal class Layout
    {
        public Layouts[] Top { get; set; }
        public Layouts[] Bottom { get; set; }

        [JsonConverter(typeof(NullableEnumConverter<Layouts>), Layouts.Null)]
        public Layouts? TopStart { get; set; }

        [JsonConverter(typeof(NullableEnumConverter<Layouts>), Layouts.Null)]
        public Layouts? TopEnd { get; set; }

        [JsonConverter(typeof(NullableEnumConverter<Layouts>), Layouts.Null)]
        public Layouts? BottomStart { get; set; }

        [JsonConverter(typeof(NullableEnumConverter<Layouts>), Layouts.Null)]
        public Layouts? BottomEnd { get; set; }
    }
}
