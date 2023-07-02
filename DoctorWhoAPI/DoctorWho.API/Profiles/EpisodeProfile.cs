using AutoMapper;
using DoctorWhoDomain.Entities;

namespace DoctorWho.API.Profiles
{
    public class EpisodeProfile : Profile
    {
        protected EpisodeProfile()
        {
            CreateMap<Episode,Models.EpisodeDto>();
        }
    }
}
