using System.Linq;
using AutoMapper;
using DatingApp.API.Dtos;
using DatingApp.API.Models;

namespace DatingApp.API.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserForListDto>()
            .ForMember(des => des.PhotoUrl, opt =>
                  opt.MapFrom(src => src.Photos.FirstOrDefault(p => p.IsMain).Url))
                  .ForMember(des => des.Age, opt =>
                  opt.MapFrom(src => src.DateOfBirth.CalculateAge()));
            CreateMap<User, UserForDetailedDto>().ForMember(des => des.PhotoUrl, opt =>
                  opt.MapFrom(src => src.Photos.FirstOrDefault(p => p.IsMain).Url))
                  .ForMember(des => des.Age, opt =>
                  opt.MapFrom(src => src.DateOfBirth.CalculateAge()));
            CreateMap<Photo, PhotoForDetailedDto>();
            CreateMap<UserForUpdateDto, User>();
        }
    }
}