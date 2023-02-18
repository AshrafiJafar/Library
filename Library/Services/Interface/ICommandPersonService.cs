using Library.Models.Command;

namespace Library.Services.Interface
{
    public interface ICommandPersonService
    {
        void RegisterPerson(RegisterPersonCommand command);
        void EditPerson(EditPersonCommand command);
        void DeletePerson(int id);
        void IncreaseBalance(IncreaseBalance command);
    }
}
