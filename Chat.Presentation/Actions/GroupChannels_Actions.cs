using Chat.Domain.Repositories;
using Chat.Data.Context; 
using Chat.Data.Models;
using Chat.Presentation.Interfaces;

namespace Chat.Presentation.Actions
{
    public class GroupChannel_Actions : IGroupChannelActions
    {
        private readonly GroupChannelRepository _groupChannelRepository;
        private readonly Func<ChatAppContext> _contextFactory;

        public GroupChannel_Actions(Func<ChatAppContext> contextFactory)
        {
            _contextFactory = contextFactory;
            _groupChannelRepository = new GroupChannelRepository(contextFactory());
        }

        public void ShowGroupChannelsMenu()
        {
            var groupChannelsMenu = new List<string>
            {
                "Create New Channel",
                "Enter Channel",
                "Print All Channels User Has Entered",
                "Return to Main Menu"
            };

            while (true)
            {
                int choice = Program.ShowMenu("SubMenu:", groupChannelsMenu);

                switch (choice)
                {
                    case 1:
                        CreateNewChannel();
                        break;
                    case 2:
                        EnterChannel();
                        break;
                    case 3:
                        PrintAllUserChannels();
                        break;
                    case 4: 
                        return;
                    default:
                        return;
                }
            }
        }

        public void CreateNewChannel()
        {
            Console.Write("Enter Channel Name: ");
            string channelName = Console.ReadLine();
            int? userId = AuthAction.GetCurrentUserId();

            int actualUserId = userId ?? 0;

            using (var context = _contextFactory())
            {
                var groupChannelRepository = new GroupChannelRepository(context);
                groupChannelRepository.CreateNewChannel(channelName, actualUserId);
                Console.WriteLine("Channel created successfully.");
                Console.ReadKey();
            }
        }

        public void EnterChannel()
        {
            int? userId = AuthAction.GetCurrentUserId();
            int actualUserId = userId ?? 0;

            using (var context = _contextFactory())
            {
                var groupChannelRepository = new GroupChannelRepository(context);

                var availableChannels = groupChannelRepository.GetAvailableChannelsForUser(actualUserId);
                if (availableChannels.Count == 0)
                {
                    Console.WriteLine("No new channels available to enter.");
                    Console.ReadKey();
                    return;
                }

                Console.WriteLine("Select a channel to enter:");
                int selectedIndex = SelectFromList(availableChannels.Select(c => c.ChannelName).ToList(), "Channels:");

                if (selectedIndex >= 0)
                {
                    var selectedChannel = availableChannels[selectedIndex];
            
                    groupChannelRepository.EnterChannel(selectedChannel.ChannelId, actualUserId);
                    Console.WriteLine($"You have entered the channel: {selectedChannel.ChannelName}");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Invalid selection.");
                }
            }
        }



        public void PrintAllUserChannels()
        {
            int? userId = AuthAction.GetCurrentUserId();

            if (userId.HasValue)
            {
                using (var context = _contextFactory())
                {
                    var groupChannelRepository = new GroupChannelRepository(context);
                    var channels = groupChannelRepository.GetUserChannels(userId.Value);

                    if (channels.Count == 0)
                    {
                        Console.WriteLine("No channels found.");
                        return;
                    }

                    Console.WriteLine("Channels:");
                    int selectedIndex = SelectFromList(channels.Select(c => c.ChannelName).ToList(), "Select a channel or use arrows to navigate:");

                    if (selectedIndex >= 0)
                    {
                        var selectedChannel = channels[selectedIndex];
                        var messageRepository = new MessageRepository(_contextFactory);
                        ShowChatScreen(messageRepository, selectedChannel, context);
                    }
                }
            }
            else
            {
                Console.WriteLine("Unable to retrieve user ID.");
            }
        }
        
        
        
        public static int SelectFromList(List<string> items, string prompt)
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

                if (keyPressed == ConsoleKey.UpArrow)
                {
                    selectedIndex = (selectedIndex == 0) ? items.Count - 1 : selectedIndex - 1;
                }
                else if (keyPressed == ConsoleKey.DownArrow)
                {
                    selectedIndex = (selectedIndex == items.Count - 1) ? 0 : selectedIndex + 1;
                }

            } while (keyPressed != ConsoleKey.Enter);

            return selectedIndex;
        }

        
        public void ShowChatScreen(MessageRepository messageRepository, GroupChannel channel, ChatAppContext context)
        {
            var groupChannelRepository = new GroupChannelRepository(context);
            Console.Clear();
            Console.WriteLine($"Chat screen for channel: {channel.ChannelName}\n");

            var messages = groupChannelRepository.GetChannelMessages(channel.ChannelId);
            foreach (var message in messages)
            {
                var senderEmail = groupChannelRepository.GetUserEmailById(message.SenderId); // Retrieve sender email
                Console.WriteLine($"{message.SentAt} - {senderEmail}: {message.Content}"); // Display email instead of SenderId
            }

            Console.WriteLine("\nType your message below. Type /exit to return to the main menu.");

            while (true)
            {
                Console.Write("> ");
                string input = Console.ReadLine();

                if (input == "/exit")
                {
                    Console.WriteLine("Exiting chat screen...");
                    return;
                }

                SendMessageToChannel(messageRepository, channel, input);
            }
        }




        public void SendMessageToChannel(MessageRepository messageRepository, GroupChannel channel, string content)
        {
            if (string.IsNullOrWhiteSpace(content))
            {
                Console.WriteLine("Message cannot be empty.");
                return;
            }

            int senderId = AuthAction.GetCurrentUserId() ?? 0;
            var newMessage = new Message
            {
                SenderId = senderId,
                ChannelId = channel.ChannelId,
                Content = content,
                SentAt = DateTime.UtcNow
            };

            messageRepository.AddMessage(newMessage);
            Console.WriteLine("Message sent!");

            using (var context = _contextFactory())
            {
                ShowChatScreen(messageRepository, channel, context);
            }
        }



        public static GroupChannel GetSelectedChannel(Func<ChatAppContext> contextFactory, int userId)
        {
            using (var context = contextFactory())
            {
                var groupChannelRepository = new GroupChannelRepository(context);
                var channels = groupChannelRepository.GetUserChannels(userId);
                if (channels.Any())
                {
                    for (int i = 0; i < channels.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {channels[i].ChannelName}");
                    }

                    Console.WriteLine("Select a channel:");
                    if (int.TryParse(Console.ReadLine(), out int choice) && choice > 0 && choice <= channels.Count)
                    {
                        return channels[choice - 1];
                    }
                }
                else
                {
                    Console.WriteLine("No channels found.");
                }

                return null;
            }
            
            
        }
    }
}
