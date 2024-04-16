namespace WebApplication1.Model
{
    public class StudentJoinCourse
    {
        public string Id { get; set; }
        public string StudentId { get; set; }
        public string CourseId { get; set; }
        public StudentJoinCourse(string Id, string StudentId, string CourseId) {
            this.Id = Id;
            this.StudentId = StudentId;
            this.CourseId = CourseId;
        }
    }   
}
