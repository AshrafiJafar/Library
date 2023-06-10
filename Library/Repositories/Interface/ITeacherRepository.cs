using Library.Models;

namespace Library.Repositories.Interface
{
    public interface ITeacherRepository
    {
        int CreateTeacher(Teacher teacher);
        List<Teacher> GetAll();
        Teacher GetTeacherById(int id);
        void Remove(int id);
        void Update(Teacher teacher);
        void CreateTeachersTime(DateTime time);
    }
}
