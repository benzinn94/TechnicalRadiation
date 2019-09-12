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
    public class NewsItemRepository
    {
        private IMapper _mapper;

        public NewsItemRepository(IMapper mapper)
        {
            _mapper = mapper;
        }
        public IEnumerable<NewsItemDto> GetAllNews() {
            
            return _mapper.Map<IEnumerable<NewsItemDto>>(DataProvider.NewsItems.OrderByDescending(o => o.PublishDate));
        }

        public NewsItemDetailDto GetNewsItemById(int id)
        {
            return _mapper.Map<NewsItemDetailDto>(DataProvider.NewsItems.FirstOrDefault(n => n.Id == id));
        }

        public IEnumerable<NewsItemDto> GetNewsItemsByCategoryId(int id){
            
            var newsItemIds = DataProvider.NewsItemCategories.Where(x => x.CategoryId == id).ToList();
            var newsItems = new List<NewsItem>();

             foreach(var item in newsItemIds){
                newsItems.Add(DataProvider.NewsItems.FirstOrDefault(x => x.Id == item.NewsItemId));
            }

            return _mapper.Map<IEnumerable<NewsItemDto>>(newsItems);
        }

        public IEnumerable<NewsItemDto> GetNewsItemsByAuthorId(int id){
            var newsItemIds = DataProvider.NewsItemAuthors.Where(x => x.AuthorId == id).ToList();
            var newsItems = new List<NewsItem>();

             foreach(var item in newsItemIds){
                newsItems.Add(DataProvider.NewsItems.FirstOrDefault(x => x.Id == item.NewsItemId));
            }

            return _mapper.Map<IEnumerable<NewsItemDto>>(newsItems);
        }

        public NewsItemDetailDto CreateNewsItem(NewsItemInputModel model)
        {
            var nextId = DataProvider.NewsItems.OrderByDescending(n => n.Id).FirstOrDefault().Id + 1;
            var entity = _mapper.Map<NewsItem>(model);
            entity.Id = nextId;
            DataProvider.NewsItems.Add(entity);
            return _mapper.Map<NewsItemDetailDto>(entity);
        }

        public void UpdateNewsItemById(NewsItemInputModel model, int id)
        {
            var entity = DataProvider.NewsItems.FirstOrDefault(n => n.Id == id);
            if(entity == null){throw new KeyNotFoundException(); }

            entity.Title = model.Title;
            entity.ImgSource = model.ImgSource;
            entity.ShortDescription = model.ShortDescription;
            entity.LongDescription = model.LongDescription;
            entity.PublishDate = model.PublishDate;
            entity.ModifiedDate = DateTime.Now;
            
        }

        public void DeleteNewsItemById(int id)
        {
            var entity = DataProvider.NewsItems.FirstOrDefault(n => n.Id == id);
            if(entity == null){throw new KeyNotFoundException(); }

            DataProvider.NewsItems.Remove(entity);

        }
    }
}