namespace WebApplication1.Model
{
    public class TimeTable
    {
        public string Id { get; set; }
        public string CourseId { get; set; }
        public Day Day { get; set; }
        public Session Session { get; set; }
        public ClassType ClassType { get; set; }
        public TimeTable(string id, string courseId, Day day, Session session, ClassType classType)
        {
            this.Id = id;
            this.CourseId = courseId;
            this.Day = day;
            this.Session = session;
            this.ClassType = classType;
        }
    }
}
