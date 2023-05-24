namespace Library.Services.Interface
{
    public interface IUserService
    {
        Task CreatePersonUser(string userName, string password);
    }
}
