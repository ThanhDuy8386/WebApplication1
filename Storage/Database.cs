using WebApplication1.Model;

namespace WebApplication1.Storage //id name dob add last
{
    public class Database
    {
        public static List<Student> Students = new List<Student>() {
            new Student("1", "duy", new DateTime(1997,01,01), "Binh Duong", "nguyen"),
            new Student("2", "phat", new DateTime(1995,01,01), "Tan Uyen", "la"),
            new Student("3", "tai", new DateTime(2000,01,01), "Phu Hoa", "le"),
            new Student("4", "phu", new DateTime(2010,01,01), "Tdm", "nguyen"),
        };
        public static List<Student> DeletedStudents = new List<Student>();
        public static List<Teacher> Teachers = new List<Teacher>() {
            new Teacher("1", "david", new DateTime(1980,01,01), "Binh Duong", "le"),
            new Teacher("2", "lundy", new DateTime(1950,01,01), "Tan Uyen", "pham"),
            new Teacher("3", "patrick", new DateTime(1920,01,01), "Phu Hoa", "dat"),
            new Teacher("4", "emma", new DateTime(1999,01,01), "Tdm", "stone"),
        };
        public static List<Teacher> DeletedTeachers = new List<Teacher>();
        public static List<Course> Courses = new List<Course>() {   //ssPrac, dayPrac, ssTheo, dayTheo
            new Course("1", "CSE101", "4"),
            new Course("2", "CSE102", "2"),
            new Course("3", "CSE103", "3"),
            new Course("4", "CSE104", "3"),
            new Course("5", "CSE105", "1"),
            new Course("6", "CSE106", "4"),
            new Course("7", "CSE107", "2"),
            new Course("8", "CSE108", "1"),
            new Course("9", "CSE109", "1"),
        };

        //stringid courseid day session classtype
        public static List<TimeTable> TimeTables = new List<TimeTable>() { 
            new TimeTable("1", "1", Day.Mon, Session.ss1, ClassType.Theory),
            new TimeTable("2", "1", Day.Mon, Session.ss2, ClassType.Theory),
            new TimeTable("3", "1", Day.Tue, Session.ss1, ClassType.Practice),
            new TimeTable("4", "1", Day.Tue, Session.ss2, ClassType.Practice),

            new TimeTable("5", "2", Day.Mon, Session.ss1, ClassType.Theory),
            new TimeTable("6", "2", Day.Thus, Session.ss2, ClassType.Theory),
            new TimeTable("7", "2", Day.Tue, Session.ss1, ClassType.Practice),
            new TimeTable("8", "2", Day.Thus, Session.ss2, ClassType.Practice),

            new TimeTable("9", "3", Day.Fri, Session.ss1, ClassType.Theory),
            new TimeTable("10", "3", Day.Fri, Session.ss2, ClassType.Theory),
            new TimeTable("11", "3", Day.Sat, Session.ss1, ClassType.Practice),
            new TimeTable("12", "3", Day.Sat, Session.ss2, ClassType.Practice),
        };
        public static List<StudentJoinCourse> StudentCourseTable = new List<StudentJoinCourse>()
        {
            new StudentJoinCourse("1","1","2"),
            new StudentJoinCourse("2","1","1"),
            new StudentJoinCourse("3","1","3"),
            new StudentJoinCourse("4","2","2"),
            new StudentJoinCourse("5","2","6"),
            new StudentJoinCourse("6","3","1"),
            new StudentJoinCourse("7","3","8"),
            new StudentJoinCourse("8","4","1"),
            new StudentJoinCourse("9","4","2"),
            new StudentJoinCourse("10","4","3"),
            new StudentJoinCourse("11","1", "100")
        };
    }
}
//id studentid courseid
//id name teacherId