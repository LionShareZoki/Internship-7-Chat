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
