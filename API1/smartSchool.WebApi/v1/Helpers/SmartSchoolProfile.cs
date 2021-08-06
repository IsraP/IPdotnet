using AutoMapper;
using smartSchool.WebApi.v1.DTOs;
using smartSchool.WebApi.Models;
namespace smartSchool.WebApi.v1.Helpers
{
    public class SmartSchoolProfile : Profile
    {
        public SmartSchoolProfile()
        {
            CreateMap<Student, StudentDTO>().ForMember(
                dest => dest.Name,
                opt => opt.MapFrom(src => $"{src.Name} {src.SecondName}")
            ).ForMember(
                dest => dest.Age,
                opt => opt.MapFrom(src => src.BornAt.GetCurrentAge())
            );

            CreateMap<StudentDTO, Student>();
            CreateMap<Student, StudentRegisterDTO>().ReverseMap();
            CreateMap<StudentRegisterDTO, StudentDTO>();
        }
    }
}