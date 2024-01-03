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

        public void ShowUserManagementMenu()
        {
            var userManagementMenu = new List<string>
            {
                "List All Users",
                "Delete User",
                "Update User Email",
                "Promote to Admin",
                "Return to Main Menu"
            };

            while (true)
            {
                int choice = Program.ShowMenu("User Management Menu:", userManagementMenu);

                switch (choice)
                {
                    case 1:
                        ListAllUsers();
                        break;
                    case 2:
                        DeleteUser();
                        break;
                    case 3:
                        UpdateUserEmail();
                        break;
                    case 4:
                        PromoteToAdmin();
                        break;
                    case 5:
                        return;
                }
            }
        }

        public void ListAllUsers()
        {
            var users = _userRepository.GetAllUsers();
            foreach (var user in users)
            {
                Console.WriteLine($"ID: {user.UserId}, Email: {user.Email}, Is Admin: {user.isAdmin}, Created At: {user.CreatedAt}");
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }


        public void DeleteUser()
        {
            Console.WriteLine("Enter the ID of the user to delete:");
            if (int.TryParse(Console.ReadLine(), out int userId))
            {
                _userRepository.DeleteUser(userId);
                Console.WriteLine("User deleted successfully.");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid user ID.");
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
