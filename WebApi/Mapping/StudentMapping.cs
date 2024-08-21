using AutoMapper;
using DtoLayer.StudentDto;
using EntityLayer.Entities;

namespace WebApi.Mapping
{
	public class StudentMapping : Profile
	{
        public StudentMapping()
        {
            CreateMap<Student, CreateStudentDto>().ReverseMap();
            CreateMap<Student, GetStudentDto>().ReverseMap();
            CreateMap<Student, ResultStudentDto>().ReverseMap();
            CreateMap<Student, UpdateStudentDto>().ReverseMap();
        }
    }
}
