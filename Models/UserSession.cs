namespace EventEaseApp.Models;

public class UserSession
{
    public bool IsLoggedIn { get; set; }

    public string UserName { get; set; } = string.Empty;

    public int RegisteredEventId { get; set; }
}