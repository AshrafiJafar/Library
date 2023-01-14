
using Library.Models;
using Library.Repositories.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISportTypeRepository sportTypeRepository;
        private readonly ApplicationDbContext db;

        public HomeController(ISportTypeRepository sportTypeRepository, ApplicationDbContext db)
        {
            this.sportTypeRepository = sportTypeRepository;
            this.db = db;
        }
        public IActionResult Index()
        {
            return View();
        }




    }
}