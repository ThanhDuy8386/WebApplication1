using System.ComponentModel.DataAnnotations;

namespace WebApplication1.WebModel.Student
{
    public class UpdateStudentRequest
    {
        [Required]
        public string? Name { get; set; }
        public DateTime? Dob { get; set; }
        public string? Address { get; set; }
        public string? LastName { get; set; }
    }

    public class UpdateStudentRequest2 { 
        public Dictionary<string, string> keyValuePairs { get; set; }

    }
}
