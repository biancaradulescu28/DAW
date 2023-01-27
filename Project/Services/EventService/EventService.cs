using AutoMapper;
using DAL.Models;
using DAL.Models.DTOs;
using DAL.Repositories.EventRepository;

namespace Project.Services.EventService
{
    public class EventService : IEventService
    {
        public IEventRepository _eventRepository;
        private readonly IMapper _mapper;

        public EventService(IEventRepository eventRepository, IMapper mapper)
        {
            _eventRepository = eventRepository;
            _mapper = mapper;
        }

        public EventDTO GetDataMappedByEventName(string eventName)
        {
            Event _event = _eventRepository.GetByEventName(eventName);
            //EventDTO result = new EventDTO
            //{
            //    EventName = _event.EventName,
            //    Date = _event.Date,
            //    Address = _event.Address
            //};
            EventDTO result = _mapper.Map<EventDTO>(_event);
            return result;
            
        }

    }
}
