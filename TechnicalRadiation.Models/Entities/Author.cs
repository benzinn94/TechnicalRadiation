using System;

namespace TechnicalRadiation.WebApi.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ProfileImgSource { get; set; }
        public string Bio { get; set; }
        public string ModifiedBy = "TechnicalRadiationAdmin";

        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}