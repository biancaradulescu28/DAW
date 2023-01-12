

using DAL.Data;
using DAL.Models;

namespace DAL.Repositories.DiscountRepository
{
    public class DiscountRepository : GenericRepository.GenericRepository<Discount>, IDiscountRepository
    {
        public DiscountRepository(ProiectContext context) : base(context)
        {
        }
    }
}
