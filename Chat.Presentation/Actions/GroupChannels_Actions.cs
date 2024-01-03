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
