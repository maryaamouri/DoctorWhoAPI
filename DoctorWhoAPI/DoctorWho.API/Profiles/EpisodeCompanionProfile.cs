using AutoMapper;
using DoctorWhoDomain.Entities;

namespace DoctorWho.API.Profiles
{
    public class EpisodeCompanionProfile : Profile
    {
        public EpisodeCompanionProfile()
        {
            CreateMap<EpisodeCompanion,Models.EpisodeCompanionDto>();
        }
    }
}
