using Chat.Data.Context;
using Chat.Data.Models;
using Chat.Domain.Repositories;


namespace Chat.Presentation.Interfaces
{
    public interface IGroupChannelActions
    {
        void ShowGroupChannelsMenu();
        void CreateNewChannel();
        void EnterChannel();
        void PrintAllUserChannels();
        void ShowChatScreen(MessageRepository messageRepository, GroupChannel channel, ChatAppContext context);
        void SendMessageToChannel(MessageRepository messageRepository, GroupChannel channel, string content);
    }
}