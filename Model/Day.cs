using System.ComponentModel;

namespace WebApplication1.Model
{
    public enum Day
    {
        Mon,
        Tue,
        Wed,
        Thus,
        Fri,
        Sat,
        Sun
    }

    public static class DayType
    {
        public static string ToFriendlyDay(this Day day)
        {
            return day switch
            {
                Day.Mon => "Monday",
                Day.Tue => "Tuesday",
                Day.Wed => "Wednesday",
                Day.Thus => "Thursday",
                Day.Fri => "Friday",
                Day.Sat => "Saturday",
                Day.Sun => "Sunday",
                _ => throw new InvalidEnumArgumentException(nameof(Day)),
            };
        }
    }
}
