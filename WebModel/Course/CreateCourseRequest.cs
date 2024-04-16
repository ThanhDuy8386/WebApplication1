using System.ComponentModel.DataAnnotations;

namespace WebApplication1.WebModel.Course
{
    public class CreateCourseRequest
    {
        [Required]
        public string Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string TeacherId { get; set; }
    }
}
