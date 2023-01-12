

using DAL.Data;
using DAL.Models;
using DAL.Repositories.GenericRepository;

namespace DAL.Repositories.EventRepository
{
    public class EventRepository : GenericRepository.GenericRepository<Event>, IEventRepository
    {
        public EventRepository(ProiectContext context) : base(context)
        {
        }
    }
}
