using Chat.Data.Context;
using Chat.Data.Models;

namespace Chat.Domain.Repositories;

public class MessageRepository : IMessageRepository
{
    private readonly Func<ChatAppContext> _contextFactory;

    public MessageRepository(Func<ChatAppContext> contextFactory)
    {
        _contextFactory = contextFactory;
    }


    
    public void AddMessage(Message message)
    {
        try
        {
            using var context = _contextFactory();
            if (message == null)
            {
                throw new ArgumentNullException(nameof(message));
            }

            if (message.SentAt.Kind != DateTimeKind.Utc)
            {
                message.SentAt = message.SentAt.ToUniversalTime();
            }

            context.Messages.Add(message);
            context.SaveChanges();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
            if (ex.InnerException != null)
            {
                Console.WriteLine("Inner exception: " + ex.InnerException.Message);
            }
            throw;
        }
    }



}
