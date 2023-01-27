using DAL.Models.Base;


namespace DAL.Models
{
    public class Ticket : BaseEntity
    {
        public string? TicketType { get; set; } = "";
        public int? SeatNumber { get; set; } = 0;
        public int Price { get; set; } = 0;

        public Order? Order { get; set; }
        public Event Event { get; set; }
        public ICollection<TicketDiscount> TicketDiscounts { get; set; }
    }
}
