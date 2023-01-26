using Library.Models;

namespace Library.Repositories.Interface
{
    public interface IPersonRepository
    {
        void CreatePerson(Person person);
        List<Person> GetAll();

        Person GetPersonById(int id);
        void Update(Person person);
        public void Delete(int id);
    }
}
