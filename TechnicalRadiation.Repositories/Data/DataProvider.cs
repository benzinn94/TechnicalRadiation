using System;
using System.Collections.Generic;
using TechnicalRadiation.WebApi.Models;

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
    }
}