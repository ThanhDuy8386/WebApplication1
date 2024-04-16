using WebApplication1.Model;
using WebApplication1.WebModel.Course;

namespace WebApplication1.Services
{
    public class CourseService
    {
        private string id;
        private string name;
        private string teacherId;

        public CourseService(string id, string name, string teacherId)
        {
            this.id = id;
            this.name = name;
            this.teacherId = teacherId;
        }

        public static CreateCourseResponse CreateCourse(CreateCourseRequest request) {
            var courses = Storage.Database.Courses;
            var currentId = Guid.NewGuid().ToString();
            var newCourse = new Course(request.Id, request.Name, request.TeacherId) { };
            courses.Add(newCourse);
            return new CreateCourseResponse()
            {
                Id = currentId,
                Name = request.Name,
            };
            
        }
    }
}
