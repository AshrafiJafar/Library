using Library.Models.Command;

namespace Library.Services.Interface
{
    public interface ICommandPersonService
    {
        int RegisterPerson(RegisterPersonCommand command);
        void EditPerson(EditPersonCommand command);
        void DeletePerson(int id);
        void IncreaseBalance(IncreaseBalancePerson command);
    }
}
