using System.Collections.Generic;

namespace TechnicalRadiation.Models.Dtos
{
    public class LinkDto {
        public Dictionary<string, string> Self { get; private set; }
        public Dictionary<string, string> Edit { get; private set; }
        public Dictionary<string, string> Delete { get; private set; }

        public Dictionary<string, string> Authors {get; private set; }

        public Dictionary<string, string> Categories {get; private set;}

        public LinkDto(string href) {
        }
    }
}