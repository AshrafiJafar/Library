using Library.Models.Command;
using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Create(RegisterPersonCommand command)
        {
            return View();
        }

    }
}
