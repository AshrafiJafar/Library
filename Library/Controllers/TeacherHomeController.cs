using Library.Services.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace Library.Controllers
{
    [Authorize(Roles = "Teacher")]
    public class TeacherHomeController : Controller
    {
        private readonly ITeachersService teachersService;

        public TeacherHomeController(ITeachersService teachersService)
        {
            this.teachersService = teachersService;
        }
        public IActionResult Index(int id)
        {
            var teacher = teachersService.GetTeacher(id);
            return View(teacher);
        }
    }
}
