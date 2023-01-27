using DAL.Models.Base;
using System.Reflection;

namespace DAL.Models
{
    public class Event : BaseEntity
    {
        public string EventName { get; set; } = "";
        public DateTime Date { get; set; } 
        public int TicketsAvailable { get; set; } = 0;
        public Address Address { get; set; }
        public ICollection<Ticket> Tickets { get; set; }

    }
}
