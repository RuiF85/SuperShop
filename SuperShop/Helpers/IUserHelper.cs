using Microsoft.AspNetCore.Identity;
using SuperShop.Data.Entitis;
using SuperShop.Models;
using System.Threading.Tasks;

namespace SuperShop.Helpers
{
    public interface IUserHelper
    {
        Task<User> GetUserByEmailAsync(string email);

        Task<IdentityResult> AddUserAsync(User user, string password);

        Task<SignInResult> LoginAsync(LogInViewModel model);

        Task LogoutAsync();
    }
}
