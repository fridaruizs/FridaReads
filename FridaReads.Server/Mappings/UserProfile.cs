using AutoMapper;
using FridaReads.Server.Entities;
using FridaReads.Server.Models;

namespace FridaReads.Server.Mappings
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserModel>();
            CreateMap<UserModel, User>();
        }
    }
}
