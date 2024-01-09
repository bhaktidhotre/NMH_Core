using BOL.Model;

namespace DAL.Repository.Interface
{
    public interface ILoginRepository
    {
        Task<List<LoginResult>> LoginToken(string UserName , string Password,string ApplicationType);
    }
}
