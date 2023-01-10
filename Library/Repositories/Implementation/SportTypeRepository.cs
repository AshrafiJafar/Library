using Library.Models;
using Library.Repositories.Interface;

namespace Library.Repositories.Implementation
{
    public class SportTypeRepository : ISportTypeRepository
    {
        private readonly ApplicationDbContext db;

        public SportTypeRepository(ApplicationDbContext db)
        {
            this.db = db;
        }
        public void Create(SportType sportType)
        {
            db.SportTypes.Add(sportType);
            db.SaveChanges();
        }

        public IList<SportType> GetAllSportTypes()
        {
            return db.SportTypes.ToList();
        }
    }

}
