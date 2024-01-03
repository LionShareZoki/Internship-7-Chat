using Chat.Data.Enums;

namespace Chat.Data.Models;

public class ProfileSetting
{
    public virtual User User { get; set; }
    public int SettingId { get; set; }
    public int UserId { get; set; }
    public ProfileSettingsType SettingType { get; set; }
    public DateTime UpdatedAt { get; set; }
}