using AutoMapper;
using FridaReads.Server.Entities;
using FridaReads.Server.Models;

namespace FridaReads.Server
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserModel>().ReverseMap();
            CreateMap<Text, TextModel>().ReverseMap();
        }
    }
}
