using Test.Models;

namespace Test.Service.IService
{
    public interface IUserServices
    {
        UserNew Authenticate(string username, string password);
        User Auth(string username, string password);
        IEnumerable<UserNew> GetAll();
    }
}
