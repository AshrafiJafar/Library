using Library.Models.Command;
using Library.Services.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers
{
    [Authorize(Roles = "SalonAdmin")]
    public class PersonController : Controller
    {
        private readonly ICommandPersonService commandPersonService;
        private readonly IPeopleService peopleService;
        private readonly IUserService userService;

        public PersonController(ICommandPersonService commandPersonService, IPeopleService peopleService, IUserService userService)
        {
            this.commandPersonService = commandPersonService;
            this.peopleService = peopleService;
            this.userService = userService;
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
        public async Task<IActionResult> Create(RegisterPersonCommand command)
        {
            commandPersonService.RegisterPerson(command);
            await userService.CreatePersonUser(command.NationalCode, command.NationalCode);
            var people = peopleService.GetAllPeople();
            return PartialView("_TableBody", people);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var person = peopleService.GetPerson(id);

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

            return PartialView("_Edit",command);
        }

        [HttpPost]
        public IActionResult Edit(EditPersonCommand command)
        {
            commandPersonService.EditPerson(command);
            var people = peopleService.GetAllPeople();
            return PartialView("_TableBody", people);
        }

        [HttpPost]
        public void Delete(int id)
        {
            commandPersonService.DeletePerson(id);
        }


        [HttpGet]
        public IActionResult Balance(int id)
        {
            var person = peopleService.GetPerson(id);

            var command = new IncreaseBalance()
            {
                Id = person.Id,
                FirstName = person.FirstName,
                LastName = person.LastName,
                Balance = person.Balance
            };

            return PartialView("_Balance", command);
        }

        [HttpPost]
        public IActionResult Balance(IncreaseBalance command)
        {
            commandPersonService.IncreaseBalance(command);
            var people = peopleService.GetAllPeople();
            return PartialView("_TableBody", people);
        }


    }
}
