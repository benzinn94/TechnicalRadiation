namespace TechnicalRadiation.WebApi.Models
{
    public class CategoryInputModel
    {
        [Required]
        [MaxLength(60)]
        public string Name { get; set; }
    }
}