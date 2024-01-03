using Chat.Domain.Repositories;
using Chat.Data.Context;
using System;
using System.Linq;
using Chat.Presentation.Interfaces;

namespace Chat.Presentation.Actions
{
    public class PrivateMessage_Actions : IPrivateMessageActions
    {
       public readonly PrivateMessageRepository _privateMessageRepository;
       public readonly Func<ChatAppContext> _contextFactory;

        public PrivateMessage_Actions(Func<ChatAppContext> contextFactory)
        {
            _contextFactory = contextFactory;
            _privateMessageRepository = new PrivateMessageRepository(contextFactory());
        }


       public void SendMessage()
        {
            var users = _privateMessageRepository.GetAllUsers();
            Console.WriteLine("Choose a recipient:");

            for (int i = 0; i < users.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {users[i].Email}");
            }

            Console.Write("Enter your choice: ");
            if (int.TryParse(Console.ReadLine(), out int choice) && choice > 0 && choice <= users.Count)
            {
                int recipientId = users[choice - 1].UserId;

                Console.WriteLine("Enter your message:");
                string message = Console.ReadLine();

                int senderId = AuthAction.GetCurrentUserId() ?? 0;

                _privateMessageRepository.SendPrivateMessage(senderId, recipientId, message);

                ShowPrivateChatScreen(senderId, recipientId);
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }



       public void ViewConversation()
        {
            int userId = AuthAction.GetCurrentUserId() ?? 0;
            var users = _privateMessageRepository.GetUsersWithConversations(userId);

            Console.WriteLine("Select a user to view the conversation:");
            for (int i = 0; i < users.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {users[i].Email}");
            }

            Console.Write("Enter your choice: ");
            if (int.TryParse(Console.ReadLine(), out int choice) && choice > 0 && choice <= users.Count)
            {
                int recipientId = users[choice - 1].UserId;

                ShowPrivateChatScreen(userId, recipientId);
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }


        
        public void ShowPrivateMessagesMenu()
        {
            List<string> menuItems = new List<string> { "Send a New Message", "View Conversation", "Return to Main Menu" };
            int selectedIndex = 0;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("\nPrivate Messages Menu:");

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
                                SendMessage();
                                break;
                            case 1:
                                ViewConversation();
                                break;
                            case 2:
                                return; // Return to main menu
                        }
                        break;
                }
            }
        }

        
       public void DisplayConversation(int userId, int recipientId)
        {
            var messages = _privateMessageRepository.GetConversation(userId, recipientId);
            foreach (var message in messages)
            {
                string sender = message.SenderId == userId ? "You" : GetUserEmailById(message.SenderId);
                Console.WriteLine($"{sender} ({message.SentAt}): {message.Content}");
            }
        }
        
       public string GetUserEmailById(int userId)
        {
            return _privateMessageRepository.GetUserEmailById(userId);
        }
        
        public void ShowPrivateChatScreen(int userId, int recipientId)
        {
            var privateMessageRepository = new PrivateMessageRepository(_contextFactory());

            Console.Clear();
            Console.WriteLine($"Private chat with {privateMessageRepository.GetUserEmailById(recipientId)}:\n");

            var messages = privateMessageRepository.GetConversation(userId, recipientId);
            foreach (var message in messages)
            {
                var senderEmail = message.SenderId == userId ? "You" : privateMessageRepository.GetUserEmailById(message.SenderId);
                Console.WriteLine($"{message.SentAt} - {senderEmail}: {message.Content}");
            }

            Console.WriteLine("\nType your message below. Type /exit to return to the main menu.");

            while (true)
            {
                Console.Write("> ");
                string input = Console.ReadLine();

                if (input == "/exit")
                {
                    Console.WriteLine("Exiting chat screen...");
                    break;
                }

                privateMessageRepository.SendPrivateMessage(userId, recipientId, input);

                Console.Clear();
                Console.WriteLine($"Private chat with {privateMessageRepository.GetUserEmailById(recipientId)}:\n");
                messages = privateMessageRepository.GetConversation(userId, recipientId);
                foreach (var message in messages)
                {
                    var senderEmail = message.SenderId == userId ? "You" : privateMessageRepository.GetUserEmailById(message.SenderId);
                    Console.WriteLine($"{message.SentAt} - {senderEmail}: {message.Content}");
                }
            }
        }
        
        


    }
}