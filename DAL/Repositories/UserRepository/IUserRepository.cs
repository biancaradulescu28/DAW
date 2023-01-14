

using DAL.Models;
using DAL.Repositories.GenericRepository;

namespace DAL.Repositories.UserRepository
{
    public interface IUserRepository : IGenericRepository<User>
    {
        User FindByUsername(string username);
    }
}
