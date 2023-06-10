using Library.Models.Command;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Library.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<IdentityUser> signInManager;
        private readonly UserManager<IdentityUser> userManager;

        public AccountController(SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager)
        {
            this.signInManager = signInManager;
            this.userManager = userManager;
        }

        public async Task<IActionResult> CreateUser()
        {
            var identityUser = new IdentityUser("admin2");
            var result = await userManager.CreateAsync(identityUser, "123");

            return Redirect("/Person/Index");
        }

        public IActionResult Login(string? returnUrl)
        {
            var command = new LoginCommand { ReturnUrl = returnUrl };
            return View(command);
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginCommand command)
        {

            if (command.ReturnUrl == "/")
                command.ReturnUrl = null;

            var result = await signInManager.PasswordSignInAsync(command.UserName, command.Password, true, false);

            var user = await userManager.FindByNameAsync(command.UserName);
            var claims = await userManager.GetClaimsAsync(user);
            var id = claims.SingleOrDefault(x => x.Type == "id")?.Value;
            var isSalonAdmin = await userManager.IsInRoleAsync(user, "SalonAdmin");
            var isTeacherUser = await userManager.IsInRoleAsync(user, "Teacher");
            var isPersonUser = await userManager.IsInRoleAsync(user, "Person");

            if (result.Succeeded && isSalonAdmin)
            {
                return Redirect(command.ReturnUrl ?? "/Person/Index");
            }
            else if (result.Succeeded && isTeacherUser)
            {
                return Redirect(command.ReturnUrl ?? "/TeacherHome/Index");
            }
            else if (result.Succeeded && isPersonUser)
            {
                return Redirect(command.ReturnUrl ?? "/PersonHome/Index?id="+ id);
            }
            ViewBag.Error = "Incorrect username or password";
            return View(command);
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Person");
        }

        [HttpGet]
        public IActionResult AccessDenied()
        {

            return View();
        }
    }
}
