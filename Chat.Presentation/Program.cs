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

