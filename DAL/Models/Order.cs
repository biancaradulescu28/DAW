using DAL.Models.Base;


namespace DAL.Models
{
    public class Order : BaseEntity
    {
        public int TotalPrice { get; set; }
        public ICollection<Ticket> Tickets { get; set; }

        public User User { get; set; }
    }
}

