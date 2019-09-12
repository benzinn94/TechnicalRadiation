using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using TechnicalRadiation.Models.Dtos;
using TechnicalRadiation.Models.Extensions;
using TechnicalRadiation.Repositories;

namespace TechnicalRadiation.Services
{
    public class AuthorService
    {
        private AuthorRepository _authorRepository;
        private NewsItemRepository _newsItemRepository;

        private CategoryRepository _categoryRepository;

        public AuthorService(IMapper mapper){
            _authorRepository = new AuthorRepository(mapper);
            _newsItemRepository = new NewsItemRepository(mapper);
            _categoryRepository = new CategoryRepository(mapper);
        }

        public IEnumerable <AuthorDto> GetAllAuthors(){
            var authors = _authorRepository.GetAllAuthors().ToList();

            authors.ForEach(a => {
                a.Links.AddReference("self", $"api/authors/{a.Id}");
                a.Links.AddReference("edit", $"api/authors/{a.Id}");
                a.Links.AddReference("delete", $"api/authors/{a.Id}");
                a.Links.AddReference("newsItems", $"api/authors/{a.Id}/newsItems");
                a.Links.AddListReference("newsItemsDetailed", _newsItemRepository.GetNewsItemsByAuthorId(a.Id).Select(n => new {href = $"api/{n.Id}"}));

            });
            return authors;
        }

        public AuthorDetailDto GetAuthorById(int id)
        {
            var author = _authorRepository.GetAuthorById(id);

            author.Links.AddReference("self", $"api/authors/{author.Id}");
            author.Links.AddReference("edit", $"api/authors/{author.Id}");
            author.Links.AddReference("delete", $"api/authors/{author.Id}");
            author.Links.AddReference("newsItems", $"api/authors/{author.Id}/newsItems");
            author.Links.AddListReference("newsItemsDetailed", _newsItemRepository.GetNewsItemsByAuthorId(author.Id).Select(n => new {href = $"api/{n.Id}"}));


            return author;
        }
    public IEnumerable<NewsItemDto> GetAuthorNewsItemsById(int id){
        var news = _newsItemRepository.GetNewsItemsByAuthorId(id).ToList();
        news.ForEach(n => {
                
            n.Links.AddReference("self", $"api/{n.Id}");
            n.Links.AddReference("edit", $"api/{n.Id}");
            n.Links.AddReference("delete", $"api/{n.Id}");
            n.Links.AddListReference("authors", _authorRepository.GetAuthorsByNewsItemId(n.Id).Select(a => new {href = $"/api/authors/{a.Id}"}));
            n.Links.AddListReference("categories", _categoryRepository.GetCategoriesByNewsItemId(n.Id).Select(c => new {href = $"/api/categories/{c.Id}"}));
            });
        
        return news;
    }
    }
}