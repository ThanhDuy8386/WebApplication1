using System.ComponentModel.DataAnnotations;

namespace WebApplication1.WebModel.Teacher
{
    public class UpdateTeacherRequest
    {
        [Required]
        public string? Name { get; set; }
        public DateTime? Dob { get; set; }
        public string? Address { get; set; }
        public string? LastName { get; set; }
    }
}
