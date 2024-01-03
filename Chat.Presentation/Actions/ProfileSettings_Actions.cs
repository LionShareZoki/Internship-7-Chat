using Chat.Domain.Repositories;
using System;
using System.Collections.Generic;
using Chat.Presentation.Interfaces;

namespace Chat.Presentation.Actions
{
    public class ProfileSettings_Actions : IProfileSettingsActions
    {
        public readonly UserRepository _userRepository;

        public ProfileSettings_Actions(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

