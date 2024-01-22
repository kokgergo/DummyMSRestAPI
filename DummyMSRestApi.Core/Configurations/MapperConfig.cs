using AutoMapper;
using DummyMSRestApi.Data;
using DummyMSRestApi.Core.Models.TimeData;
using DummyMSRestApi.Core.Models.TypeData;
using DummyMSRestApi.Core.Models.User;

namespace DummyMSRestApi.Core.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig() 
        {
            CreateMap<UserType, CreateUserDto>().ReverseMap();
            CreateMap<UserType, UserDto>().ReverseMap();
            CreateMap<UserType, UsersDto>().ReverseMap();
            CreateMap<UserType, UpdateUserDto>().ReverseMap();
            CreateMap<UserType, ApiUserDto>().ReverseMap();

            CreateMap<LineData<TimeFields>, TimeFiledsDto>().ReverseMap();
            CreateMap<LineData<TimeFields>, TimeFieldDto>().ReverseMap();
            CreateMap<LineData<TimeFields>, CreateTimeDto>().ReverseMap();
            CreateMap<LineData<TimeFields>, UpdateTimeDto>().ReverseMap();

            CreateMap<LineData<TypeFields>, TypeFieldsDto>().ReverseMap();
            CreateMap<LineData<TypeFields>, TypeFieldDto>().ReverseMap();
            CreateMap<LineData<TypeFields>, CreateTypeDto>().ReverseMap();
            CreateMap<LineData<TypeFields>, UpdateTypeDto>().ReverseMap();

      
        }
    }
}
