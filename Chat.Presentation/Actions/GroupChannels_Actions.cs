using Chat.Domain.Repositories;
using Chat.Data.Context; 
using Chat.Data.Models;
using Chat.Presentation.Interfaces;

namespace Chat.Presentation.Actions
{
    public class GroupChannel_Actions : IGroupChannelActions
    {
        private readonly GroupChannelRepository _groupChannelRepository;
        private readonly Func<ChatAppContext> _contextFactory;

        public GroupChannel_Actions(Func<ChatAppContext> contextFactory)
        {
            _contextFactory = contextFactory;
            _groupChannelRepository = new GroupChannelRepository(contextFactory());
        }

