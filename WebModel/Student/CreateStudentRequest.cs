using System.ComponentModel.DataAnnotations;

namespace WebApplication1.WebModel.Student
{
    public class CreateStudentRequest
    {
        [Required]
        [MaxLength(5)]
        public string? Name { get; set; }
        public DateTime? Dob { get; set; }
        [Required]
        public string? Address { get; set; }
        public string? LastName { get; set; }
        [EmailAddress]
        public string Email { get; set; }
    }
}
