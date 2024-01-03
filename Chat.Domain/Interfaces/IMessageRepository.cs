using Chat.Data.Models;

namespace Chat.Domain.Repositories
{
    public interface IMessageRepository
    {
        void AddMessage(Message message);
    }
}