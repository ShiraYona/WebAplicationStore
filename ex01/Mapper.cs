using AutoMapper;
using DTO;
using Entytess;
namespace project

{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<User, UserDto>().ReverseMap();
            //CreateMap<UserLosinDto, User >();

            CreateMap<Order, OrderDto>().ReverseMap();

            CreateMap<Category, CategoryDto>().ReverseMap();

        }


    }
}

