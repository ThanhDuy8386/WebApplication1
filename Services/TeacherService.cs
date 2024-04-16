using WebApplication1.Model;
using WebApplication1.WebModel.Student;
using WebApplication1.WebModel.Teacher;

namespace WebApplication1.Services
{
    public class TeacherService
    {
        public static CreateTeacherResponse CreateTeacher(CreateTeacherRequest request)
        {
            var teachers = Storage.Database.Teachers;
            var currentId = Guid.NewGuid().ToString();
            var newTeacher = new Teacher(currentId, request.Name, request.Dob, request.Address, request.LastName) { };
            teachers.Add(newTeacher);
            var newTeacherResponse = new CreateTeacherResponse()
            {
                Name = newTeacher.Name,
                Id = currentId,
            };
            return newTeacherResponse;
        }

        public static UpdateTeacherResponse? UpdateTeacher(string teacherId, UpdateTeacherRequest request)
        {
            var teachers = Storage.Database.Teachers;
            var targetTeacher = teachers.FirstOrDefault(x => x.Id == teacherId);
            if (targetTeacher == null)
            {
                return null;
            }
            Update(teachers, request, targetTeacher);
            return new UpdateTeacherResponse()
            {
                Id = teacherId,
            };
        }

        private static void Update(
            List<Teacher> teachers,
            UpdateTeacherRequest updateTeacher,
            Teacher teacher)
        {
            var newTeacher = new Teacher(
                teacher.Id,
                updateTeacher.Name,
                updateTeacher.Dob,
                updateTeacher.Address,
                updateTeacher.LastName);
            teachers.Remove(teacher);
            teachers.Add(newTeacher);
        }

        public static DeleteTeacherResponse? DeleteTeacher(DeleteTeacherRequest request)
        {
            var teachers = Storage.Database.Teachers;
            var deletedTeachers = Storage.Database.DeletedTeachers;
            var targetTeacher = teachers.FirstOrDefault(x => x.Id == request.Id);
            if (targetTeacher == null)
            {
                return null;
            }
            var deletedTeacher = new Teacher(targetTeacher.Id,
                targetTeacher.Name,
                targetTeacher.Dob,
                targetTeacher.Address,
                targetTeacher.LastName);
            deletedTeachers.Add(deletedTeacher);
            teachers.Remove(targetTeacher);
            return new DeleteTeacherResponse()
            {
                Id = targetTeacher.Id,
                Name = targetTeacher.Name,
            };
        }


        public static GetInfoResponseT? GetInfo(GetInfoRequestT request)
        {
            var teachers = Storage.Database.Teachers;
            var currentTeacher = teachers.FirstOrDefault(x => x.Id == request.Id);
            if (currentTeacher == null)
            {
                return null;
            }
            return new GetInfoResponseT()
            {
                Id = currentTeacher.Id,
                Name = currentTeacher.Name,
                Dob = currentTeacher.Dob,
                Address = currentTeacher.Address,
                LastName = currentTeacher.LastName
            };
        }

    }
}
