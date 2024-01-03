namespace Chat.Data.Models;

public class User
{

    public int UserId { get; set; }
    public string Email { get; set; }
    
    public string Password { get; set; }
    public bool isAdmin { get; set; } = false;
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    
    public virtual ICollection<UserSession> UserSessions { get; set; }
    public virtual ICollection<ProfileSetting> ProfileSettings { get; set; }
    public virtual ICollection<UserManagement> UserManagements { get; set; }
}