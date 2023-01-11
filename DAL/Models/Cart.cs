

using DAL.Models.Base;

namespace DAL.Models
{
    public class Cart : BaseEntity
    {
        public int Quantity { get; set; }

        public User User { get; set; }
    }
}
