using Library.Models.Command;

namespace Library.Services.Interface
{
    public interface ICommandTeacherService
    {
        int RegisterTeacher(RegisterTeacherCommand command);
        void EditTeacher(EditTeacherCommand Command);
        void DeleteTeacher(int id);
        void DatailsTeacher(DatailsTeacherCommand Command);
    }
}
