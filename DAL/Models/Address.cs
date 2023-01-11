using DAL.Models.Base;


namespace DAL.Models
{
    public class Address : BaseEntity
    {
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }

        public ICollection<Event> Events { get; set; }
    }
}
