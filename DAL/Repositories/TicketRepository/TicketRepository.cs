

using DAL.Data;
using DAL.Models;

namespace DAL.Repositories.TicketRepository
{
    internal class TicketRepository : GenericRepository.GenericRepository<Ticket>, ITicketRepository
    {
        public TicketRepository(ProiectContext context) : base(context)
        {
        }
    }
}
