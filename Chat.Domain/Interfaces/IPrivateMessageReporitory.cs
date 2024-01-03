using Chat.Data.Models;
using System.Collections.Generic;

namespace Chat.Domain.Repositories
{
    public interface IPrivateMessageRepository
    {
        void SendPrivateMessage(int senderId, int recipientId, string content);
        List<Message> GetConversation(int userId, int recipientId);
        List<User> GetAllUsers();
        List<User> GetUsersWithConversations(int userId);
        string GetUserEmailById(int userId);
    }
}