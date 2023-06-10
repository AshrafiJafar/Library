using Library.Models.Command;
using Library.Services.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers
{
    public class TeacherController : Controller
    {
        private readonly ICommandTeacherService commandTeacherService;
        private readonly ITeachersService teachersService;

        public TeacherController(ICommandTeacherService commandTeacherService, ITeachersService teachersService)
        {
            this.commandTeacherService = commandTeacherService;
            this.teachersService = teachersService;
        }
        public IActionResult Index()
        {
            var teacher = teachersService.GetAllTeachers();
            return View(teacher);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return PartialView("_Create");
        }
        [HttpPost]
        public IActionResult Create(RegisterTeacherCommand command)
        {
            commandTeacherService.RegisterTeacher(command);
            var teachers = teachersService.GetAllTeachers();
            return PartialView("_TableBody", teachers);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var teacher = teachersService.GetTeacher(id);

            var command = new EditTeacherCommand()
            {
                Id = teacher.Id,
                Address = teacher.Address,
                BirthDate = teacher.BirthDate,
                FirstName = teacher.FirstName,
                Height = teacher.Height,
                LastName = teacher.LastName,
                Mobile = teacher.Mobile,
                NationalCode = teacher.NationalCode,
                PhoneNumber = teacher.PhoneNumber,
                Weight = teacher.Weight,
                NumberOfChilds = teacher.NumberOfChilds,
                Sports = teacher.Sports,
                Introduction = teacher.Introduction,
                SubjectId = teacher.SubjectId
            };
            return PartialView("_Edit ", command);
        }
        [HttpPost]
        public IActionResult Edit(EditTeacherCommand command)
        {
            commandTeacherService.EditTeacher(command);
            var teachers = teachersService.GetAllTeachers();
            return PartialView("_TableBody", teachers);
        }

        [HttpPost]
        public void Delete(int id)
        {
            commandTeacherService.DeleteTeacher(id);
        }

        [HttpGet]
        public IActionResult Details(int Id)
        {
            var teacher = teachersService.GetTeacher(Id);

            var command = new DatailsTeacherCommand()
            {
                Id = teacher.Id,
                Address = teacher.Address,
                BirthDate = teacher.BirthDate,
                FirstName = teacher.FirstName,
                Height = teacher.Height,
                LastName = teacher.LastName,
                Mobile = teacher.Mobile,
                NationalCode = teacher.NationalCode,
                PhoneNumber = teacher.PhoneNumber,
                Weight = teacher.Weight,
                NumberOfChilds = teacher.NumberOfChilds,
                Sports = teacher.Sports,
                Introduction = teacher.Introduction,
            };

            return PartialView("_Details", command);
        }

        [HttpPost]
        public IActionResult Details(DatailsTeacherCommand command)
        {
            commandTeacherService.DatailsTeacher(command);
            var teachers = teachersService.GetAllTeachers();
            return PartialView("_TableBody", teachers);
        }
        [HttpGet]
        public IActionResult TeachersTime()
        {
            return PartialView("_TeachersTime");
        }

    }
}
