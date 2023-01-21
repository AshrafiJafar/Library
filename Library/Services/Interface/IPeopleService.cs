using Library.Models;

namespace Library.Services.Interface
{
    public interface IPeopleService
    {
        List<Person> GetAllPeople();
        Person GetPerson(int id);
    }
}
