using System.Collections.Generic;

namespace HelperJS.Chart.Models
{
    class Data
    {
        public IList<string> Labels { get; set; } = new List<string>();
        public IList<BaseDataset> Datasets { get; set; } = new List<BaseDataset>();
    }
}
