using Chat.Data.Enums;

namespace Chat.Data.Models;

public class UserManagement
{
    public virtual User AdminUser { get; set; }
    public virtual User TargetUser { get; set; }
    public int ManagementId { get; set; }
    public int AdminUserId { get; set; }
    public int TargetUserId { get; set; }
    public UserManagementAction ActionType { get; set; }
    public DateTime ActionDate { get; set; }
}