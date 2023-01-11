

namespace DAL.Models
{
    public class TicketDiscount
    {
        public Guid TicketId { get; set; }
        public Ticket Ticket { get; set; }

        public Guid DiscountId { get; set; }
        public Discount Discount { get; set; }

    }
}
