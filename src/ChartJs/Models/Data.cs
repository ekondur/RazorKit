using System.Collections.Generic;

namespace RazorKit.ChartJs.Models
{
    class Data
    {
        public string[] Labels { get; set; }
        public IList<BaseDataset> Datasets { get; set; } = new List<BaseDataset>();
    }
}
