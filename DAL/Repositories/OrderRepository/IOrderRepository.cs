

using DAL.Models;
using DAL.Repositories.GenericRepository;

namespace DAL.Repositories.OrderRepository
{
    public interface IOrderRepository : IGenericRepository<Order>
    {
    }
}
