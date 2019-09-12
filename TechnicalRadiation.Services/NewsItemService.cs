using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using TechnicalRadiation.Models.Dtos;
using TechnicalRadiation.Models.Extensions;
using TechnicalRadiation.Models.InputModels;
using TechnicalRadiation.Repositories;

namespace TechnicalRadiation.Services
{
    public class NewsItemService
    {
        private NewsItemRepository _newsItemRepository;
        private AuthorRepository _authorRepository;
        private CategoryRepository _categoryRepository;

        public NewsItemService(IMapper mapper)
        {
            _newsItemRepository = new NewsItemRepository(mapper);
            _authorRepository = new AuthorRepository(mapper);
            _categoryRepository = new CategoryRepository(mapper);
        }
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

        public NewsItemDetailDto CreateNewsItem(NewsItemInputModel model)
        {
            return _newsItemRepository.CreateNewsItem(model);
        }

        public NewsItemDetailDto GetNewsItemById(int id){
            
            var newsItem =  _newsItemRepository.GetNewsItemById(id);
            
            newsItem.Links.AddReference("self", $"api/{newsItem.Id}");
            newsItem.Links.AddReference("edit", $"api/{newsItem.Id}");
            newsItem.Links.AddReference("delete", $"api/{newsItem.Id}");
            newsItem.Links.AddListReference("authors", _authorRepository.GetAuthorsByNewsItemId(newsItem.Id).Select(a => new {href = $"/api/authors/{a.Id}"}));
            newsItem.Links.AddListReference("categories", _categoryRepository.GetCategoriesByNewsItemId(newsItem.Id).Select(c => new {href = $"/api/categories/{c.Id}"}));
            
            return newsItem;
        }

        public void DeleteNewsItemById(int id)
        {
            _newsItemRepository.DeleteNewsItemById(id);
        }

        public void UpdateNewsItemById(NewsItemInputModel model, int id)
        {
            _newsItemRepository.UpdateNewsItemById(model, id);
        }
    }
}