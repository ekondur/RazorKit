using Newtonsoft.Json.Linq;
using RazorKit.Datatable.Models;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Emit;

namespace RazorKit.Datatable.Builders
{
    /// <summary>
    /// LengthMenu Configuration.
    /// </summary>
    public class LengthMenuBuilder
    {
        private readonly DatatableJs _datatable;

        internal LengthMenuBuilder(DatatableJs datatable)
        {
            _datatable = datatable;
        }

        /// <summary>
        /// Set menu options.
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public LengthMenuBuilder Items(params int[] items)
        {
            _datatable.LengthMenu = new List<IList<object>>();
            _datatable.LengthMenu.Add(items.Cast<object>().ToList());
            _datatable.LengthMenu.Add(items.Cast<object>().ToList());
            
            return this;
        }

        /// <summary>
        /// Show all records option.
        /// </summary>
        /// <returns></returns>
        public LengthMenuBuilder ShowAll()
        {
            if (_datatable.LengthMenu != null)
            {
                _datatable.LengthMenu[0].Add(-1);
                _datatable.LengthMenu[1].Add("All");
            }
            return this;
        }

        /// <summary>
        /// Show all records option with custom name.
        /// </summary>
        /// <param name="optionText"></param>
        /// <returns></returns>
        public LengthMenuBuilder ShowAll(string optionText)
        {
            if (_datatable.LengthMenu != null)
            {
                _datatable.LengthMenu[0].Add(-1);
                _datatable.LengthMenu[1].Add(optionText);
            }
            return this;
        }
    }
}
