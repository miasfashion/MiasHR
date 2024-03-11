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
            CreateMap<HrEmployeeApprover, ApproverDTO>()
                .ForMember(dest => dest.approver1st, opt => opt.MapFrom(src => src.Approver1st))
                .ForMember(dest => dest.approver2nd, opt => opt.MapFrom(src => src.Approver2nd))
                .ForMember(dest => dest.otherManager, opt => opt.MapFrom(src => src.OtherManager))
                .ForMember(dest => dest.PTONoticeMang, opt => opt.MapFrom(src => src.PtoNoticeManager));

        }

    }
}
