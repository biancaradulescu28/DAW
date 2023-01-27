using DAL.Data;
using DAL.Models;

namespace Project.Helper.Seeders
{
    public class EventSeeder
    {
        public readonly ProiectContext _proiectContext;

        public EventSeeder(ProiectContext proiectContext)
        {
            _proiectContext= proiectContext;
        }

        public void SeedInitialEvents()
        {
            if(_proiectContext.Events.Any()) 
            {
                var event1 = new Event
                {
                    EventName = "Untold",
                    Date = new DateTime(2022, 7, 08),
                    TicketsAvailable = 300000
                };
                _proiectContext.Add(event1);

                _proiectContext.SaveChanges(); 

            }
        }
    }
}
