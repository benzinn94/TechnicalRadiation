using AutoMapper;
using TechnicalRadiation.Models.Dtos;
using TechnicalRadiation.Models.Entities;
using TechnicalRadiation.Models.InputModels;

namespace TechnicalRadiation.WebApi.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile(){
            
            CreateMap<NewsItem, NewsItemDto>();
            CreateMap<NewsItemInputModel, NewsItem>();
        }
    }
}