using AutoMapper;
using DoctorWhoDomain.Entities;

namespace DoctorWho.API.Profiles
{
    public class EpisodeEnemyProfile : Profile
    {
        public EpisodeEnemyProfile()
        {
            CreateMap<EpisodeEnemy,Models.EpisodeEnemyDto>();   
        }
    }
}
