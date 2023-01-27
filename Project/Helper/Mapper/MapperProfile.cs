using AutoMapper;
using DAL.Models;
using DAL.Models.DTOs;

namespace Project.Helper.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile() 
        {
            CreateMap<Event, EventDTO>().ReverseMap();//mappeaza val cu nume identic
        }
    }
}
