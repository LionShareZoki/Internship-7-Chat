using Chat.Data.Models;
using System.Collections.Generic;

namespace Chat.Domain.Repositories
{
    public interface IUserRepository
    {
        User GetById(int id);
        User GetByEmail(string email);
        List<User> GetAllUsers();
        void DeleteUser(int userId);
        void UpdateUserEmail(int userId, string newEmail);
        void PromoteUserToAdmin(int userId);
        bool EmailExists(string email);
        bool Add(User user);
        bool Authenticate(string email, string password);
        bool IsValidEmail(string email);
        void UpdateUserPassword(int userId, string newPassword);
        List<User> GetNonAdminUsers();
    }
}