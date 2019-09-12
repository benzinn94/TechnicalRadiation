using AutoMapper;
using TechnicalRadiation.Models.Dtos;
using TechnicalRadiation.Models.Entities;
using TechnicalRadiation.Models.InputModels;
using TechnicalRadiation.Services;

namespace TechnicalRadiation.WebApi.Mappings
{
    
    public class MappingProfile : Profile
    {
            public MappingProfile(){
            
            CreateMap<NewsItem, NewsItemDto>();
            CreateMap<NewsItemInputModel, NewsItem>();
            CreateMap<NewsItem, NewsItemDetailDto>();
            CreateMap<Author, AuthorDto>();
            CreateMap<AuthorInputModel, Author>();
            CreateMap<Author, AuthorDetailDto>();
            CreateMap<Category, CategoryDto>();
            CreateMap<CategoryInputModel, Category>();
            CreateMap<Category, CategoryDetailDto>();
            
        }
    }
}