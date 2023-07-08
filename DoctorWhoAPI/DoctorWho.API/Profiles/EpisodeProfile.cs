using AutoMapper;
using DoctorWho.API.Models;
using DoctorWhoDomain.Entities;

namespace DoctorWho.API.Profiles
{
    public class EpisodeProfile : Profile
    {
        public EpisodeProfile()
        {
            CreateMap<Episode, EpisodeDto>().ReverseMap();
        }
    }
}
