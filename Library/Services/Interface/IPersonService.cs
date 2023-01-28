using Library.Models;
using Library.Models.Command;

namespace Library.Services.Interface
{
    public interface IPersonService
    {
        Person GetPersonById(int id);
        List<Person> GetAllPerson();
        void RegisterPerson(RegisterPersonCommand command);

        Person UpdatePerson(UpdatePersonCommand command);

        void DeletePersonService(DeletePersonCommand command);

    }
}
