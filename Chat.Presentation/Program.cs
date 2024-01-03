using Chat.Data.Context;
using Chat.Domain.Repositories;
using Chat.Presentation.Actions;
using System;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
        var contextFactory = new ChatAppContextFactory();
        var userRepository = new UserRepository(contextFactory.CreateDbContext(args));
        var authAction = new AuthAction(userRepository);
        var registerAction = new RegisterAction(userRepository);

        while (true)
        {
            var MainMenu = new List<string> { "Login", "Register" };
            int choice = ShowMenu("Please select an option:", MainMenu);

            switch (choice)
            {
                case 1: 
                    authAction.Login();
                    if (AuthAction.GetCurrentlyAuthenticatedUser() != null)
                    {
                        UserSubMenu(authAction, userRepository, contextFactory, args);
                    }
                    break;
                case 2:
                    registerAction.Register();
                    break;
                default:
                    Console.WriteLine("Invalid selection. Please try again.");
                    break;
            }
        }
    }
    
    static void UserSubMenu(AuthAction authAction, UserRepository userRepository, ChatAppContextFactory contextFactory, string[] args)
    {
        var user = AuthAction.GetCurrentlyAuthenticatedUser();
        bool isAdmin = user?.isAdmin ?? false;

        var userMenu = new List<string>
        {
            "Group Channels",
            "Private Messages",
            "Profile Settings",
            "Logout"
        };

        if (isAdmin)
        {
            userMenu.Insert(2, "User Management");
        }

        while (true)
        {
            int choice = ShowMenu("Menu:", userMenu);

            switch (choice)
            {
                case 1:
                    var groupChannelActions = new GroupChannel_Actions(() => contextFactory.CreateDbContext(args));
                    groupChannelActions.ShowGroupChannelsMenu();
                    break;
                case 2:
                    var privateMessageActions = new PrivateMessage_Actions(() => contextFactory.CreateDbContext(args));
                    privateMessageActions.ShowPrivateMessagesMenu();
                    break;
                case 3:
                    if (isAdmin)
                    {
                        var userManagementActions = new UserManagement_Actions(() => contextFactory.CreateDbContext(args));
                        userManagementActions.ShowUserManagementMenu();
                    }
                    else
                    {
                        var profileSettingsActions = new ProfileSettings_Actions(userRepository);
                        profileSettingsActions.ShowProfileSettingsMenu(user.UserId);
                    }
                    break;
                case 4:
                    if (isAdmin)
                    {
                        var profileSettingsActions = new ProfileSettings_Actions(userRepository);
                        profileSettingsActions.ShowProfileSettingsMenu(user.UserId);
                    }
                    else
                    {
                        authAction.Logout();
                        return;
                    }
                    break;
                case 5:
                    authAction.Logout();
                    return;
            }
        }
    }

    public static int ShowMenu(string prompt, List<string> items)
    {
        int selectedIndex = 0;

        ConsoleKey keyPressed;
        do
        {
            Console.Clear();
            Console.WriteLine(prompt);

            for (int i = 0; i < items.Count; i++)
            {
                if (i == selectedIndex)
                {
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Black;
                }

                Console.WriteLine($"{i + 1}. {items[i]}");
                Console.ResetColor();
            }

            ConsoleKeyInfo keyInfo = Console.ReadKey();
            keyPressed = keyInfo.Key;

            // Move the selection up or down based on the arrow keys
            if (keyPressed == ConsoleKey.UpArrow)
            {
                selectedIndex = (selectedIndex == 0) ? items.Count - 1 : selectedIndex - 1;
            }
            else if (keyPressed == ConsoleKey.DownArrow)
            {
                selectedIndex = (selectedIndex == items.Count - 1) ? 0 : selectedIndex + 1;
            }

        } while (keyPressed != ConsoleKey.Enter);

        return selectedIndex + 1; // Return the selected index (1-based)
    }
}
