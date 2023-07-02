using AutoMapper;
using DoctorWhoDomain.Entities;

namespace DoctorWho.API.Profiles
{
    public class EpisodeProfile : Profile
    {
        public EpisodeProfile()
        {
            CreateMap<Episode,Models.EpisodeDto>();
        }
    }
}
