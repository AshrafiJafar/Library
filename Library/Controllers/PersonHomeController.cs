using Library.Attributes;
using Library.Services.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers
{
    [Authorize(Roles = "Person")]
    public class PersonHomeController : Controller
    {
        private readonly IPeopleService peopleService;

        public PersonHomeController(IPeopleService peopleService)
        {
            this.peopleService = peopleService;
        }

        [AuthorizeAccess]
        public IActionResult Index(int id)
        {
            var person = peopleService.GetPerson(id);
            return View(person);
        }

    }
}
