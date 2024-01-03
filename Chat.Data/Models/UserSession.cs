namespace Chat.Data.Models;

public class UserSession
{
    public virtual User User { get; set; }
    public int UserSessionId { get; set; }
    public int UserId { get; set; }
    public string SessionToken { get; set; }
    public DateTime ExpiresAt { get; set; }
}