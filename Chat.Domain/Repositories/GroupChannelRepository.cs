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

