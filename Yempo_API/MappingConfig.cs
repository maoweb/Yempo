using AutoMapper;
using Yempo_API.Models;
using Yempo_API.Models.Dto;

namespace Yempo_API
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<Person, PersonDTO>().ReverseMap();
        }
    }
}
