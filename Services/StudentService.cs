using System.Net;
using WebApplication1.Model;
using WebApplication1.WebModel.Student;

namespace WebApplication1.Services
{
    public class StudentService
    {
        public static CreateStudentResponse CreateStudent(CreateStudentRequest request)
        {
            var students = Storage.Database.Students;
            var currentId = Guid.NewGuid().ToString();
            var newStudent = new Student(currentId, request.Name, request.Dob, request.Address, request.LastName) { };
            students.Add(newStudent);
            var newStudentResponse = new CreateStudentResponse()
            {
                Name = newStudent.Name,
                Id = currentId,
            };
            return newStudentResponse;
        }

        public static UpdateStudentResponse? UpdateStudent(string studentId, UpdateStudentRequest request)
        {
            var students = Storage.Database.Students;
            var targetStudent = students.FirstOrDefault(x => x.Id == studentId);
            if (targetStudent == null)
            {
                return null;
            }
            Update(students, request, targetStudent);
            return new UpdateStudentResponse()
            {
                Id = studentId,
            };
        }

        public static UpdateStudentResponse? UpdateStudent2(string studentId, UpdateStudentRequest2 request)
        {
            var students = Storage.Database.Students;
            var targetStudent = students.FirstOrDefault(x => x.Id == studentId);
            if (targetStudent == null)
            {
                return null;
            }
            Update2(students, request, targetStudent);
            return new UpdateStudentResponse()
            {
                Id = studentId,
            };
        }

        private static void Update(
            List<Student> students,
            UpdateStudentRequest updateStudent,
            Student student)
        {
            var newStudent = new Student(
                student.Id,
                updateStudent.Name,
                updateStudent.Dob,
                updateStudent.Address,
                updateStudent.LastName);
            students.Remove(student);
            students.Add(newStudent);
        }

        private static void Update2(
            List<Student> students,
            UpdateStudentRequest2 updateStudent,
            Student student)
        {
            var updatedValues = updateStudent.keyValuePairs;
            var idealDictionary = new Dictionary<string, string>();
            foreach ( var keyValue in updatedValues )
            {
                idealDictionary[keyValue.Key.ToLower()] = keyValue.Value;
            }
            if (idealDictionary.ContainsKey("name")) {
                student.Name = idealDictionary["name"];
            }
            if (idealDictionary.ContainsKey("address"))
            {
                student.Address = idealDictionary["address"];
            }
            if (idealDictionary.ContainsKey("lastname"))
            {
                student.LastName = idealDictionary["lastname"];
            }
        }

        public static DeleteStudentResponse? DeleteStudent(DeleteStudentRequest request) {
            var students = Storage.Database.Students;
            var deletedStudents = Storage.Database.DeletedStudents;
            var targetStudent = students.FirstOrDefault(x => x.Id == request.Id);
            if (targetStudent == null) {
                return null;
            }
            var deletedStudent = new Student(targetStudent.Id, 
                targetStudent.Name, 
                targetStudent.Dob, 
                targetStudent.Address, 
                targetStudent.LastName);
            deletedStudents.Add(deletedStudent);
            students.Remove(targetStudent);
            return new DeleteStudentResponse() {
                Id = targetStudent.Id,
                Name = targetStudent.Name,
            };
        }

        public static GetInfoResponseS? GetInfo(GetInfoRequestS request) {
            var students = Storage.Database.Students;
            var currentStudent = students.FirstOrDefault(x => x.Id == request.Id);
            if (currentStudent == null) {
                return null;
            }
            return new GetInfoResponseS()
            {
                Id = currentStudent.Id,
                Name = currentStudent.Name,
                Dob = currentStudent.Dob,
                Address = currentStudent.Address,
                LastName = currentStudent.LastName
            };
        }

        

    }
}
