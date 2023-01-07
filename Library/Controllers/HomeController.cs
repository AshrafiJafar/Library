
using Library.Models;
using Library.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISportTypeRepository sportTypeRepository;

        public HomeController(ISportTypeRepository sportTypeRepository)
        {
            this.sportTypeRepository = sportTypeRepository;
        }
        public IActionResult Index()
        {
            //var person = new Person()
            //{
            //    Address = "Tehran",
            //    Age = 30,
            //    Balance = 40_000,
            //    BirthDate = new DateTime(1987, 6, 21),
            //    FirstName = "Jafar",
            //    LastName = "Ashrafi",
            //    Height = 180,
            //    Weight = 68,
            //    Mobile = "+905508357911",
            //    NationalCode = "1347531598",
            //    PhoneNumber = "1234567890",
            //};
            //db.People.Add(person);

            var sportType = new SportType { Name = "Body building" };
            sportTypeRepository.Create(sportType);

            return View();
        }

    }
}