using Library.Models.Command;
using Library.Services.Implementation;
using Library.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers
{
    //[Route("/[controller]")]
    public class PersonController : Controller
    {
        private readonly IPersonService _personService;
      
        public PersonController(IPersonService  personService)
        {
            _personService = personService;
        }

        [HttpGet]

        public IActionResult Index()
        {
            var pepole = _personService.GetAllPerson();
            return View(pepole);
        }

        [HttpGet]
        [Route("Create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route("Create")]
        public IActionResult Create(RegisterPersonCommand command)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            _personService.RegisterPerson(command);

            return RedirectToAction("Index", "Person");
        }


        [HttpGet]
        [Route("[action]/{id}")]
        public IActionResult UpdatePerson(int id)
        {
            var person = _personService.GetPersonById(id);
            if (person == null) return NotFound(Json("person not founnd"));
            var command = new UpdatePersonCommand
            {
                FirstName = person.FirstName,
                LastName = person.LastName,
               
                NationalCode = person.NationalCode,
                BirthDate = person.BirthDate,
                PhoneNumber = person.PhoneNumber,
                Mobile = person.Mobile,
                Weight = person.Weight,
                Height = person.Height,
                Address = person.Address,
              
            };

            return View("Update",command);

        }



        [HttpPost]
        [Route("UpdatePerson/{id}")]
        public  async Task <IActionResult> UpdatePerson(UpdatePersonCommand updatePersonCommand)
        {
            var result = _personService.UpdatePerson(updatePersonCommand);
            return RedirectToAction("Index","Person");
        }

        [HttpGet]
        [Route("DeletePerson/{id}")]

        public async Task<IActionResult> DeletePerson(int id)
        {
            var person = _personService.GetPersonById(id);
            if(person == null)
            {
                return NotFound("The person was not found!");
            }

            var deleteCommand = new DeletePersonCommand()
            {
                PersonId = person.Id,
                FirstName = person.FirstName,
                LastName = person.LastName
            };
            return View("Delete",deleteCommand);
        }

        [HttpPost]
        [Route("DeletePerson/{id?}")]

        public IActionResult DeletePerson(DeletePersonCommand deletePersonCommand)
        {
            _personService.DeletePersonService(deletePersonCommand);
            return RedirectToAction("Index");
        }
    }
}
