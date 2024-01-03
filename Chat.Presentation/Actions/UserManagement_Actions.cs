using Chat.Domain.Repositories;
using Chat.Data.Context;
using System;
using System.Collections.Generic;
using Chat.Presentation.Interfaces;

namespace Chat.Presentation.Actions
{
    public class UserManagement_Actions
    {
        public readonly UserRepository _userRepository;
        public readonly Func<ChatAppContext> _contextFactory;

        public UserManagement_Actions(Func<ChatAppContext> contextFactory)
        {
            _contextFactory = contextFactory;
            _userRepository = new UserRepository(contextFactory());
        }
