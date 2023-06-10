using Library.Models;

namespace Library.Services.Interface
{
    public interface ITeachersService
    {
        List<Teacher> GetAllTeachers();
        Teacher GetTeacher(int id);
    }
}
