using Library.Models.Command;

namespace Library.Services.Interface
{
    public interface IRegisterPersonService
    {
        void RegisterPerson(RegisterPersonCommand command);
    }
}
