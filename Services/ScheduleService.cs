using WebApplication1.Model;
using WebApplication1.WebModel.Schedule;

namespace WebApplication1.Services
{
    public class ScheduleService
    {
        public static List<ScheduleResponse> CheckInfoCourse(string courseId) {
            var timeTables = Storage.Database.TimeTables;
            var courses = Storage.Database.Courses;
            var courseMapping = courses.FirstOrDefault(x => x.Id == courseId);          
            var targetCourse = timeTables
                .Where(x => x.CourseId == courseId)
                .Select(x => new ScheduleResponse() {
                    CourseId = courseMapping.Name,
                    Session = x.Session.ToFriendlySession(),
                    Day = x.Day.ToFriendlyDay(),
                    ClassType = x.ClassType.ToFriendlyClassType(),
                })
                .ToList();
            return targetCourse;
        }


    }
}
