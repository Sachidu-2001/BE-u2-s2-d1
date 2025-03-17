using System.ComponentModel.DataAnnotations;

namespace WebApp1.Models
{
    public class Student
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Cognome { get; set; }
        [Required]
        public DateOnly DataDiNascita { get; set; } 
        [Required]
        [EmailAddress]
        public string   Email { get; set; }
    }


}
