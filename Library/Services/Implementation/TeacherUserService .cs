using Library.Services.Interface;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace Library.Services.Implementation
{
    public class TeacherUserService : ITeacherUserService
    {
        private readonly UserManager<IdentityUser> userManager;

        public TeacherUserService(UserManager<IdentityUser> userManager)
        {
            this.userManager = userManager;
        }
        public async Task CreateTeacherUser(string userName, string password, string id)
        {
            var identityUser = new IdentityUser(userName);
            var result = await userManager.CreateAsync(identityUser, password);
            
            if(result.Succeeded)
            {
                var user = await userManager.FindByNameAsync(userName);
                await userManager.AddToRoleAsync(user,"Teacher");
                await userManager.AddClaimAsync(user,new Claim("id", id));

            }
        }
    }
}
