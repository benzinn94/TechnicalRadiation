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
    public class CategoryService
    {
        private CategoryRepository _categoryRepository;
        private NewsItemRepository _newsItemRepository;

        public CategoryService(IMapper mapper)
        {
            _categoryRepository = new CategoryRepository(mapper);
            _newsItemRepository = new NewsItemRepository(mapper);
        }

         public IEnumerable <CategoryDto> GetAllCategories(){

            var categories = _categoryRepository.GetAllCategories().ToList();
            categories.ForEach(c => {
                
                c.Links.AddReference("self", $"api/categories/{c.Id}");
                c.Links.AddReference("edit", $"api/categories/{c.Id}");
                c.Links.AddReference("delete", $"api/categories/{c.Id}");
            });
            return categories;
        }

        public CategoryDetailDto GetCategoryById(int id)
        {
            var category =  _categoryRepository.GetCategoryById(id);
            category.NumberOfNewsItems = _newsItemRepository.GetNewsItemsByCategoryId(id).Count();
            category.Links.AddReference("self", $"api/categories/{category.Id}");
            category.Links.AddReference("edit", $"api/categories/{category.Id}");
            category.Links.AddReference("delete", $"api/categories/{category.Id}");
           
            return category;
        }

        public CategoryDetailDto CreateCategory(CategoryInputModel model)
        {
            return _categoryRepository.CreateCategory(model);
        }
    }
}