using Library.Services.Interface;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace Library.Services.Implementation
{
    public class PersonUserService : IPersonUserService
    {
        private readonly UserManager<IdentityUser> userManager;

        public PersonUserService(UserManager<IdentityUser> userManager)
        {
            this.userManager = userManager;
        }
        public async Task CreatePersonUser(string userName, string password, string id)
        {
            var identityUser = new IdentityUser(userName);
            var result = await userManager.CreateAsync(identityUser, password);
            
            if(result.Succeeded)
            {
                var user = await userManager.FindByNameAsync(userName);
                await userManager.AddToRoleAsync(user,"Person");
                await userManager.AddClaimAsync(user,new Claim("id", id));

            }
        }
    }
}
