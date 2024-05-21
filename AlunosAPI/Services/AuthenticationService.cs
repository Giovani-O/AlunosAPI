using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace AlunosAPI.Services
{
    public class AuthenticationService : IAuthentication
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        public AuthenticationService(SignInManager<IdentityUser> signInManager)
        {
            _signInManager = signInManager;
        }

        public async Task<bool> Authenticate(string email, string password)
        {
            var result = await _signInManager.PasswordSignInAsync(email, password, false, lockoutOnFailure: false);

            return result.Succeeded;
        }

        public async Task Logout()
        {
            await _signInManager.SignOutAsync();
        }
    }
}
