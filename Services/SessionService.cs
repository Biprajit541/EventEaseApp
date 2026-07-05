using EventEaseApp.Models;

namespace EventEaseApp.Services;

public class SessionService
{
    public UserSession CurrentUser { get; } = new();

    public void Login(string userName)
    {
        CurrentUser.IsLoggedIn = true;
        CurrentUser.UserName = userName;
    }

    public void Logout()
    {
        CurrentUser.IsLoggedIn = false;
        CurrentUser.UserName = string.Empty;
        CurrentUser.RegisteredEventId = 0;
    }
}