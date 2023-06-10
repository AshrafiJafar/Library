using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Library.Models
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions option) : base(option) 
        {

        }

        public DbSet<Person> People { get; set; }
        public DbSet<ReservedTime> ReservedTimes { get; set; }
        public DbSet<Shelf> Shelves { get; set; }
        public DbSet<SportType> SportTypes { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<TeachersTime> TeachersTimes { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().Ignore(x => x.Age);
            modelBuilder.Entity<Person>().Property(x => x.BirthDate)
                .HasColumnType(System.Data.SqlDbType.Date.ToString());
            modelBuilder.Entity<Teacher>().Ignore(x => x.Age);
            modelBuilder.Entity<Teacher>().Property(x => x.BirthDate)
                .HasColumnType(System.Data.SqlDbType.Date.ToString());
            base.OnModelCreating(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }

    }


    
}
