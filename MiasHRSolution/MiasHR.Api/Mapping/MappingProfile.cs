using AutoMapper;
using MiasHR.Api.Entities;
using MiasHR.Models.DTOs;

namespace MiasHR.Api.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<HrWebRequest, DayTimeOffRequestDTO>();
        }

    }
}
