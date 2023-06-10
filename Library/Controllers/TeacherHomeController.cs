using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace Library.Controllers
{
    [Authorize(Roles = "Teacher")]
    public class TeacherHomeController : Controller
    {
           public IActionResult Index()
        {
            return View();
        }
    }
}
