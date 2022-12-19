using System.ComponentModel.DataAnnotations;

namespace CrudOperations_Razor.Models
{
    public class StudentRegistration
    {
        [Key]
        public int Stuid { get; set; }

        public string Stuname { get; set; }

        public string Email { get; set; }

        public int Salary { get; set; }
    }
}
