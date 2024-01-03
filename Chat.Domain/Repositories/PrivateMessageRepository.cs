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


        public List<Message> GetConversation(int userId, int recipientId)
        {
            return _context.Messages
                .Where(m => (m.SenderId == userId && m.RecipientId == recipientId) || 
                            (m.SenderId == recipientId && m.RecipientId == userId))
                .OrderBy(m => m.SentAt)
                .ToList();
        }

        public List<User> GetAllUsers()
        {
            return _context.Users.ToList();
        }

        public List<User> GetUsersWithConversations(int userId)
        {
            var userIds = _context.Messages
                .Where(m => m.SenderId == userId || m.RecipientId == userId)
                .Select(m => m.SenderId == userId ? m.RecipientId : m.SenderId)
                .Distinct()
                .ToList();

            var users = _context.Users
                .Where(u => userIds.Contains(u.UserId))
                .ToList();

            return users;
        }
