using Library.Models;

namespace Library.Repositories.Interface
{
    public interface ISportTypeRepository
    {
        void Create(SportType sportType);
        IList<SportType> GetAllSportTypes();
    }
}
