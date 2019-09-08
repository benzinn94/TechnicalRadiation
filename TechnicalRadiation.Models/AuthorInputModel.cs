namespace TechnicalRadiation.WebApi.Models
{
    public class AuthorInputModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string ProfileImgSource { get; set; }
        [Maxlength(255)]
        public string Bio { get; set; }
    }
}