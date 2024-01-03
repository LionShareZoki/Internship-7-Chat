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
