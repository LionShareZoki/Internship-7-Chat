using Chat.Data.Context;
using Chat.Data.Models;
using System.Collections.Generic;
using System.Linq;
using System;

namespace Chat.Domain.Repositories
{
    public class PrivateMessageRepository : IPrivateMessageRepository
    {
        private readonly ChatAppContext _context;

        public PrivateMessageRepository(ChatAppContext context)
        {
            _context = context;
        }

        public void SendPrivateMessage(int senderId, int recipientId, string content)
        {
            var newMessage = new Message
            {
                SenderId = senderId,
                RecipientId = recipientId,
                Content = content,
                SentAt = DateTime.UtcNow,
                ChannelId = null
            };

            _context.Messages.Add(newMessage);
            _context.SaveChanges();
        }
