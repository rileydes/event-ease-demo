
namespace EventEase.Services
{
    public class EventService {
        private static readonly List<Event> events = new()
        {
            new Event { Name = "Tech Conference 2025", Date = new DateTime(2025, 6, 10), Location = "New York" },
            new Event { Name = "Startup Pitch Night", Date = new DateTime(2025, 7, 22), Location = "San Francisco" },
            new Event { Name = "Developer Meetup", Date = new DateTime(2025, 8, 5), Location = "Austin" },
            new Event { Name = "Football World Cup", Date = new DateTime(3020,10,10), Location = "Las Vegas" },
        };

        public async Task<List<Event>> GetEvents()
        {
            return events;
        }

        public async Task<Event?> GetEventByName(string eventName)
        {
            return events.FirstOrDefault(e => e.Name == eventName);
        }
    }
}