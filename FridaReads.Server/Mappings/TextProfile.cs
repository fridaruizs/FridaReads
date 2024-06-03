using AutoMapper;
using FridaReads.Server.Entities;
using FridaReads.Server.Models;

namespace FridaReads.Server.Mappings
{
    public class TextProfile : Profile
    {
        public TextProfile()
        {
            CreateMap<Text, TextModel>();
            CreateMap<TextModel, Text>();
        }
    }
}
