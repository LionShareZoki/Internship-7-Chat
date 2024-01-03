using Chat.Data.Models;

namespace Chat.Presentation.Actions
{
    public interface IAuthAction
    {
        void Login();
        void Logout();
    }
}