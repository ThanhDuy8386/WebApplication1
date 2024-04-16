using Microsoft.AspNetCore.Mvc;
using WebApplication1.Services;
using WebApplication1.WebModel.Student;
using WebApplication1.WebModel.Teacher;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TeacherController : Controller
    {
        private readonly ILogger<TeacherController> _logger;

        public TeacherController(ILogger<TeacherController> logger)
        {
            _logger = logger;
        }

        [HttpGet("show-all")]
        public IActionResult Show()
        {
            var teachers = Storage.Database.Teachers;
            return Ok(teachers);
        }

        [HttpGet("show-all-deleted")]
        public IActionResult ShowDeleted()
        {
            var deletedTeachers = Storage.Database.DeletedTeachers;
            return Ok(deletedTeachers);
        }

        [HttpPost("create-teacher")]
        public IActionResult CreateTeacher(CreateTeacherRequest request)
        {
            var result = TeacherService.CreateTeacher(request);
            return Ok(result);
        }

        [HttpPost("update-teacher")]
        public IActionResult UpdateTeacher(string idTeacher, UpdateTeacherRequest request)
        {
            var result = TeacherService.UpdateTeacher(idTeacher, request);
            return Ok(result);
        }

        [HttpPost("delete-teacher")]
        public IActionResult DeleteTeacher(DeleteTeacherRequest request)
        {
            var result = TeacherService.DeleteTeacher(request);
            return Ok(result);
        }

        [HttpPost("info-teacher")]
        public IActionResult InfoTeacher(GetInfoRequestT request)
        {
            var result = TeacherService.GetInfo(request);
            return Ok(result);
        }
    }
}
