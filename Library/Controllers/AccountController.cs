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
            var identityUser = new IdentityUser("admin");
            var result = await userManager.CreateAsync(identityUser, "QWErty123@@");

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

            var result = await signInManager.PasswordSignInAsync(command.UserName, command.Password, false, false);

            if(result.Succeeded)
            {
                return Redirect(command.ReturnUrl ?? "/Person/Index");
            }
            ViewBag.Error = "Incorrect username or password";
            return View(command);
        }
    }
}
