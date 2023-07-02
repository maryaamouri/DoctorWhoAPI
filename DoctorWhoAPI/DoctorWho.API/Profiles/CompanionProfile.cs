using AutoMapper;
using DoctorWhoDomain.Entities;

namespace DoctorWho.API.Profiles
{
    public class CompanionProfile : Profile
    {
        protected CompanionProfile()
        {
            CreateMap<Companion, Models.CompanionDto>()
                .ReverseMap();
        }
    }
}
