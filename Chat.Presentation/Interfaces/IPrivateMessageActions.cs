namespace Chat.Presentation.Interfaces
{
    public interface IPrivateMessageActions
    {
        void ShowPrivateMessagesMenu();
        void ShowPrivateChatScreen(int userId, int recipientId);
        void SendMessage();
        void ViewConversation();
        void DisplayConversation(int userId, int recipientId);
        string GetUserEmailById(int userId);
    }
}