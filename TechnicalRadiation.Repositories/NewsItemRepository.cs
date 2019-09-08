using System.Collections.Generic;
using AutoMapper;
using TechnicalRadiation.WebApi.Models;

namespace TechnicalRadiation.Repositories
{
    public class NewsItemRepository
    {
        private IMapper _mapper;

        public IEnumerable<NewsItemDto> GetAllNews() {
            
            return null;
            //return _mapper.Map()
        }
        
    }
}