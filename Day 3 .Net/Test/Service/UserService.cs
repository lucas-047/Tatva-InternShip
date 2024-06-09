using Test.Data.Repositories.IRepository;
using Test.Models;
using Test.Service.IService;
namespace Test.Service
{
    public class UserService : IUserServices
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository) {
            _userRepository = userRepository;
        }

        private readonly List<UserNew> _users = new()
        {
            new UserNew {Username = "admin", Password = "123", Role = "Admin"},
            new UserNew {Username = "user", Password = "1234", Role = "User"}
            
        };

        public User Auth(string username,string password) { 
            return _userRepository.GetUserForAuth(username, password);
        }
        public UserNew Authenticate(string username, string password)
        {
            return _users.SingleOrDefault(x => x.Username == username && x.Password == password);   
        }

        public IEnumerable<UserNew> GetAll()
        {
            return _users;
        }
    }
}

