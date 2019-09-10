using System;
using System.ComponentModel.DataAnnotations;

namespace TechnicalRadiation.Models.InputModels
{
    public class NewsItemInputModel
    {
        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; }
        [Required(ErrorMessage = "A valid URL is required")]
        public string ImgSource { get; set; }
        [MaxLength(50)]
        public string ShortDescription { get; set; }
        [MinLength(50)]
        [MaxLength(255)]
        public string LongDescription { get; set; }
        [Required]
        public DateTime PublishDate { get; set; }
    }
}