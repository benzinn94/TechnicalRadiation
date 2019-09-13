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
    public class CategoryRepository
    {
        private IMapper _mapper;
        
        public CategoryRepository(IMapper mapper){
            _mapper = mapper;
        }

        public IEnumerable<CategoryDto> GetAllCategories(){

            return  _mapper.Map<IEnumerable<CategoryDto>>(DataProvider.Categories);
        }

        public IEnumerable<CategoryDto> GetCategoriesByNewsItemId(int id){

            var categoryIds = DataProvider.NewsItemCategories.Where(x => x.NewsItemId == id).ToList();
            var categories = new List<Category>();

            foreach(var item in categoryIds){
                categories.Add(DataProvider.Categories.FirstOrDefault(x => x.Id == item.CategoryId));
            }
            
            return _mapper.Map<IEnumerable<CategoryDto>>(categories);
        }

        public CategoryDetailDto GetCategoryById(int id)
        {
            return _mapper.Map<CategoryDetailDto>(DataProvider.Categories.FirstOrDefault(c => c.Id == id));
        }

        public CategoryDetailDto CreateCategory(CategoryInputModel model)
        {
            var nextId = DataProvider.Categories.OrderByDescending(c => c.Id).FirstOrDefault().Id + 1;
            var entity = _mapper.Map<Category>(model);
            entity.Id = nextId;
            DataProvider.Categories.Add(entity);
            return _mapper.Map<CategoryDetailDto>(entity);
        }
    }
}