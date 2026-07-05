using EventEaseApp.Models;

namespace EventEaseApp.Services;

public class EventService
{
    private readonly List<Event> events =
    [
        new()
        {
            Id = 1,
            Name = "Tech Conference 2026",
            Date = new DateTime(2026, 8, 15),
            Location = "New York",
            Description = "Annual technology conference."
        },

        new()
        {
            Id = 2,
            Name = "Business Meetup",
            Date = new DateTime(2026, 9, 10),
            Location = "Chicago",
            Description = "Networking for business professionals."
        },

        new()
        {
            Id = 3,
            Name = "Music Festival",
            Date = new DateTime(2026, 10, 5),
            Location = "Los Angeles",
            Description = "Outdoor music festival."
        }
    ];

    public IReadOnlyList<Event> GetEvents()
    {
        return events;
    }

    public Event? GetEventById(int id)
    {
        return events.FirstOrDefault(e => e.Id == id);
    }
}