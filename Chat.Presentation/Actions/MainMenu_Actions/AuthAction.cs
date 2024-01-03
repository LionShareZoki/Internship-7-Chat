using Chat.Data.Models;
using Chat.Domain.Repositories;
using System;

namespace Chat.Presentation.Actions
{
    public class AuthAction : IAuthAction
    {
        private static User? _currentlyAuthenticatedUser = null;
        private readonly UserRepository _userRepository;
        private DateTime _lastFailedLoginTime;
        
        public static int? GetCurrentUserId()
        {
            return _currentlyAuthenticatedUser?.UserId;
        }
