using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using TechnicalRadiation.Models.Dtos;
using TechnicalRadiation.Models.Extensions;
using TechnicalRadiation.Repositories;

namespace TechnicalRadiation.Services
{
    public class NewsItemService
    {
        private NewsItemRepository _newsItemRepository;
        private AuthorRepository _authorRepository;
        private CategoryRepository _categoryRepository;
        public IEnumerable <NewsItemDto> GetAllNews(){

            var news = _newsItemRepository.GetAllNews().ToList();
            news.ForEach(n => {
                
                n.Links.AddReference("self", $"api/{n.Id}");
                n.Links.AddReference("edit", $"api/{n.Id}");
                n.Links.AddReference("delete", $"api/{n.Id}");
                n.Links.AddListReference("authors", _authorRepository.GetAuthorsByNewsItemId(n.Id).Select(a => new {href = $"/api/authors/{a.Id}"}));
                n.Links.AddListReference("categories", _categoryRepository.GetCategoriesByNewsItemId(n.Id).Select(c => new {href = $"/api/categories/{c.Id}"}));
            });
            return news;
        }

        public NewsItemService(IMapper mapper)
        {
            _newsItemRepository = new NewsItemRepository(mapper);
            _authorRepository = new AuthorRepository(mapper);
            _categoryRepository = new CategoryRepository(mapper);
        }

        private void CreateLinksNewsItem(NewsItemDto newsItems)
        {
            var authors = _authorRepository.GetAllAuthors();
            var categories = _categoryRepository.GetAllCategories();


            
        }
    }
}