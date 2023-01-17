using Library.Models;
using Library.Repositories.Interface;
using Library.Services.Interface;

namespace Library.Services.Implementation
{
    public class PeopleService : IPeopleService
    {
        private readonly IPersonRepository personRepository;

        public PeopleService(IPersonRepository personRepository)
        {
            this.personRepository = personRepository;
        }
        public List<Person> GetAllPeople()
        {
            return personRepository.GetAll();
        }
    }
}
