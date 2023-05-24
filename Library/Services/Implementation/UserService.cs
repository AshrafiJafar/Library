using Library.Services.Interface;
using Microsoft.AspNetCore.Identity;

namespace Library.Services.Implementation
{
    public class UserService : IUserService
    {
        private readonly UserManager<IdentityUser> userManager;

        public UserService(UserManager<IdentityUser> userManager)
        {
            this.userManager = userManager;
        }
        public async Task CreatePersonUser(string userName, string password)
        {
            var identityUser = new IdentityUser(userName);
            var result = await userManager.CreateAsync(identityUser, password);

            if(result.Succeeded)
            {
                var user = await userManager.FindByNameAsync(userName);
                var resultRole = await userManager.AddToRoleAsync(user,"Person");
            }
        }
    }
}
