using Library.Models;
using Library.Repositories.Interface;
using Library.Services.Interface;

namespace Library.Services.Implementation
{
    public class TeachersService : ITeachersService
    {
        private readonly ITeacherRepository teacherRepository;

        public TeachersService(ITeacherRepository teacherRepository)
        {
            this.teacherRepository = teacherRepository;
        }
        public List<Teacher> GetAllTeachers()
        {
            return teacherRepository.GetAll();
        }

        public Teacher GetTeacher(int id)
        {
            return teacherRepository.GetTeacherById(id);
        }
    }
}
