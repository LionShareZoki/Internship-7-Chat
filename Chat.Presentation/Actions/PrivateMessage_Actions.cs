using Chat.Domain.Repositories;
using Chat.Data.Context;
using System;
using System.Linq;
using Chat.Presentation.Interfaces;

namespace Chat.Presentation.Actions
{
    public class PrivateMessage_Actions : IPrivateMessageActions
    {
       public readonly PrivateMessageRepository _privateMessageRepository;
       public readonly Func<ChatAppContext> _contextFactory;

        public PrivateMessage_Actions(Func<ChatAppContext> contextFactory)
        {
            _contextFactory = contextFactory;
            _privateMessageRepository = new PrivateMessageRepository(contextFactory());
        }
