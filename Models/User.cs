namespace Add.ons.Web.Models;

public class User
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public string Fullname { get; set; }
    public string ProfileImageLink { get; set; }
    public User(int id, string username, string password, string email, string fullname, string profileImageLink)
    {
        Id = id;
        Username = username;
        Password = password;
        Email = email;
        Fullname = fullname;
        ProfileImageLink = profileImageLink;
    }
}
