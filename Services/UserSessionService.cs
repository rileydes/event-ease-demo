namespace EventEase.Services
{
    public class UserSessionService
    {
        public string? CurrentUsername {get; set;}
        public string? CurrentEmail {get; set;}
        public bool? IsRegistered => !string.IsNullOrEmpty(CurrentUsername) && !string.IsNullOrEmpty(CurrentEmail);

        public void RegisterUser(string username, string email)
        {
            CurrentUsername = username;
            CurrentEmail = email;
        }

        public void Logout()
        {
            CurrentUsername = null;
            CurrentEmail = null;
        }
    }
}
