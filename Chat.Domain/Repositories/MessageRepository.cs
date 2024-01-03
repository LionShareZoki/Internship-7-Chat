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


