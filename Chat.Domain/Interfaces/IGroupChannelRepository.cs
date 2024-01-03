using Chat.Data.Models;

public interface IGroupChannelRepository
{
    void CreateNewChannel(string channelName, int userId);
    GroupChannel EnterChannel(int channelId, int userId);
    List<GroupChannel> GetUserChannels(int userId);
    List<GroupChannel> GetAvailableChannelsForUser(int userId);
    List<Message> GetChannelMessages(int channelId);
    string GetUserEmailById(int userId);
}