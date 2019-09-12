using System;
using System.Collections.Generic;
using TechnicalRadiation.Models.Entities;

namespace TechnicalRadiation.Repositories.Data.DataProvider
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
                PublishDate = DateTime.Now,
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new NewsItem
            {
               Id = 2,
                Title = "Yerry Mina: Everton defender fined £10,000 for breaking FA betting rules",
                ImgSource = "https://live.staticflickr.com/3557/3688988206_ef3af4af10_b.jpg",
                ShortDescription = "Everton's Yerry Mina has been fined £10,000 and warned as to his future conduct after admitting breaching Football Association betting rules.",
                LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec tempus lectus sed magna gravida, congue cursus velit imperdiet. Aliquam erat volutpat. Pellentesque lacinia neque vitae finibus blandit. Suspendisse cursus neque vitae nunc molestie, ut placerat ipsum egestas. Mauris varius orci metus, vel posuere dui iaculis id. Fusce aliquet magna vel felis dignissim blandit. Nunc euismod pulvinar ante quis ornare. Morbi vulputate metus nec felis pulvinar, tincidunt venenatis neque fringilla. Fusce purus nibh, maximus in pulvinar eu, suscipit a ipsum. Quisque augue diam, scelerisque facilisis sem in, condimentum placerat est. Etiam fermentum dui id diam eleifend fringilla. Cras vitae urna iaculis, rhoncus augue quis, pretium tellus. Vestibulum vel neque id dui blandit pellentesque. Mauris posuere malesuada orci ac viverra. Nullam ligula orci, fermentum tincidunt iaculis quis, finibus faucibus massa.",
                PublishDate = DateTime.Now,
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new NewsItem
            {
                Id = 3,
                Title = "Man eats spiders for breakfast every morning",
                ImgSource = "https://live.staticflickr.com/3557/3688988206_ef3af4af10_b.jpg",
                ShortDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer et.",
                LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec tempus lectus sed magna gravida, congue cursus velit imperdiet. Aliquam erat volutpat. Pellentesque lacinia neque vitae finibus blandit. Suspendisse cursus neque vitae nunc molestie, ut placerat ipsum egestas. Mauris varius orci metus, vel posuere dui iaculis id. Fusce aliquet magna vel felis dignissim blandit. Nunc euismod pulvinar ante quis ornare. Morbi vulputate metus nec felis pulvinar, tincidunt venenatis neque fringilla. Fusce purus nibh, maximus in pulvinar eu, suscipit a ipsum. Quisque augue diam, scelerisque facilisis sem in, condimentum placerat est. Etiam fermentum dui id diam eleifend fringilla. Cras vitae urna iaculis, rhoncus augue quis, pretium tellus. Vestibulum vel neque id dui blandit pellentesque. Mauris posuere malesuada orci ac viverra. Nullam ligula orci, fermentum tincidunt iaculis quis, finibus faucibus massa.",
                PublishDate = DateTime.Now,
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new NewsItem
            {
                Id = 4,
                Title = "Woman intends to marry own cat, says cat's love is 'more' unconditional than ex-husband's",
                ImgSource = "https://live.staticflickr.com/3557/3688988206_ef3af4af10_b.jpg",
                ShortDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer et.",
                LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec tempus lectus sed magna gravida, congue cursus velit imperdiet. Aliquam erat volutpat. Pellentesque lacinia neque vitae finibus blandit. Suspendisse cursus neque vitae nunc molestie, ut placerat ipsum egestas. Mauris varius orci metus, vel posuere dui iaculis id. Fusce aliquet magna vel felis dignissim blandit. Nunc euismod pulvinar ante quis ornare. Morbi vulputate metus nec felis pulvinar, tincidunt venenatis neque fringilla. Fusce purus nibh, maximus in pulvinar eu, suscipit a ipsum. Quisque augue diam, scelerisque facilisis sem in, condimentum placerat est. Etiam fermentum dui id diam eleifend fringilla. Cras vitae urna iaculis, rhoncus augue quis, pretium tellus. Vestibulum vel neque id dui blandit pellentesque. Mauris posuere malesuada orci ac viverra. Nullam ligula orci, fermentum tincidunt iaculis quis, finibus faucibus massa.",
                PublishDate = DateTime.Now,
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new NewsItem
            {
                Id = 5,
                Title = "Group of boys pick wild flowers to give old woman in neighbourhood. Old lady tells them to bugger off.",
                ImgSource = "https://live.staticflickr.com/3557/3688988206_ef3af4af10_b.jpg",
                ShortDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer et.",
                LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec tempus lectus sed magna gravida, congue cursus velit imperdiet. Aliquam erat volutpat. Pellentesque lacinia neque vitae finibus blandit. Suspendisse cursus neque vitae nunc molestie, ut placerat ipsum egestas. Mauris varius orci metus, vel posuere dui iaculis id. Fusce aliquet magna vel felis dignissim blandit. Nunc euismod pulvinar ante quis ornare. Morbi vulputate metus nec felis pulvinar, tincidunt venenatis neque fringilla. Fusce purus nibh, maximus in pulvinar eu, suscipit a ipsum. Quisque augue diam, scelerisque facilisis sem in, condimentum placerat est. Etiam fermentum dui id diam eleifend fringilla. Cras vitae urna iaculis, rhoncus augue quis, pretium tellus. Vestibulum vel neque id dui blandit pellentesque. Mauris posuere malesuada orci ac viverra. Nullam ligula orci, fermentum tincidunt iaculis quis, finibus faucibus massa.",
                PublishDate = DateTime.Now,
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new NewsItem
            {
                Id = 6,
                Title = "Four boys set out for adventure on railroad. Find dead body.",
                ImgSource = "https://live.staticflickr.com/3557/3688988206_ef3af4af10_b.jpg",
                ShortDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer et.",
                LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec tempus lectus sed magna gravida, congue cursus velit imperdiet. Aliquam erat volutpat. Pellentesque lacinia neque vitae finibus blandit. Suspendisse cursus neque vitae nunc molestie, ut placerat ipsum egestas. Mauris varius orci metus, vel posuere dui iaculis id. Fusce aliquet magna vel felis dignissim blandit. Nunc euismod pulvinar ante quis ornare. Morbi vulputate metus nec felis pulvinar, tincidunt venenatis neque fringilla. Fusce purus nibh, maximus in pulvinar eu, suscipit a ipsum. Quisque augue diam, scelerisque facilisis sem in, condimentum placerat est. Etiam fermentum dui id diam eleifend fringilla. Cras vitae urna iaculis, rhoncus augue quis, pretium tellus. Vestibulum vel neque id dui blandit pellentesque. Mauris posuere malesuada orci ac viverra. Nullam ligula orci, fermentum tincidunt iaculis quis, finibus faucibus massa.",
                PublishDate = DateTime.Now,
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new NewsItem
            {
                Id = 7,
                Title = "Don't dead. Open inside.",
                ImgSource = "https://live.staticflickr.com/3557/3688988206_ef3af4af10_b.jpg",
                ShortDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer et.",
                LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec tempus lectus sed magna gravida, congue cursus velit imperdiet. Aliquam erat volutpat. Pellentesque lacinia neque vitae finibus blandit. Suspendisse cursus neque vitae nunc molestie, ut placerat ipsum egestas. Mauris varius orci metus, vel posuere dui iaculis id. Fusce aliquet magna vel felis dignissim blandit. Nunc euismod pulvinar ante quis ornare. Morbi vulputate metus nec felis pulvinar, tincidunt venenatis neque fringilla. Fusce purus nibh, maximus in pulvinar eu, suscipit a ipsum. Quisque augue diam, scelerisque facilisis sem in, condimentum placerat est. Etiam fermentum dui id diam eleifend fringilla. Cras vitae urna iaculis, rhoncus augue quis, pretium tellus. Vestibulum vel neque id dui blandit pellentesque. Mauris posuere malesuada orci ac viverra. Nullam ligula orci, fermentum tincidunt iaculis quis, finibus faucibus massa.",
                PublishDate = DateTime.Now,
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new NewsItem
            {
                Id = 8,
                Title = "Simple man burns down own house. Claims that indoor bonfire was meant to create a 'romantic setting'.",
                ImgSource = "https://live.staticflickr.com/3557/3688988206_ef3af4af10_b.jpg",
                ShortDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer et.",
                LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec tempus lectus sed magna gravida, congue cursus velit imperdiet. Aliquam erat volutpat. Pellentesque lacinia neque vitae finibus blandit. Suspendisse cursus neque vitae nunc molestie, ut placerat ipsum egestas. Mauris varius orci metus, vel posuere dui iaculis id. Fusce aliquet magna vel felis dignissim blandit. Nunc euismod pulvinar ante quis ornare. Morbi vulputate metus nec felis pulvinar, tincidunt venenatis neque fringilla. Fusce purus nibh, maximus in pulvinar eu, suscipit a ipsum. Quisque augue diam, scelerisque facilisis sem in, condimentum placerat est. Etiam fermentum dui id diam eleifend fringilla. Cras vitae urna iaculis, rhoncus augue quis, pretium tellus. Vestibulum vel neque id dui blandit pellentesque. Mauris posuere malesuada orci ac viverra. Nullam ligula orci, fermentum tincidunt iaculis quis, finibus faucibus massa.",
                PublishDate = DateTime.Now,
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },

            new NewsItem
            {
                Id = 9,
                Title = "Trump to ban the use of inflateable animals as they offend him and cause a national security risk",
                ImgSource = "https://live.staticflickr.com/3557/3688988206_ef3af4af10_b.jpg",
                ShortDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer et.",
                LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec tempus lectus sed magna gravida, congue cursus velit imperdiet. Aliquam erat volutpat. Pellentesque lacinia neque vitae finibus blandit. Suspendisse cursus neque vitae nunc molestie, ut placerat ipsum egestas. Mauris varius orci metus, vel posuere dui iaculis id. Fusce aliquet magna vel felis dignissim blandit. Nunc euismod pulvinar ante quis ornare. Morbi vulputate metus nec felis pulvinar, tincidunt venenatis neque fringilla. Fusce purus nibh, maximus in pulvinar eu, suscipit a ipsum. Quisque augue diam, scelerisque facilisis sem in, condimentum placerat est. Etiam fermentum dui id diam eleifend fringilla. Cras vitae urna iaculis, rhoncus augue quis, pretium tellus. Vestibulum vel neque id dui blandit pellentesque. Mauris posuere malesuada orci ac viverra. Nullam ligula orci, fermentum tincidunt iaculis quis, finibus faucibus massa.",
                PublishDate = DateTime.Now,
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },

            new NewsItem
            {
                Id = 10,
                Title = "The president of Iceland, Gudni Th. Johannesson, running for president again 2020",
                ImgSource = "https://live.staticflickr.com/3557/3688988206_ef3af4af10_b.jpg",
                ShortDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer et.",
                LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec tempus lectus sed magna gravida, congue cursus velit imperdiet. Aliquam erat volutpat. Pellentesque lacinia neque vitae finibus blandit. Suspendisse cursus neque vitae nunc molestie, ut placerat ipsum egestas. Mauris varius orci metus, vel posuere dui iaculis id. Fusce aliquet magna vel felis dignissim blandit. Nunc euismod pulvinar ante quis ornare. Morbi vulputate metus nec felis pulvinar, tincidunt venenatis neque fringilla. Fusce purus nibh, maximus in pulvinar eu, suscipit a ipsum. Quisque augue diam, scelerisque facilisis sem in, condimentum placerat est. Etiam fermentum dui id diam eleifend fringilla. Cras vitae urna iaculis, rhoncus augue quis, pretium tellus. Vestibulum vel neque id dui blandit pellentesque. Mauris posuere malesuada orci ac viverra. Nullam ligula orci, fermentum tincidunt iaculis quis, finibus faucibus massa.",
                PublishDate = DateTime.Now,
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },

            new NewsItem
            {
                Id = 11,
                Title = "Team USA loose against France, 89-79 in the FIBA World Cup",
                ImgSource = "https://live.staticflickr.com/3557/3688988206_ef3af4af10_b.jpg",
                ShortDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer et.",
                LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec tempus lectus sed magna gravida, congue cursus velit imperdiet. Aliquam erat volutpat. Pellentesque lacinia neque vitae finibus blandit. Suspendisse cursus neque vitae nunc molestie, ut placerat ipsum egestas. Mauris varius orci metus, vel posuere dui iaculis id. Fusce aliquet magna vel felis dignissim blandit. Nunc euismod pulvinar ante quis ornare. Morbi vulputate metus nec felis pulvinar, tincidunt venenatis neque fringilla. Fusce purus nibh, maximus in pulvinar eu, suscipit a ipsum. Quisque augue diam, scelerisque facilisis sem in, condimentum placerat est. Etiam fermentum dui id diam eleifend fringilla. Cras vitae urna iaculis, rhoncus augue quis, pretium tellus. Vestibulum vel neque id dui blandit pellentesque. Mauris posuere malesuada orci ac viverra. Nullam ligula orci, fermentum tincidunt iaculis quis, finibus faucibus massa.",
                PublishDate = DateTime.Now,
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },

            new NewsItem
            {
                Id = 12,
                Title = "Apple announce the new iPhone 11!",
                ImgSource = "https://live.staticflickr.com/3557/3688988206_ef3af4af10_b.jpg",
                ShortDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer et.",
                LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec tempus lectus sed magna gravida, congue cursus velit imperdiet. Aliquam erat volutpat. Pellentesque lacinia neque vitae finibus blandit. Suspendisse cursus neque vitae nunc molestie, ut placerat ipsum egestas. Mauris varius orci metus, vel posuere dui iaculis id. Fusce aliquet magna vel felis dignissim blandit. Nunc euismod pulvinar ante quis ornare. Morbi vulputate metus nec felis pulvinar, tincidunt venenatis neque fringilla. Fusce purus nibh, maximus in pulvinar eu, suscipit a ipsum. Quisque augue diam, scelerisque facilisis sem in, condimentum placerat est. Etiam fermentum dui id diam eleifend fringilla. Cras vitae urna iaculis, rhoncus augue quis, pretium tellus. Vestibulum vel neque id dui blandit pellentesque. Mauris posuere malesuada orci ac viverra. Nullam ligula orci, fermentum tincidunt iaculis quis, finibus faucibus massa.",
                PublishDate = DateTime.Now,
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },

            new NewsItem
            {
                Id = 13,
                Title = "Breaking news: Signs of alien life have been discovered on Mars!",
                ImgSource = "https://live.staticflickr.com/3557/3688988206_ef3af4af10_b.jpg",
                ShortDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer et.",
                LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec tempus lectus sed magna gravida, congue cursus velit imperdiet. Aliquam erat volutpat. Pellentesque lacinia neque vitae finibus blandit. Suspendisse cursus neque vitae nunc molestie, ut placerat ipsum egestas. Mauris varius orci metus, vel posuere dui iaculis id. Fusce aliquet magna vel felis dignissim blandit. Nunc euismod pulvinar ante quis ornare. Morbi vulputate metus nec felis pulvinar, tincidunt venenatis neque fringilla. Fusce purus nibh, maximus in pulvinar eu, suscipit a ipsum. Quisque augue diam, scelerisque facilisis sem in, condimentum placerat est. Etiam fermentum dui id diam eleifend fringilla. Cras vitae urna iaculis, rhoncus augue quis, pretium tellus. Vestibulum vel neque id dui blandit pellentesque. Mauris posuere malesuada orci ac viverra. Nullam ligula orci, fermentum tincidunt iaculis quis, finibus faucibus massa.",
                PublishDate = DateTime.Now,
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },

            new NewsItem
            {
                Id = 14,
                Title = "Tesla opens a new shop in Iceland",
                ImgSource = "https://live.staticflickr.com/3557/3688988206_ef3af4af10_b.jpg",
                ShortDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer et.",
                LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec tempus lectus sed magna gravida, congue cursus velit imperdiet. Aliquam erat volutpat. Pellentesque lacinia neque vitae finibus blandit. Suspendisse cursus neque vitae nunc molestie, ut placerat ipsum egestas. Mauris varius orci metus, vel posuere dui iaculis id. Fusce aliquet magna vel felis dignissim blandit. Nunc euismod pulvinar ante quis ornare. Morbi vulputate metus nec felis pulvinar, tincidunt venenatis neque fringilla. Fusce purus nibh, maximus in pulvinar eu, suscipit a ipsum. Quisque augue diam, scelerisque facilisis sem in, condimentum placerat est. Etiam fermentum dui id diam eleifend fringilla. Cras vitae urna iaculis, rhoncus augue quis, pretium tellus. Vestibulum vel neque id dui blandit pellentesque. Mauris posuere malesuada orci ac viverra. Nullam ligula orci, fermentum tincidunt iaculis quis, finibus faucibus massa.",
                PublishDate = DateTime.Now,
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },

            new NewsItem
            {
                Id = 15,
                Title = "Temperatures reach a new high in Australia soaring up to 55°c",
                ImgSource = "https://live.staticflickr.com/3557/3688988206_ef3af4af10_b.jpg",
                ShortDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer et.",
                LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec tempus lectus sed magna gravida, congue cursus velit imperdiet. Aliquam erat volutpat. Pellentesque lacinia neque vitae finibus blandit. Suspendisse cursus neque vitae nunc molestie, ut placerat ipsum egestas. Mauris varius orci metus, vel posuere dui iaculis id. Fusce aliquet magna vel felis dignissim blandit. Nunc euismod pulvinar ante quis ornare. Morbi vulputate metus nec felis pulvinar, tincidunt venenatis neque fringilla. Fusce purus nibh, maximus in pulvinar eu, suscipit a ipsum. Quisque augue diam, scelerisque facilisis sem in, condimentum placerat est. Etiam fermentum dui id diam eleifend fringilla. Cras vitae urna iaculis, rhoncus augue quis, pretium tellus. Vestibulum vel neque id dui blandit pellentesque. Mauris posuere malesuada orci ac viverra. Nullam ligula orci, fermentum tincidunt iaculis quis, finibus faucibus massa.",
                PublishDate = DateTime.Now,
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },

            new NewsItem
            {
                Id = 16,
                Title = "Aperture Science found guilty of polution",
                ImgSource = "https://live.staticflickr.com/3557/3688988206_ef3af4af10_b.jpg",
                ShortDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer et.",
                LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec tempus lectus sed magna gravida, congue cursus velit imperdiet. Aliquam erat volutpat. Pellentesque lacinia neque vitae finibus blandit. Suspendisse cursus neque vitae nunc molestie, ut placerat ipsum egestas. Mauris varius orci metus, vel posuere dui iaculis id. Fusce aliquet magna vel felis dignissim blandit. Nunc euismod pulvinar ante quis ornare. Morbi vulputate metus nec felis pulvinar, tincidunt venenatis neque fringilla. Fusce purus nibh, maximus in pulvinar eu, suscipit a ipsum. Quisque augue diam, scelerisque facilisis sem in, condimentum placerat est. Etiam fermentum dui id diam eleifend fringilla. Cras vitae urna iaculis, rhoncus augue quis, pretium tellus. Vestibulum vel neque id dui blandit pellentesque. Mauris posuere malesuada orci ac viverra. Nullam ligula orci, fermentum tincidunt iaculis quis, finibus faucibus massa.",
                PublishDate = DateTime.Now,
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },

            new NewsItem
            {
                Id = 17,
                Title = "Mario saves the princess only to find out the Bowser has taken her to another castle",
                ImgSource = "https://live.staticflickr.com/3557/3688988206_ef3af4af10_b.jpg",
                ShortDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer et.",
                LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec tempus lectus sed magna gravida, congue cursus velit imperdiet. Aliquam erat volutpat. Pellentesque lacinia neque vitae finibus blandit. Suspendisse cursus neque vitae nunc molestie, ut placerat ipsum egestas. Mauris varius orci metus, vel posuere dui iaculis id. Fusce aliquet magna vel felis dignissim blandit. Nunc euismod pulvinar ante quis ornare. Morbi vulputate metus nec felis pulvinar, tincidunt venenatis neque fringilla. Fusce purus nibh, maximus in pulvinar eu, suscipit a ipsum. Quisque augue diam, scelerisque facilisis sem in, condimentum placerat est. Etiam fermentum dui id diam eleifend fringilla. Cras vitae urna iaculis, rhoncus augue quis, pretium tellus. Vestibulum vel neque id dui blandit pellentesque. Mauris posuere malesuada orci ac viverra. Nullam ligula orci, fermentum tincidunt iaculis quis, finibus faucibus massa.",
                PublishDate = DateTime.Now,
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },

            new NewsItem
            {
                Id = 18,
                Title = "Link finally woke up from a hundred year sleep and had this to say",
                ImgSource = "https://live.staticflickr.com/3557/3688988206_ef3af4af10_b.jpg",
                ShortDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer et.",
                LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec tempus lectus sed magna gravida, congue cursus velit imperdiet. Aliquam erat volutpat. Pellentesque lacinia neque vitae finibus blandit. Suspendisse cursus neque vitae nunc molestie, ut placerat ipsum egestas. Mauris varius orci metus, vel posuere dui iaculis id. Fusce aliquet magna vel felis dignissim blandit. Nunc euismod pulvinar ante quis ornare. Morbi vulputate metus nec felis pulvinar, tincidunt venenatis neque fringilla. Fusce purus nibh, maximus in pulvinar eu, suscipit a ipsum. Quisque augue diam, scelerisque facilisis sem in, condimentum placerat est. Etiam fermentum dui id diam eleifend fringilla. Cras vitae urna iaculis, rhoncus augue quis, pretium tellus. Vestibulum vel neque id dui blandit pellentesque. Mauris posuere malesuada orci ac viverra. Nullam ligula orci, fermentum tincidunt iaculis quis, finibus faucibus massa.",
                PublishDate = DateTime.Now,
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },

            new NewsItem
            {
                Id = 19,
                Title = "Avengers go before the Supreme Court after the insident in Cambodia",
                ImgSource = "https://live.staticflickr.com/3557/3688988206_ef3af4af10_b.jpg",
                ShortDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer et.",
                LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec tempus lectus sed magna gravida, congue cursus velit imperdiet. Aliquam erat volutpat. Pellentesque lacinia neque vitae finibus blandit. Suspendisse cursus neque vitae nunc molestie, ut placerat ipsum egestas. Mauris varius orci metus, vel posuere dui iaculis id. Fusce aliquet magna vel felis dignissim blandit. Nunc euismod pulvinar ante quis ornare. Morbi vulputate metus nec felis pulvinar, tincidunt venenatis neque fringilla. Fusce purus nibh, maximus in pulvinar eu, suscipit a ipsum. Quisque augue diam, scelerisque facilisis sem in, condimentum placerat est. Etiam fermentum dui id diam eleifend fringilla. Cras vitae urna iaculis, rhoncus augue quis, pretium tellus. Vestibulum vel neque id dui blandit pellentesque. Mauris posuere malesuada orci ac viverra. Nullam ligula orci, fermentum tincidunt iaculis quis, finibus faucibus massa.",
                PublishDate = DateTime.Now,
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },

            new NewsItem
            {
                Id = 20,
                Title = "The Flint Tropics become the ABA national champions",
                ImgSource = "https://live.staticflickr.com/3557/3688988206_ef3af4af10_b.jpg",
                ShortDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer et.",
                LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec tempus lectus sed magna gravida, congue cursus velit imperdiet. Aliquam erat volutpat. Pellentesque lacinia neque vitae finibus blandit. Suspendisse cursus neque vitae nunc molestie, ut placerat ipsum egestas. Mauris varius orci metus, vel posuere dui iaculis id. Fusce aliquet magna vel felis dignissim blandit. Nunc euismod pulvinar ante quis ornare. Morbi vulputate metus nec felis pulvinar, tincidunt venenatis neque fringilla. Fusce purus nibh, maximus in pulvinar eu, suscipit a ipsum. Quisque augue diam, scelerisque facilisis sem in, condimentum placerat est. Etiam fermentum dui id diam eleifend fringilla. Cras vitae urna iaculis, rhoncus augue quis, pretium tellus. Vestibulum vel neque id dui blandit pellentesque. Mauris posuere malesuada orci ac viverra. Nullam ligula orci, fermentum tincidunt iaculis quis, finibus faucibus massa.",
                PublishDate = DateTime.Now,
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },

            new NewsItem
            {
                Id = 21,
                Title = "A petabyte hard drive has finally been released for public use",
                ImgSource = "https://live.staticflickr.com/3557/3688988206_ef3af4af10_b.jpg",
                ShortDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer et.",
                LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec tempus lectus sed magna gravida, congue cursus velit imperdiet. Aliquam erat volutpat. Pellentesque lacinia neque vitae finibus blandit. Suspendisse cursus neque vitae nunc molestie, ut placerat ipsum egestas. Mauris varius orci metus, vel posuere dui iaculis id. Fusce aliquet magna vel felis dignissim blandit. Nunc euismod pulvinar ante quis ornare. Morbi vulputate metus nec felis pulvinar, tincidunt venenatis neque fringilla. Fusce purus nibh, maximus in pulvinar eu, suscipit a ipsum. Quisque augue diam, scelerisque facilisis sem in, condimentum placerat est. Etiam fermentum dui id diam eleifend fringilla. Cras vitae urna iaculis, rhoncus augue quis, pretium tellus. Vestibulum vel neque id dui blandit pellentesque. Mauris posuere malesuada orci ac viverra. Nullam ligula orci, fermentum tincidunt iaculis quis, finibus faucibus massa.",
                PublishDate = DateTime.Now,
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },

            new NewsItem
            {
                Id = 22,
                Title = "Breaking news: USA has declared war on North Korea",
                ImgSource = "https://live.staticflickr.com/3557/3688988206_ef3af4af10_b.jpg",
                ShortDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer et.",
                LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec tempus lectus sed magna gravida, congue cursus velit imperdiet. Aliquam erat volutpat. Pellentesque lacinia neque vitae finibus blandit. Suspendisse cursus neque vitae nunc molestie, ut placerat ipsum egestas. Mauris varius orci metus, vel posuere dui iaculis id. Fusce aliquet magna vel felis dignissim blandit. Nunc euismod pulvinar ante quis ornare. Morbi vulputate metus nec felis pulvinar, tincidunt venenatis neque fringilla. Fusce purus nibh, maximus in pulvinar eu, suscipit a ipsum. Quisque augue diam, scelerisque facilisis sem in, condimentum placerat est. Etiam fermentum dui id diam eleifend fringilla. Cras vitae urna iaculis, rhoncus augue quis, pretium tellus. Vestibulum vel neque id dui blandit pellentesque. Mauris posuere malesuada orci ac viverra. Nullam ligula orci, fermentum tincidunt iaculis quis, finibus faucibus massa.",
                PublishDate = DateTime.Now,
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },

            new NewsItem
            {
                Id = 23,
                Title = "Climate change is effecting more than you think. What you can do to help",
                ImgSource = "https://live.staticflickr.com/3557/3688988206_ef3af4af10_b.jpg",
                ShortDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer et.",
                LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec tempus lectus sed magna gravida, congue cursus velit imperdiet. Aliquam erat volutpat. Pellentesque lacinia neque vitae finibus blandit. Suspendisse cursus neque vitae nunc molestie, ut placerat ipsum egestas. Mauris varius orci metus, vel posuere dui iaculis id. Fusce aliquet magna vel felis dignissim blandit. Nunc euismod pulvinar ante quis ornare. Morbi vulputate metus nec felis pulvinar, tincidunt venenatis neque fringilla. Fusce purus nibh, maximus in pulvinar eu, suscipit a ipsum. Quisque augue diam, scelerisque facilisis sem in, condimentum placerat est. Etiam fermentum dui id diam eleifend fringilla. Cras vitae urna iaculis, rhoncus augue quis, pretium tellus. Vestibulum vel neque id dui blandit pellentesque. Mauris posuere malesuada orci ac viverra. Nullam ligula orci, fermentum tincidunt iaculis quis, finibus faucibus massa.",
                PublishDate = DateTime.Now,
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },

            new NewsItem
            {
                Id = 24,
                Title = "Heavy rain and strong winds expected to hit Iceland in the next days. Residents asked to take the trampolines inside",
                ImgSource = "https://live.staticflickr.com/3557/3688988206_ef3af4af10_b.jpg",
                ShortDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer et.",
                LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec tempus lectus sed magna gravida, congue cursus velit imperdiet. Aliquam erat volutpat. Pellentesque lacinia neque vitae finibus blandit. Suspendisse cursus neque vitae nunc molestie, ut placerat ipsum egestas. Mauris varius orci metus, vel posuere dui iaculis id. Fusce aliquet magna vel felis dignissim blandit. Nunc euismod pulvinar ante quis ornare. Morbi vulputate metus nec felis pulvinar, tincidunt venenatis neque fringilla. Fusce purus nibh, maximus in pulvinar eu, suscipit a ipsum. Quisque augue diam, scelerisque facilisis sem in, condimentum placerat est. Etiam fermentum dui id diam eleifend fringilla. Cras vitae urna iaculis, rhoncus augue quis, pretium tellus. Vestibulum vel neque id dui blandit pellentesque. Mauris posuere malesuada orci ac viverra. Nullam ligula orci, fermentum tincidunt iaculis quis, finibus faucibus massa.",
                PublishDate = DateTime.Now,
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },

            new NewsItem
            {
                Id = 25,
                Title = "New DC Projekt Red game, Cyperpunk 2077, coming out in early 2020",
                ImgSource = "https://live.staticflickr.com/3557/3688988206_ef3af4af10_b.jpg",
                ShortDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer et.",
                LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec tempus lectus sed magna gravida, congue cursus velit imperdiet. Aliquam erat volutpat. Pellentesque lacinia neque vitae finibus blandit. Suspendisse cursus neque vitae nunc molestie, ut placerat ipsum egestas. Mauris varius orci metus, vel posuere dui iaculis id. Fusce aliquet magna vel felis dignissim blandit. Nunc euismod pulvinar ante quis ornare. Morbi vulputate metus nec felis pulvinar, tincidunt venenatis neque fringilla. Fusce purus nibh, maximus in pulvinar eu, suscipit a ipsum. Quisque augue diam, scelerisque facilisis sem in, condimentum placerat est. Etiam fermentum dui id diam eleifend fringilla. Cras vitae urna iaculis, rhoncus augue quis, pretium tellus. Vestibulum vel neque id dui blandit pellentesque. Mauris posuere malesuada orci ac viverra. Nullam ligula orci, fermentum tincidunt iaculis quis, finibus faucibus massa.",
                PublishDate = DateTime.Now,
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },

            new NewsItem
            {
                Id = 26,
                Title = "Remake of the classic Castlevania games coming to Nintendo Switch in 2020",
                ImgSource = "https://live.staticflickr.com/3557/3688988206_ef3af4af10_b.jpg",
                ShortDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer et.",
                LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec tempus lectus sed magna gravida, congue cursus velit imperdiet. Aliquam erat volutpat. Pellentesque lacinia neque vitae finibus blandit. Suspendisse cursus neque vitae nunc molestie, ut placerat ipsum egestas. Mauris varius orci metus, vel posuere dui iaculis id. Fusce aliquet magna vel felis dignissim blandit. Nunc euismod pulvinar ante quis ornare. Morbi vulputate metus nec felis pulvinar, tincidunt venenatis neque fringilla. Fusce purus nibh, maximus in pulvinar eu, suscipit a ipsum. Quisque augue diam, scelerisque facilisis sem in, condimentum placerat est. Etiam fermentum dui id diam eleifend fringilla. Cras vitae urna iaculis, rhoncus augue quis, pretium tellus. Vestibulum vel neque id dui blandit pellentesque. Mauris posuere malesuada orci ac viverra. Nullam ligula orci, fermentum tincidunt iaculis quis, finibus faucibus massa.",
                PublishDate = DateTime.Now,
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
                Name = "Lion-O",
                ProfileImgSource = "https://live.staticflickr.com/3557/3688988206_ef3af4af10_b.jpg",
                Bio = "I'm a the leader of the thundercats. My goal is to bring down Mum-Rah",
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },

            new Author 
            {
                Id = 3,
                Name = "Joe Rogan",
                ProfileImgSource = "https://live.staticflickr.com/3557/3688988206_ef3af4af10_b.jpg",
                Bio = "I have a podcast and shit. I also like UFC. And stuff.",
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },

            new Author 
            {
                Id = 4,
                Name = "Tom the cat",
                ProfileImgSource = "https://live.staticflickr.com/3557/3688988206_ef3af4af10_b.jpg",
                Bio = "I like to sleep a lot. But most of the time I can't because of my roommate, Jerry.",
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
             
            new Author 
            {
                Id = 5,
                Name = "Jerry",
                ProfileImgSource = "https://live.staticflickr.com/3557/3688988206_ef3af4af10_b.jpg",
                Bio = "I'd say I'm a pretty active personality. I like to do all kinds of things like explore the huge house I live in. Also annoy the shit out of my roomate!",
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },

            new Author 
            {
                Id = 6,
                Name = "Skeletor",
                ProfileImgSource = "https://live.staticflickr.com/3557/3688988206_ef3af4af10_b.jpg",
                Bio = "I'm setting my eyes on a good piece of real-estate on the planet Eternia. Some people might call it a fortress, but I'd like to call it a home.",
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },

            new Author 
            {
                Id = 7,
                Name = "Bendyflaps Cucumberpatch",
                ProfileImgSource = "https://upload.wikimedia.org/wikipedia/commons/5/53/Benedict_Cumberbatch_%2848470894756%29_%28cropped%29.jpg",
                Bio = "I'm a British actor and I go by many names, but what I wan't most in life is to be referred to as Benny or Benz-o - I guess it's not meant to be.",
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },

            new Author 
            {
                Id = 8,
                Name = "Davy Jones",
                ProfileImgSource = "https://upload.wikimedia.org/wikipedia/en/e/ec/Piratedavyjones.JPG",
                Bio = "I'm a musician. Play the organ - pretty cool stuff. Spend most of my time at sea though so I can't really get a variety of audience. Very sad indeed.",
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
                Slug = "politics",
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },

            new Category
            {
                Id = 2,
                Name = "Technology",
                Slug = "technology",
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },

            new Category
            {
                Id = 3,
                Name = "Breaking News",
                Slug = "breaking-news",
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },

            new Category
            {
                Id = 4,
                Name = "Environmental",
                Slug = "environmental",
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },

            new Category
            {
                Id = 5,
                Name = "Sports",
                Slug = "sports",
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },

            new Category
            {
                Id = 6,
                Name = "Weather",
                Slug = "weather",
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
             new Category
            {
                Id = 7,
                Name = "Video games",
                Slug = "video-games",
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
            },

            new NewsItemAuthors
            {
                AuthorId = 2,
                NewsItemId = 7
            },

            new NewsItemAuthors
            {
                AuthorId = 3,
                NewsItemId = 2
            },

            new NewsItemAuthors
            {
                AuthorId = 5,
                NewsItemId = 5
            },

            new NewsItemAuthors
            {
                AuthorId = 4,
                NewsItemId = 4
            },

            new NewsItemAuthors
            {
                AuthorId = 6,
                NewsItemId = 3
            },

            new NewsItemAuthors
            {
                AuthorId = 7,
                NewsItemId = 6
            },

            new NewsItemAuthors
            {
                AuthorId = 8,
                NewsItemId = 8
            },
        };

         public static List<NewsItemCategories> NewsItemCategories = new List<NewsItemCategories>
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
            },

            new NewsItemCategories
            {
                CategoryId = 5,
                NewsItemId = 2
            },

            new NewsItemCategories
            {
                CategoryId = 2,
                NewsItemId = 7
            },

            new NewsItemCategories
            {
                CategoryId = 4,
                NewsItemId = 6
            },

            new NewsItemCategories
            {
                CategoryId = 6,
                NewsItemId = 8
            },

            new NewsItemCategories
            {
                CategoryId = 7,
                NewsItemId = 25
            }
        };
    }
}