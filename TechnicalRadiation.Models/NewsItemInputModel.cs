using System;

namespace TechnicalRadiation.WebApi.Models
{
    public class NewsItemInputModel
    {
        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; }
        [Required(ErrorMessage = "A valid URL is required")]
        public string ImgSource { get; set; }
        [Maxlength(50)]
        public string ShortDescription { get; set; }
        [Minlength(50)]
        [Maxlength(255)]
        public string LongDescription { get; set; }
        [Required]
        public DateTime PublishDate { get; set; }
    }
}