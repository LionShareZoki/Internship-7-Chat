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


        public GroupChannel EnterChannel(int channelId, int userId)
        {
            var channel = _context.GroupChannels.FirstOrDefault(gc => gc.ChannelId == channelId);
            if (channel == null) return null;

            var isMember = _context.ChannelMembers.Any(cm => cm.ChannelId == channelId && cm.UserId == userId);
            if (!isMember)
            {
                var member = new ChannelMember
                {
                    ChannelId = channelId,
                    UserId = userId,
                    JoinedAt = DateTime.UtcNow
                };

                _context.ChannelMembers.Add(member);
                _context.SaveChanges();
            }

            return channel;
        }


        public List<GroupChannel> GetUserChannels(int userId)
        {
            return _context.ChannelMembers
                .Where(cm => cm.UserId == userId)
                .Join(_context.GroupChannels,
                    cm => cm.ChannelId,
                    gc => gc.ChannelId,
                    (cm, gc) => gc)
                .ToList();
        }


        public List<GroupChannel> GetAvailableChannelsForUser(int userId)
        {
            var userChannelIds = _context.ChannelMembers
                .Where(cm => cm.UserId == userId)
                .Select(cm => cm.ChannelId)
                .ToList();

            var availableChannels = _context.GroupChannels
                .Where(gc => !userChannelIds.Contains(gc.ChannelId))
                .ToList();

            return availableChannels;
        }

        public string GetUserEmailById(int userId)
        {
            return _context.Users.Where(u => u.UserId == userId).Select(u => u.Email).FirstOrDefault();
        }

        
