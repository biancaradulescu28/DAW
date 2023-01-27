namespace DAL.Models.DTOs
{
    public class EventDTO
    {
        public string EventName { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public Address Address { get; set; }
    }
}
