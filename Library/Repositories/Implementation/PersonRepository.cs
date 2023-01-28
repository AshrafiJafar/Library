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

        public void DeletePerson(int id)
        {
            var deletePeson = GetpersonById(id);
            db.Entry(deletePeson).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            db.SaveChanges();
        }

        public List<Person> GetAllPerson()
        {
           return db.People.ToList();
        }

        public Person GetpersonById(int id)
        {
           return db.People.Single(x => x.Id == id);
        }

        public Person UpdatePerson(Person person)
        {
            db.Entry(person).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            return person;
        }
    }
}
