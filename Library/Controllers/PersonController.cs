using Library.Models.Command;
using Library.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers
{
    public class PersonController : Controller
    {
        private readonly ICommandPersonService commandPersonService;
        private readonly IPeopleService peopleService;

        public PersonController(ICommandPersonService commandPersonService, IPeopleService peopleService)
        {
            this.commandPersonService = commandPersonService;
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
            return PartialView("_Create");
        }

        [HttpPost]
        public IActionResult Create(RegisterPersonCommand command)
        {
            commandPersonService.RegisterPerson(command);
            var people = peopleService.GetAllPeople();
            return PartialView("_tableBody", people);
        }

        [HttpGet]
        public IActionResult Edit(int personId)
        {
            var person = peopleService.GetPerson(personId);

            var command = new EditPersonCommand()
            {
                Id = person.Id,
                Address = person.Address,
                BirthDate = person.BirthDate,
                FirstName = person.FirstName,
                Height = person.Height,
                LastName = person.LastName,
                Mobile = person.Mobile,
                NationalCode = person.NationalCode,
                PhoneNumber = person.PhoneNumber,
                Weight = person.Weight
            };

            return View(command);
        }

        [HttpPost]
        public IActionResult Edit(EditPersonCommand command)
        {
            commandPersonService.EditPerson(command);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public void Delete(int id)
        {
            throw new Exception("Error Happened in Delete");
            commandPersonService.DeletePerson(id);
        }

    }
}
