using Microsoft.AspNetCore.Identity;
using SuperShop.Data.Entitis;
using SuperShop.Models;
using System.Threading.Tasks;

namespace SuperShop.Helpers
{
    public class UserHelper : IUserHelper
    {
        private readonly UserManager<User> _userManeger;
        private readonly SignInManager<User> _signInManager;

        public UserHelper(UserManager<User> userManeger, SignInManager<User> signInManager)  //injectar outro metodo 
        {
            _userManeger = userManeger;
            _signInManager = signInManager;
        }

        public async Task<IdentityResult> AddUserAsync(User user, string password)
        {
            return await _userManeger.CreateAsync(user, password);
        }

        public async Task<User> GetUserByEmailAsync(string email)
        {
            return await _userManeger.FindByEmailAsync(email);
        }

        public async Task<SignInResult> LoginAsync(LogInViewModel model)
        {
            return await _signInManager.PasswordSignInAsync(
                model.Username,
                model.Password,
                model.RememberMe,
                false);
        }

        public async Task LogoutAsync()
        {
            await _signInManager.SignOutAsync();
        }
    }
}
