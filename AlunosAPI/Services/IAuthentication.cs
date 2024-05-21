using System.Threading.Tasks;

namespace AlunosAPI.Services
{
    public interface IAuthentication
    {
        Task<bool> Authenticate(string email, string password);
        Task<bool> RegisterUser(string email, string password);
        Task Logout();
    }
}
