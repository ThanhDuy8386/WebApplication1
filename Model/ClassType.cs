using System.ComponentModel;

namespace WebApplication1.Model
{
    public enum ClassType
    {
        Practice,
        Theory
    }

    public static class ClassClassify
    {
        public static string ToFriendlyClassType(this ClassType classtype)
        {
            return classtype switch
            {
                ClassType.Practice => "Practice class",
                ClassType.Theory => "Theory class",
                _ => throw new InvalidEnumArgumentException(nameof(ClassType)),
            };
        }
    }
}
