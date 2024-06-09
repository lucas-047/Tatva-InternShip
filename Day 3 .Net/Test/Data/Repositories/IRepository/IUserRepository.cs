using Test.Models;

namespace Test.Data.Repositories.IRepository
{
    public interface IUserRepository 
    {
        List<User> GetAllUsersInMemory();
        List<User> GetAllUsersFromDatabase();
        User GetUserById(int id);
        Role GetRoleById(int id);
        void AddUser(User user);
        void AddRole(Role role);
        List<User> GetUsersOrderedByUsername();
        List<IGrouping<string, User>> GetUsersGroupedByRole();
        List<UserRoleDto> GetUsersWithRoles();
        User GetUserForAuth(string username,string password);
    }
}
