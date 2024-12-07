using System.ComponentModel.DataAnnotations;

namespace RazorKit.DataTables.Test
{
    internal class Person
    {
        public int Id { get; set; }

        [Display(Name = "First Name")]
        public string Name { get; set; }
        public int Age { get; set; }
        public string Title { get; set; }

        [DisplayFormat(DataFormatString = "dddd")]
        public DateOnly BirthDate { get; set; }
    }
}
