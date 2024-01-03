namespace Chat.Presentation.Interfaces
{
    public interface IUserManagementActions
    {
        void ShowUserManagementMenu();
        void ListAllUsers();
        void DeleteUser();
        void UpdateUserEmail();
        void PromoteToAdmin();
    }
}