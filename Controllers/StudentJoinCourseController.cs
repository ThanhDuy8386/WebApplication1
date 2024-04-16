using Microsoft.AspNetCore.Mvc;
using WebApplication1.Services;
using WebApplication1.WebModel.Student;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentJoinCourseController : Controller
    {
        private readonly ILogger<StudentJoinCourseController> _logger;

        public StudentJoinCourseController(ILogger<StudentJoinCourseController> logger)
        {
            _logger = logger;
        }

        [HttpPost("show-schedule")] //tao moi object
        public IActionResult ShowSchedule([FromQuery] string studentId)
        {
            var result = StudentJoinCourseService.Courses(studentId);
            return Ok(result);
        }

        [HttpPost("show-student-in-class")] //tao moi object
        public IActionResult ShowStudentInClass([FromQuery] string classId)
        {
            var result = StudentJoinCourseService.MemOfClass(classId);
            return Ok(result);
        }

        [HttpPost("course-schedule")]
        public IActionResult blablatest(string courseID) {
            var result = ScheduleService.CheckInfoCourse(courseID);
            return Ok(result);
        }


    }
}
