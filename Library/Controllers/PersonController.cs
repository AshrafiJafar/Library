using Library.Models.Command;
using Library.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers
{
    public class PersonController : Controller
    {
        private readonly IRegisterPersonService registerPersonService;
        private readonly IPeopleService peopleService;

        public PersonController(IRegisterPersonService registerPersonService, IPeopleService peopleService)
        {
            this.registerPersonService = registerPersonService;
            this.peopleService = peopleService;
        }
        public IActionResult Index()
        {
            var people = peopleService.GetAllPeople();
            return View(people);
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
