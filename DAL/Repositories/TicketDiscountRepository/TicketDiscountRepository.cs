

using DAL.Data;
using DAL.Models;

namespace DAL.Repositories.TicketDiscountRepository
{
    public class TicketDiscountRepository : GenericRepository.GenericRepository<TicketDiscount>, ITicketDiscountRepository
    {
        public TicketDiscountRepository(ProiectContext context) : base(context)
        {
        }
    }
}
