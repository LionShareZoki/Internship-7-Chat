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

        public void ShowProfileSettingsMenu(int userId)
        {
            List<string> menuItems = new List<string> { "Change Email", "Change Password", "Return to Main Menu" };
            int selectedIndex = 0;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("\nProfile Settings:");

                for (int i = 0; i < menuItems.Count; i++)
                {
                    if (i == selectedIndex)
                    {
                        Console.BackgroundColor = ConsoleColor.Gray;
                        Console.ForegroundColor = ConsoleColor.Black;
                    }

                    Console.WriteLine($"{i + 1}. {menuItems[i]}");
                    Console.ResetColor();
                }

                ConsoleKeyInfo keyInfo = Console.ReadKey();
                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow:
                        selectedIndex = (selectedIndex > 0) ? selectedIndex - 1 : menuItems.Count - 1;
                        break;

                    case ConsoleKey.DownArrow:
                        selectedIndex = (selectedIndex < menuItems.Count - 1) ? selectedIndex + 1 : 0;
                        break;

                    case ConsoleKey.Enter:
                        switch (selectedIndex)
                        {
                            case 0:
                                ChangeEmail(userId);
                                break;
                            case 1:
                                ChangePassword(userId);
                                break;
                            case 2:
                                return;
                        }
                        break;
                }
            }
        }

        public void ChangeEmail(int userId)
        {
            Console.Write("Enter new email: ");
            string newEmail = Console.ReadLine();

            if (_userRepository.IsValidEmail(newEmail))
            {
                if (!_userRepository.EmailExists(newEmail))
                {
                    _userRepository.UpdateUserEmail(userId, newEmail);
                    Console.WriteLine("Email updated successfully.");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Email already exists. Please try a different one.");
                    Console.ReadKey();

                }
            }
            else
            {
                Console.WriteLine("Invalid email format. Please try again.");
                Console.ReadKey();

            }
        }

        public void ChangePassword(int userId)
        {
            Console.Write("Enter new password: ");
            string newPassword = Console.ReadLine();
            

            _userRepository.UpdateUserPassword(userId, newPassword);
            Console.WriteLine("Password updated successfully.");
        }
    }
}
