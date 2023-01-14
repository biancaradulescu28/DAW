using DAL.Data;
using DAL.Models;

namespace DAL.Repositories.OrderRepository
{
    public class OrderRepository : GenericRepository.GenericRepository<Order>, IOrderRepository
    {
        public OrderRepository(ProiectContext context) : base(context)
        {
        }
    }
}
