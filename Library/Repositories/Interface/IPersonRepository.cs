using Library.Models;

namespace Library.Repositories.Interface
{
    public interface IPersonRepository
    {
        int CreatePerson(Person person);
        List<Person> GetAll();

        Person GetPersonById(int id);
        void Remove(int id);
        void Update(Person person);
    }
}
