using Library.Models;
using Library.Repositories.Interface;

namespace Library.Repositories.Implementation
{
    public class PersonRepository : IPersonRepository
    {
        private readonly ApplicationDbContext db;

        public PersonRepository(ApplicationDbContext db)
        {
            this.db = db;
        }
        public void CreatePerson(Person person)
        {
            db.People.Add(person);
            db.SaveChanges();
        }
    }
}
