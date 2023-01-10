using Library.Models.Command;
using Library.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers
{
    public class PersonController : Controller
    {
        private readonly IRegisterPersonService registerPersonService;

        public PersonController(IRegisterPersonService registerPersonService)
        {
            this.registerPersonService = registerPersonService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(RegisterPersonCommand command)
        {
            registerPersonService.RegisterPerson(command);
            return View();
        }

    }
}
