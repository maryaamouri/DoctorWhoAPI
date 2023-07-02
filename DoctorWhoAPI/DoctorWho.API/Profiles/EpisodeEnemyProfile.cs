using AutoMapper;
using DoctorWhoDomain.Entities;

namespace DoctorWho.API.Profiles
{
    public class EpisodeEnemyProfile : Profile
    {
        protected EpisodeEnemyProfile()
        {
            CreateMap<EpisodeEnemy,Models.EpisodeEnemyDto>();   
        }
    }
}
