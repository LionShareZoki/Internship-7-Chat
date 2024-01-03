namespace Chat.Data.Models;

public class ChannelMember
{
    public int MembershipId { get; set; }
    public int ChannelId { get; set; }
    public int UserId { get; set; }
    public DateTime JoinedAt { get; set; }
}