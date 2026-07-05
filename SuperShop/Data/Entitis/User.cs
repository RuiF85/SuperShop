using Microsoft.AspNetCore.Identity;

namespace SuperShop.Data.Entitis
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }


    }
}
