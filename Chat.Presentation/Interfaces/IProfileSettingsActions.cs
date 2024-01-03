namespace Chat.Presentation.Interfaces
{
    public interface IProfileSettingsActions
    {
        void ShowProfileSettingsMenu(int userId);
        void ChangeEmail(int userId);
        void ChangePassword(int userId);
    }
}