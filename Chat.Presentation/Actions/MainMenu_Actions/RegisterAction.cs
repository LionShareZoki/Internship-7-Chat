using Chat.Data.Models;
using Chat.Domain.Repositories;
using System;

namespace Chat.Presentation.Actions
{
    public class RegisterAction : IRegisterAction
    {
        private readonly UserRepository _userRepository;

        public RegisterAction(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

   public void Register()
{
    Console.Clear();
    Console.WriteLine("Register");

    Console.Write("Enter Email: ");
    string email = Console.ReadLine();
    if (string.IsNullOrWhiteSpace(email) || !_userRepository.IsValidEmail(email))
    {
        Console.WriteLine("Invalid email format. Please ensure the format is correct.");
        Console.ReadKey();
        return;
    }

    if (_userRepository.EmailExists(email))
    {
        Console.WriteLine("Email already exists. Please use a different email address.");
        Console.ReadKey();
        return;
    }

    string password, confirmPassword;
    do
    {
        Console.Write("Enter Password: ");
        password = Console.ReadLine();
        Console.Write("Confirm Password: ");
        confirmPassword = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(password) || password != confirmPassword)
        {
            Console.WriteLine("Passwords do not match. Please try again.");
            Console.ReadKey();
            Console.Clear();
        }

    } while (string.IsNullOrWhiteSpace(password) || password != confirmPassword);

    string captchaInput;
    do
    {
        string captcha = GenerateCaptcha();
        Console.WriteLine($"Please enter the following captcha to verify: {captcha}");
        captchaInput = Console.ReadLine();

        if (captchaInput != captcha)
        {
            Console.WriteLine("Captcha did not match. Please try again.");
            Console.ReadKey();
            Console.Clear();
        }

    } while (captchaInput != GenerateCaptcha());

    User newUser = new User
    {
        Email = email,
        Password = password,
        CreatedAt = DateTime.UtcNow,
        UpdatedAt = DateTime.UtcNow
    };

    bool isRegistered = _userRepository.Add(newUser);

    if (isRegistered)
    {
        Console.WriteLine("Registration successful! You are now registered.");
    }
    else
    {
        Console.WriteLine("Registration failed. There was a problem processing your registration.");
    }
    Console.ReadKey();
}

private string GenerateCaptcha()
{
    var random = new Random();
    var captcha = new string(Enumerable.Repeat("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", 6)
        .Select(s => s[random.Next(s.Length)]).ToArray());
    return captcha;
}



    }
    
}