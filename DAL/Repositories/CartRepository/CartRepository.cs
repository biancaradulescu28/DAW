using DAL.Data;
using DAL.Models;

namespace DAL.Repositories.CartRepository
{
    public class CartRepository : GenericRepository.GenericRepository<Cart>, ICartRepository
    {
        public CartRepository(ProiectContext context) : base(context)
        {
        }
    }
}
