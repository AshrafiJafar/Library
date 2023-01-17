using Library.Models;

namespace Library.Repositories.Interface
{
    public interface IPersonRepository
    {
        void CreatePerson(Person person);
        List<Person> GetAll();
    }
}
