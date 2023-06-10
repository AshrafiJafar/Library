using Library.Models;
using Library.Repositories.Interface;
using System;

namespace Library.Repositories.Implementation
{
    public class TeacherRepository : ITeacherRepository
    {
        private readonly ApplicationDbContext db;

        public TeacherRepository(ApplicationDbContext db)
        {
            this.db = db;
        }
        public int CreateTeacher(Teacher teacher)
        {
            db.Teachers.Add(teacher);
            db.SaveChanges();
            return teacher.Id;
        }
        public List<Teacher> GetAll()
        {
            return db.Teachers.ToList();
        }
        public Teacher GetTeacherById(int id)
        {
            return db.Teachers.Single(x => x.Id == id);
        }
        public void Update(Teacher teacher)
        {
            db.Entry(teacher).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
        }
        public void Remove(int id)
        {
            var teacher = GetTeacherById(id);
            db.Teachers.Remove(teacher);
            db.SaveChanges();
        }

        public void CreateTeachersTime(DateTime time)
        {
            throw new NotImplementedException();
        }
    }
}

