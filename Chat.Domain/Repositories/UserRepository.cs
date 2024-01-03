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

