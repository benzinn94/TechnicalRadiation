using System;

namespace TechnicalRadiation.WebApi.Models
{
    public class NewsItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ImgSource { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public DateTime MyProperty { get; set; }
        public string ModifiedBy = "TechnicalRadiationAdmin";
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}