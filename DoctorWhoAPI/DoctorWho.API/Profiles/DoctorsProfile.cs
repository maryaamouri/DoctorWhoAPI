using AutoMapper;
using DoctorWhoDomain.Entities;

namespace DoctorWho.API.Profiles
{
    public class DoctorsProfile:Profile
    {
        public DoctorsProfile()
        {
            CreateMap<Models.DoctorDto, Doctor>()
                .ReverseMap();
        }
    }
}
