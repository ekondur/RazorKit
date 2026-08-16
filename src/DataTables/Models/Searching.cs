using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorKit.DataTables.Models
{
    /// <summary>
    /// Represents the DataTables Search option
    /// </summary>
    internal class Searching
    {
        public bool Return { get; set; }
        public string Placeholder { get; set; } = default;
        public bool Boundary { get; set; } = false;
        public bool Smart { get; set; } = false;
        public bool CaseInsensitive { get; set; } = false;
        public string Regex { get; set; } = default;
        public string Search { get; set; } = default;
    }
}
