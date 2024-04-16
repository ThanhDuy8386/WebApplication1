using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WebApplication1.Model
{
    public enum Session
    {
        ss1,
        ss2,
        ss3,
        ss4
    }

    public static class SessionType {
        public static string ToFriendlySession(this Session session) {
            return session switch {
                Session.ss1 => "7h30 - 9h30",
                Session.ss2 => "9h30 - 11h30",
                Session.ss3 => "12h30 - 14h30",
                Session.ss4 => "14h30 - 16h30",
                _ => throw new InvalidEnumArgumentException(nameof(Session)),
            };
        }
    }
}
