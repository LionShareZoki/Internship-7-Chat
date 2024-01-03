using Chat.Data.Models;
using Chat.Domain.Repositories;
using System;

namespace Chat.Presentation.Actions
{
    public class RegisterAction : IRegisterAction
    {
        private readonly UserRepository _userRepository;

        public RegisterAction(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }
