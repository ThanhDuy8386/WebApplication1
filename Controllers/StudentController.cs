using Microsoft.AspNetCore.Mvc;
using WebApplication1.Services;
using WebApplication1.WebModel.Student;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : Controller
    {
        private readonly ILogger<StudentController> _logger;

        public StudentController(ILogger<StudentController> logger)
        {
            _logger = logger;
        }
        [HttpGet("show-all")]
        public IActionResult Show()
        {
            var students = Storage.Database.Students;
            return Ok(students);
        }

        [HttpGet("show-all-deleted")]
        public IActionResult ShowDeleted()
        {
            var deletedStudents = Storage.Database.DeletedStudents;
            return Ok(deletedStudents);
        }

        [HttpPost("create-student")] //tao moi object
        public IActionResult CreateStudent([FromQuery] CreateStudentRequest request)
        {
            var result = StudentService.CreateStudent(request);
            return Ok(result);
        }

        [HttpPut("update-student")] // cap nhat thong tin, update. co the dung patch
        public IActionResult UpdateStudent(string idStudent, UpdateStudentRequest request) {
            var result = StudentService.UpdateStudent(idStudent, request);
            return Ok(result);
        }

        [HttpPut("update-student2")] // cap nhat thong tin, update. co the dung patch
        public IActionResult UpdateStudent2(string idStudent, UpdateStudentRequest2 request)
        {
            var result = StudentService.UpdateStudent2(idStudent, request);
            return Ok(result);
        }

        [HttpDelete("delete-student")] // xoa thong tin
        public IActionResult DeleteStudent(DeleteStudentRequest request) {
            var result = StudentService.DeleteStudent(request);
            return Ok(result);
        }

        [HttpGet("info-student")] //lay thong tin
        public IActionResult InfoStudent(GetInfoRequestS request) {
            var result = StudentService.GetInfo(request);
            return Ok(result);
        }

        
    }
}
