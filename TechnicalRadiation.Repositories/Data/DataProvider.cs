using System;
using System.Collections.Generic;
using TechnicalRadiation.Models.Entities;

namespace RentThePlace.Repositories.Data
{
    public static class DataProvider
    {
        private static readonly string _adminName = "TechnicalRadiationAdmin";

        public static List<NewsItem> NewsItems = new List<NewsItem>
        {
            new NewsItem
            {
                Id = 1,
                Title = "Amber Rudd quits cabinet blaming Brexit inaction",
                ImgSource = "https://ichef.bbci.co.uk/news/624/cpsprodpb/043D/production/_108658010_ruddjavidreuters.jpg",
                ShortDescription = "Up to 90% of government effort is on no-deal, with no evidence of any formal negotiations to get an EU deal, she says.",
                LongDescription = "Amber Rudd has quit Boris Johnson\'s cabinet, with an outspoken attack on the government\'s approach to Brexit. The ex-work and pensions secretary said the government was having no \"formal negotiations\" with the EU about a new deal, only \"conversations\".",
                PublishedDate = DateTime.Now,
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new NewsItem
            {
               Id = 2,
                Title = "",
                ImgSource = "",
                ShortDescription = "",
                LongDescription = "",
                PublishedDate = DateTime.Now,
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new NewsItem
            {
                Id = 3,
                Title = "",
                ImgSource = "",
                ShortDescription = "",
                LongDescription = "",
                PublishedDate = DateTime.Now,
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new NewsItem
            {
                Id = 4,
                Title = "",
                ImgSource = "",
                ShortDescription = "",
                LongDescription = "",
                PublishedDate = DateTime.Now,
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new NewsItem
            {
                Id = 5,
                Title = "",
                ImgSource = "",
                ShortDescription = "",
                LongDescription = "",
                PublishedDate = DateTime.Now,
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new NewsItem
            {
                Id = 6,
                Title = "",
                ImgSource = "",
                ShortDescription = "",
                LongDescription = "",
                PublishedDate = DateTime.Now,
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new NewsItem
            {
                Id = 7,
                Title = "",
                ImgSource = "",
                ShortDescription = "",
                LongDescription = "",
                PublishedDate = DateTime.Now,
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new NewsItem
            {
                Id = 8,
                Title = "",
                ImgSource = "",
                ShortDescription = "",
                LongDescription = "",
                PublishedDate = DateTime.Now,
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            }
        };

        
        public static List<Author> Authors = new List<Author> 
        {
            new Author 
            {
                Id = 1,
                Name = "Harold Humptingdon",
                ProfileImgSource = "https://i.imgur.com/p6UZVJx.jpg",
                Bio = "I like to hide the pain. Most of the time. And I write news articles.",
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },

            new Author 
            {
                Id = 2,
                Name = "",
                ProfileImgSource = "",
                Bio = "",
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },

            new Author 
            {
                Id = 3,
                Name = "Joe Rogan",
                ProfileImgSource = "",
                Bio = "",
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },

            new Author 
            {
                Id = 4,
                Name = "Joe Rogan",
                ProfileImgSource = "",
                Bio = "",
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
             
            new Author 
            {
                Id = 5,
                Name = "Joe Rogan",
                ProfileImgSource = "",
                Bio = "",
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },

            new Author 
            {
                Id = 6,
                Name = "Joe Rogan",
                ProfileImgSource = "",
                Bio = "",
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },

            new Author 
            {
                Id = 7,
                Name = "Joe Rogan",
                ProfileImgSource = "",
                Bio = "",
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },

            new Author 
            {
                Id = 8,
                Name = "Joe Rogan",
                ProfileImgSource = "",
                Bio = "",
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            }
        };

         public static List<Category> Categories = new List<Category>
         {
            new Category
            {
                Id = 1,
                Name = "Politics",
                Slug = "",
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },

            new Category
            {
                Id = 2,
                Name = "Technology",
                Slug = "",
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },

            new Category
            {
                Id = 3,
                Name = "Breaking News",
                Slug = "",
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },

            new Category
            {
                Id = 4,
                Name = "Environmental",
                Slug = "",
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },

            new Category
            {
                Id = 5,
                Name = "Sports",
                Slug = "",
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },

            new Category
            {
                Id = 6,
                Name = "Weather",
                Slug = "",
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            }
         };

        public static List<NewsItemAuthors> NewsItemAuthors = new List<NewsItemAuthors>
        {
            new NewsItemAuthors
            {
                AuthorId = 1,
                NewsItemId = 1
            }
        };

         public static List<NewsItemCategories> newsItemCategories = new List<NewsItemCategories>
        {
            new NewsItemCategories
            {
                CategoryId = 1,
                NewsItemId = 1
            },

            new NewsItemCategories
            {
                CategoryId = 3,
                NewsItemId = 1
            }
        };
    }
}