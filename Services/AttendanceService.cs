namespace EventEaseApp.Services;

public class AttendanceService
{
    private readonly HashSet<int> registeredEvents = [];

    public void Register(int eventId)
    {
        registeredEvents.Add(eventId);
    }

    public bool IsRegistered(int eventId)
    {
        return registeredEvents.Contains(eventId);
    }

    public IReadOnlyCollection<int> GetRegisteredEvents()
    {
        return registeredEvents;
    }

    public int TotalRegistrations()
    {
        return registeredEvents.Count;
    }
}