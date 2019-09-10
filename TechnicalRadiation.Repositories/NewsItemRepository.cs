using System.Collections.Generic;
using AutoMapper;
using RentThePlace.Repositories.Data;
using TechnicalRadiation.Models.Dtos;

namespace TechnicalRadiation.Repositories
{
    public class NewsItemRepository
    {
        private IMapper _mapper;

        public NewsItemRepository(IMapper mapper)
        {
            _mapper = mapper;
        }
        public IEnumerable<NewsItemDto> GetAllNews() {
            

            
            return _mapper.Map<IEnumerable<NewsItemDto>>(DataProvider.NewsItems);
        }
        
    }
}