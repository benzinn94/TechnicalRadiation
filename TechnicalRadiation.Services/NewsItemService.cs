using System.Collections.Generic;
using AutoMapper;
using TechnicalRadiation.Models.Dtos;
using TechnicalRadiation.Repositories;

namespace TechnicalRadiation.Services
{
    public class NewsItemService
    {
        private NewsItemRepository _newsItemRepository;
        public IEnumerable <NewsItemDto> GetAllNews(){

            return _newsItemRepository.GetAllNews();
        }

        public NewsItemService(IMapper mapper)
        {
            _newsItemRepository = new NewsItemRepository(mapper);
        }
    }
}