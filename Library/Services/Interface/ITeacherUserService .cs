namespace Library.Services.Interface
{
    public interface ITeacherUserService
    {
        Task CreateTeacherUser(string userName, string password,string id);
    }
}
