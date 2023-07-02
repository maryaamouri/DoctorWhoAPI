using AutoMapper;
using DoctorWhoDomain.Entities;

namespace DoctorWho.API.Profiles
{
    public class AuthorProfile : Profile
    {
        protected internal AuthorProfile() : base()
        {
            CreateMap<Models.AuthorDto, Author>()
                .ReverseMap();
        }
    }
}
