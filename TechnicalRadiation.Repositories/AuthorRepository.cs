using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using TechnicalRadiation.Models.Dtos;
using TechnicalRadiation.Models.Entities;
using TechnicalRadiation.Models.InputModels;
using TechnicalRadiation.Repositories.Data.DataProvider;

namespace TechnicalRadiation.Repositories
{
    public class AuthorRepository
    {
        private IMapper _mapper;
        public AuthorRepository(IMapper mapper)
        {
            _mapper = mapper;
        }
        public IEnumerable<AuthorDto> GetAllAuthors(){
            return _mapper.Map<IEnumerable<AuthorDto>>(DataProvider.Authors);
        }

        public IEnumerable<AuthorDto> GetAuthorsByNewsItemId(int id){

            var authorIds = DataProvider.NewsItemAuthors.Where(x => x.NewsItemId == id).ToList();
            var authors = new List<Author>();

            foreach(var item in authorIds){
                authors.Add(DataProvider.Authors.FirstOrDefault(x => x.Id == item.AuthorId));
            }
            
            return _mapper.Map<IEnumerable<AuthorDto>>(authors);
        }

        public AuthorDetailDto GetAuthorById(int id)
        {
            return _mapper.Map<AuthorDetailDto>(DataProvider.Authors.FirstOrDefault(c => c.Id == id));
        }

        public AuthorDetailDto CreateAuthor(AuthorInputModel model)
        {
            var nextId = DataProvider.Authors.OrderByDescending(a => a.Id).FirstOrDefault().Id + 1;
            var entity = _mapper.Map<Author>(model);
            entity.Id = nextId;
            DataProvider.Authors.Add(entity);

            return _mapper.Map<AuthorDetailDto>(entity);
        }

        public void UpdateAuthorById(AuthorInputModel model, int id)
        {
            var entity = DataProvider.Authors.FirstOrDefault(a => a.Id == id);
            if(entity == null){throw new KeyNotFoundException(); }

            entity.Name = model.Name;
            entity.ProfileImgSource = model.ProfileImgSource;
            entity.Bio = model.Bio;
            entity.ModifiedDate = DateTime.Now;
        }

        public void DeleteAuthorById(int id)
        {
            var entity = DataProvider.Authors.FirstOrDefault(a => a.Id == id);
            if(entity == null){throw new KeyNotFoundException(); }

            DataProvider.Authors.Remove(entity);
        }

        public void CreateNewsItemCategoryRelation(int authorId, int newsItemId)
        {
            var author = DataProvider.Authors.FirstOrDefault(a => a.Id == authorId);
            var newsItem = DataProvider.NewsItems.FirstOrDefault(n => n.Id == newsItemId);

            if(author == null || newsItem == null){throw new KeyNotFoundException() ;}
            var relation = new NewsItemAuthors();
            relation.AuthorId = authorId;
            relation.NewsItemId = newsItemId;
            DataProvider.NewsItemAuthors.Add(relation);
        }
    }
}