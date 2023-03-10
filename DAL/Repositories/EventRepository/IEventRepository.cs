using DAL.Models;
using DAL.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.EventRepository
{
    public interface IEventRepository : IGenericRepository<Event>
    {
        List<Event> GetAllWithInclude();
        //List<Event> GetAllWithJoin();
        Event GetByEventName(string eventName);
    }
   
}
