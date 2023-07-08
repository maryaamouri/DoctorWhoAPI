using AutoMapper;
using DoctorWhoDomain.Entities;

namespace DoctorWho.API.Profiles
{
    public class AuthorProfile : Profile
    {
        public AuthorProfile() : base()
        {
            CreateMap<Models.AuthorDto, Author>()
                .ReverseMap();
        }
    }
}
