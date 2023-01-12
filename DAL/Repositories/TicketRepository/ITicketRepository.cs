using DAL.Models;
using DAL.Repositories.GenericRepository;

namespace DAL.Repositories.TicketRepository
{
    public interface ITicketRepository : IGenericRepository<Ticket>
    {
    }
}
