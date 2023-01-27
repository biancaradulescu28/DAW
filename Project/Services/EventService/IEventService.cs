using DAL.Models.DTOs;

namespace Project.Services.EventService
{
    public interface IEventService
    {
        EventDTO GetDataMappedByEventName(string eventName);
    }
}
