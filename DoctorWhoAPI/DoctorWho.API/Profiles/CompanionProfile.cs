using AutoMapper;
using DoctorWhoDomain.Entities;

namespace DoctorWho.API.Profiles
{
    public class CompanionProfile : Profile
    {
        public CompanionProfile()
        {
            CreateMap<Companion, Models.CompanionDto>()
                .ReverseMap();
        }
    }
}
