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

        public AuthAction(UserRepository userRepository)
        {
            _userRepository = userRepository;
            _lastFailedLoginTime = DateTime.MinValue;
        }

        public void Login()
        {
            if (DateTime.Now - _lastFailedLoginTime < TimeSpan.FromSeconds(30))
            {
                Console.WriteLine("Too many failed attempts. Please wait 30 seconds.");
                Console.ReadKey();
                return;
            }

            Console.Clear();
            Console.WriteLine("Login");

            Console.Write("Enter Email: ");
            string email = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(email))
            {
                Console.WriteLine("Invalid email format.");
                return;
            }

            Console.Write("Enter Password: ");
            string password = Console.ReadLine();

            bool isAuthenticated = _userRepository.Authenticate(email, password);

            if (!isAuthenticated)
            {
                Console.WriteLine("Wrong credentials, try again in 30 seconds.");
                _lastFailedLoginTime = DateTime.Now;
                Console.ReadKey();
                return;
            }

            _currentlyAuthenticatedUser = _userRepository.GetByEmail(email);
            Console.WriteLine($"Authenticated as {email.ToLower()}.");
        }


        public static User? GetCurrentlyAuthenticatedUser()
        {
            return _currentlyAuthenticatedUser;
        }

        public void Logout()
        {
            _currentlyAuthenticatedUser = null;
        }
    }
}