public class DummyEvents {
    public static readonly List<Event> events = new()
    {
        new Event { Name = "Tech Conference 2025", Date = new DateTime(2025, 6, 10), Location = "New York" },
        new Event { Name = "Startup Pitch Night", Date = new DateTime(2025, 7, 22), Location = "San Francisco" },
        new Event { Name = "Developer Meetup", Date = new DateTime(2025, 8, 5), Location = "Austin" }
    };

    public static readonly List<string> ValidEventNames = new()
    {
        "Tech Conference 2025",
        "Startup Pitch Night",
        "Developer Meetup"
    };
}