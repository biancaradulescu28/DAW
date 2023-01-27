

using DAL.Data;
using DAL.Models;
using DAL.Repositories.GenericRepository;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories.EventRepository
{
    public class EventRepository : GenericRepository<Event>, IEventRepository
    {
        public EventRepository(ProiectContext context) : base(context)
        {
        }

        public List<Event> GetAllWithInclude()
        {
            return _table.Include(x => x.Address).Include(x => x.Tickets).ToList();
        }

        //public List<Event> GetAllWithJoin()
        //{
        //    var result = _table.Join(_context.Addresses, e => e.Address, a => a.Id, (e, a)
        //        => new {e,a}).Select(obj => obj.e);
        //    return result.ToList();
        //}

        public Event GetByEventName(string eventName)
        {
            return _table.FirstOrDefault(x => x.EventName.ToLower().Equals(eventName.ToLower()));
        }
    }
}
