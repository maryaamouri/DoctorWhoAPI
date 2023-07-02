using AutoMapper;
using DoctorWhoDomain.Entities;

namespace DoctorWho.API.Profiles
{
    public class EnemyProfile : Profile
    {
        public EnemyProfile() {
            CreateMap<Enemy, Models.EnemyDto>().ReverseMap();
        }
    }
}
