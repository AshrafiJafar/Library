﻿using Library.Models;
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
        public int CreatePerson(Person person)
        {
            db.People.Add(person);
            db.SaveChanges();
            return person.Id;
        }

        public List<Person> GetAll()
        {
            return db.People.ToList();
        }

        public Person GetPersonById(int id)
        {
            return db.People.Single(x => x.Id == id);
        }

        
        public void Update(Person person)
        {
            db.Entry(person).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
        }

        public void Remove(int id)
        {
            var person = GetPersonById(id);
            db.People.Remove(person);
            db.SaveChanges();
        }
    }
}
