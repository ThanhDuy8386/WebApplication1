using WebApplication1.Model;
using WebApplication1.WebModel.StudentJoinCourse;

namespace WebApplication1.Services
{
    public class StudentJoinCourseService
    {
        //nhap vao studentid xuat ra list mon hoc
        public static CoursesResponse Courses(string studentId)
        {
            var students = Storage.Database.Students;
            var courses = Storage.Database.Courses;
            var courseMapping = courses.ToDictionary(x => x.Id, x => x.Name);
            var studentCourseTables = Storage.Database.StudentCourseTable;
            var coursetables = new List<string>();
            var currentStudent = students.FirstOrDefault(x => x.Id == studentId);
            if (currentStudent == null)
            {
                return null;
            }
            var targetStudent = studentCourseTables
                .Where(x => x.StudentId == studentId)
                .Select(x => x)
                .ToList();
            var result = new CoursesResponse() { };
            foreach (var student in targetStudent)
            {
                //foreach (var course in courses) {
                //    if (student.CourseId == course.Id) {
                //        result.Add(course.Name);
                //    }
                //}
                if (courseMapping.ContainsKey(student.CourseId))
                {
                    result.Courses.Add(courseMapping[student.CourseId]);
                }
                //try
                //{
                //    result.Add(courseMapping[student.CourseId]);
                //}
                //catch (Exception ex)
                //{
                //    result.Add(ex.Message);
                //}
            }
            return result;
        }

        public static StudentsResponse MemOfClass(string classId)
        {
            var students = Storage.Database.Students;
            var courses = Storage.Database.Courses;
            var studentCourseTables = Storage.Database.StudentCourseTable;
            var Mapping = students.ToDictionary(x => x.Id, x => x.Name);
            var targetClass = studentCourseTables
                .Where(x => x.CourseId == classId)
                .Select(x => x)
                .ToList();
            var currentClass = courses.FirstOrDefault(x => x.Id == classId);
            if (currentClass == null) {
                return null;
            }
            var result = new StudentsResponse() { };
            foreach (var thing in targetClass)
            {
                //foreach (var student in students)
                //{
                //    if (thing.StudentId == student.Id)
                //    {
                //        result.Add(student.Name);
                //    }
                //}

                result.Students.Add(Mapping[thing.StudentId]);
            }
            return result;
        }
    }
}
