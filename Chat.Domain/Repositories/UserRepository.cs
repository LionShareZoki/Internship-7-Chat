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

