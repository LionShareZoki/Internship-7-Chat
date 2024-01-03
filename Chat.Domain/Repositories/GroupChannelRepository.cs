using Chat.Data.Context;
using Chat.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace Chat.Domain.Repositories
{
    public class GroupChannelRepository : IGroupChannelRepository
    {
        private readonly ChatAppContext _context;

        public GroupChannelRepository(ChatAppContext context)
        {
            _context = context;
        }

        public void CreateNewChannel(string channelName, int userId)
        {
            var newChannel = new GroupChannel
            {
                ChannelName = channelName
            };

            _context.GroupChannels.Add(newChannel);
            _context.SaveChanges();

            var member = new ChannelMember
            {
                ChannelId = newChannel.ChannelId,
                UserId = userId,
                JoinedAt = DateTime.UtcNow
            };

            _context.ChannelMembers.Add(member);
            _context.SaveChanges();
        }

