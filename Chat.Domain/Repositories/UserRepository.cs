using System;
using System.Linq;
using System.Collections.Generic;  // Add this for using List
using System.Text.RegularExpressions;
using Chat.Data.Context;
using Chat.Data.Models;
using Chat.Domain.Cryptography;

namespace Chat.Domain.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ChatAppContext context; 

        public UserRepository(ChatAppContext context)
        {
            this.context = context;
        }

        public User GetById(int id)
        {
            return context.Users.Find(id);
        }

        public User GetByEmail(string email)
        {
            return context.Users.FirstOrDefault(u => u.Email.ToLower() == email.ToLower());
        }

        public List<User> GetAllUsers()
        {
            return context.Users.ToList();
        }

        public void DeleteUser(int userId)
        {
            var user = GetById(userId);
            if (user != null)
            {
                context.Users.Remove(user);
                context.SaveChanges();
            }
        }

        public void UpdateUserEmail(int userId, string newEmail)
        {
            var user = GetById(userId);
            if (user != null && IsValidEmail(newEmail))
            {
                user.Email = newEmail.ToLower();
                context.SaveChanges();
            }
        }

        public void PromoteUserToAdmin(int userId)
        {
            var user = GetById(userId);
            if (user != null)
            {
                user.isAdmin = true;
                context.SaveChanges();
            }
        }

        public bool EmailExists(string email)
        {
            return context.Users.Any(u => u.Email.ToLower() == email.ToLower());
        }

        public bool Add(User user)
        {
            if (!IsValidEmail(user.Email) || EmailExists(user.Email))
            {
                return false;
            }

            user.Password = Password.Hash(user.Password);
            user.Email = user.Email.ToLower();

            context.Users.Add(user);
            context.SaveChanges();
            return true;
        }

        public bool Authenticate(string email, string password)
        {
            var user = GetByEmail(email);
            if (user == null)
            {
                return false;
            }

            return Password.Verify(password, user.Password);
        }

        public bool IsValidEmail(string email)
        {
            return Regex.IsMatch(email, "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$");
        }
        
        public void UpdateUserPassword(int userId, string newPassword)
        {
            var user = GetById(userId);
            if (user != null)
            {
                user.Password = Password.Hash(newPassword);
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("User not found.");
            }
        }
        
        public List<User> GetNonAdminUsers()
        {
            return context.Users.Where(u => !u.isAdmin).ToList();
        }



    }
}


