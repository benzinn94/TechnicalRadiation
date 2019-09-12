using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using TechnicalRadiation.Models.Dtos;
using TechnicalRadiation.Models.Entities;
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
    }
}