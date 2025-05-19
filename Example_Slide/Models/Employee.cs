using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Example_Slide.Models
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        public string? PersonId { get; set; }       
        public string? FullName { get; set; }
        public string? Address { get; set; }
    }
}
