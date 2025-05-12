using System.Collections.Generic;

namespace EventEase.Services
{
    public class AttendanceService
    {
        private readonly Dictionary<string, List<string>> attendance = new();

        public void Register(string eventName, string userName)
        {
            if (!attendance.ContainsKey(eventName))
                attendance[eventName] = new List<string>();

            if (!attendance[eventName].Contains(userName))
                attendance[eventName].Add(userName);
        }

        public IEnumerable<string> GetAttendees(string eventName) =>
            attendance.TryGetValue(eventName, out var attendees) ? attendees : new List<string>();
    }
}
