using Library.Models;

namespace Library.Repositories.Interface
{
    public interface IPersonRepository
    {
        void CreatePerson(Person person);
        Person GetpersonById(int id);

        Person UpdatePerson(Person person);

        List<Person> GetAllPerson();

        void DeletePerson(int id);
    
    }
}
