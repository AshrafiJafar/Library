namespace Library.Services.Interface
{
    public interface IPersonUserService
    {
        Task CreatePersonUser(string userName, string password,string id);
    }
}
