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
