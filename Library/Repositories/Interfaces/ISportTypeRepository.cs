using Library.Models;

namespace Library.Repositories.Interfaces
{
    public interface ISportTypeRepository
    {
        void Create(SportType sportType);
        IList<SportType> GetAllSportTypes();
    }
}
