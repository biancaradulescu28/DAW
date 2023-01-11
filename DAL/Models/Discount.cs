using DAL.Models.Base;


namespace DAL.Models
{
    public class Discount : BaseEntity
    {
        public string DiscountCode { get; set; }
        public int DiscountProcent { get; set; }
        public ICollection<TicketDiscount> TicketDiscounts { get; set; }
    }
}
