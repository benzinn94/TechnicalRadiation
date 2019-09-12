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
                ImgSource = "https://ichef.bbci.co.uk/onesport/cps/480/cpsprodpb/1485/production/_108735250_minabodygetty.jpg",
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
                ImgSource = "https://i.ytimg.com/vi/tAn_PDIHn4Y/maxresdefault.jpg",
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
                ImgSource = "https://i.kinja-img.com/gawker-media/image/upload/s--Q_vjgqDr--/18j55u6gbdexnjpg.jpg",
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
                ImgSource = "http://www.mikefinding-online.com/wp-content/uploads/2012/05/pissed-off-old-lady.jpg",
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
                ImgSource = "https://images-na.ssl-images-amazon.com/images/I/51F1KWQRXPL._SY445_.jpg",
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
                ImgSource = "https://i.imgur.com/Ipg62jA.jpg",
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
                ImgSource = "https://i.cbc.ca/1.4482857.1515812186!/fileImage/httpImage/image.jpg_gen/derivatives/16x9_780/house-fire.jpg",
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
                ImgSource = "https://i.guim.co.uk/img/media/63f84942f711f06f71a57f6d94ee040acdb1194d/0_117_4000_2402/master/4000.jpg?width=300&quality=85&auto=format&fit=max&s=6117f596d4ca4bb6025e68696befdcf3",
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
                ImgSource = "https://www.nutiminn.is/wp-content/uploads/2016/05/gudnith3.jpg",
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
                ImgSource = "https://sportshub.cbsistatic.com/i/2019/09/11/8d1a912a-72c6-4e1e-ba73-d4982af0a37a/team-usa-loses.jpg",
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
                ImgSource = "https://9to5mac.com/wp-content/uploads/sites/6/2019/09/Screen-Shot-2019-09-10-at-14.33.57-PM.jpg?quality=82&strip=all&w=1600",
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
                ImgSource = "https://www.thesun.co.uk/wp-content/uploads/2019/09/planet-image.png",
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
                ImgSource = "https://ih0.redbubble.net/image.815733429.5771/flat,750x,075,f-pad,750x1000,f8f8f8.u1.jpg",
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
                ImgSource = "http://www.plenglish.com/images/2019/abril/06/A-calor.jpg",
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
                ImgSource = "https://res.cloudinary.com/teepublic/image/private/s--sw9hSQx1--/t_Preview/b_rgb:ffffff,c_limit,f_jpg,h_630,q_90,w_630/v1457117739/production/designs/438251_1.jpg",
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
                ImgSource = "https://i.kinja-img.com/gawker-media/image/upload/s--13q5VZSk--/c_scale,f_auto,fl_progressive,q_80,w_800/uetluavmumupwkoaqhwl.jpg",
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
                ImgSource = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSWG3_awANMf2H0AoYQqKgninl1THeoSfn46UB83e-B32uY8O_9",
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
                ImgSource = "https://www.cheatsheet.com/wp-content/uploads/2019/09/Avengers-Endgame-cast-and-Kevin-Feige.jpg",
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
                ImgSource = "http://content.sportslogos.net/news/2016/02/semi-590x332.jpg",
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
                ImgSource = "https://i.ytimg.com/vi/C2uLSOmRx_c/maxresdefault.jpg",
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
                ImgSource = "https://nationalinterest.org/sites/default/files/styles/desktop__1260_/public/main_images/gerr.jpg?itok=VXZpk1bH",
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
                ImgSource = "https://static.scientificamerican.com/sciam/cache/file/95E0A1A6-5BCA-4F0F-BB92D65F2DD8FB0D_source.jpg?w=590&h=800&EC196A4A-853F-4989-B1CE0AF77333D7CD",
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
                ImgSource = "https://townsquare.media/site/534/files/2016/12/rain-forecast.jpg?w=980&q=75",
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
                ImgSource = "https://cdn.wccftech.com/wp-content/uploads/2019/06/keanu-reeves-cyberpunk-2077-johnny-silverhand.jpg",
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
                ImgSource = "https://cdn02.nintendo-europe.com/media/images/10_share_images/games_15/game_boy_advance_7/SI_GBA_Castlevania_image1600w.jpg",
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
                ProfileImgSource = "https://pbs.twimg.com/profile_images/552307347851210752/vrXDcTFC_400x400.jpeg",
                Bio = "I have a podcast and shit. I also like UFC. And stuff.",
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },

            new Author 
            {
                Id = 4,
                Name = "Tom the cat",
                ProfileImgSource = "https://i.kym-cdn.com/entries/icons/mobile/000/026/618/ZEBxqIA.jpg",
                Bio = "I like to sleep a lot. But most of the time I can't because of my roommate, Jerry.",
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
             
            new Author 
            {
                Id = 5,
                Name = "Jerry",
                ProfileImgSource = "https://vignette.wikia.nocookie.net/tomandjerry/images/b/be/Jerry_Mouse_image.jpg",
                Bio = "I'd say I'm a pretty active personality. I like to do all kinds of things like explore the huge house I live in. Also annoy the shit out of my roomate!",
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },

            new Author 
            {
                Id = 6,
                Name = "Skeletor",
                ProfileImgSource = "http://unrealitymag.com/wp-content/uploads/2019/02/skeletor-750x395.jpg",
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

            new NewsItemAuthors
            {
                AuthorId = 5,
                NewsItemId = 9
            },

            new NewsItemAuthors
            {
                AuthorId = 5,
                NewsItemId = 10
            },

            new NewsItemAuthors
            {
                AuthorId = 2,
                NewsItemId = 11
            },

            new NewsItemAuthors
            {
                AuthorId = 3,
                NewsItemId = 12
            },

            new NewsItemAuthors
            {
                AuthorId = 4,
                NewsItemId = 13
            },

            new NewsItemAuthors
            {
                AuthorId = 1,
                NewsItemId = 14
            },

            new NewsItemAuthors
            {
                AuthorId = 6,
                NewsItemId = 15
            },

            new NewsItemAuthors
            {
                AuthorId = 6,
                NewsItemId = 16
            },

            new NewsItemAuthors
            {
                AuthorId = 7,
                NewsItemId = 17
            },

            new NewsItemAuthors
            {
                AuthorId = 8,
                NewsItemId = 18
            },

            new NewsItemAuthors
            {
                AuthorId = 8,
                NewsItemId = 19
            },

            new NewsItemAuthors
            {
                AuthorId = 7,
                NewsItemId = 20
            },

            new NewsItemAuthors
            {
                AuthorId = 3,
                NewsItemId = 21
            },

            new NewsItemAuthors
            {
                AuthorId = 2,
                NewsItemId = 22
            },

            new NewsItemAuthors
            {
                AuthorId = 1,
                NewsItemId = 23
            },

            new NewsItemAuthors
            {
                AuthorId = 6,
                NewsItemId = 24
            },

            new NewsItemAuthors
            {
                AuthorId = 5,
                NewsItemId = 25
            },

            new NewsItemAuthors
            {
                AuthorId = 6,
                NewsItemId = 26
            }
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
                CategoryId = 4,
                NewsItemId = 3
            },

            new NewsItemCategories
            {
                CategoryId = 3,
                NewsItemId = 3
            },

            new NewsItemCategories
            {
                CategoryId = 4,
                NewsItemId = 3
            },

            new NewsItemCategories
            {
                CategoryId = 3,
                NewsItemId = 4
            },

            new NewsItemCategories
            {
                CategoryId = 4,
                NewsItemId = 5
            },

            new NewsItemCategories
            {
                CategoryId = 3,
                NewsItemId = 9
            },

            new NewsItemCategories
            {
                CategoryId = 1,
                NewsItemId = 9
            },

            new NewsItemCategories
            {
                CategoryId = 1,
                NewsItemId = 10
            },

            new NewsItemCategories
            {
                CategoryId = 5,
                NewsItemId = 11
            },

            new NewsItemCategories
            {
                CategoryId = 2,
                NewsItemId = 12
            },

            new NewsItemCategories
            {
                CategoryId = 3,
                NewsItemId = 13
            },

            new NewsItemCategories
            {
                CategoryId = 2,
                NewsItemId = 14
            },

            new NewsItemCategories
            {
                CategoryId = 4,
                NewsItemId = 15
            },

            new NewsItemCategories
            {
                CategoryId = 6,
                NewsItemId = 15
            },

            new NewsItemCategories
            {
                CategoryId = 4,
                NewsItemId = 16
            },

            new NewsItemCategories
            {
                CategoryId = 1,
                NewsItemId = 16
            },

            new NewsItemCategories
            {
                CategoryId = 3,
                NewsItemId = 17
            },

            new NewsItemCategories
            {
                CategoryId = 3,
                NewsItemId = 18
            },

            new NewsItemCategories
            {
                CategoryId = 7,
                NewsItemId = 18
            },

            new NewsItemCategories
            {
                CategoryId = 1,
                NewsItemId = 19
            },

            new NewsItemCategories
            {
                CategoryId = 5,
                NewsItemId = 20
            },

            new NewsItemCategories
            {
                CategoryId = 2,
                NewsItemId = 21
            },

            new NewsItemCategories
            {
                CategoryId = 3,
                NewsItemId = 22
            },

            new NewsItemCategories
            {
                CategoryId = 1,
                NewsItemId = 22
            },

            new NewsItemCategories
            {
                CategoryId = 4,
                NewsItemId = 23
            },

            new NewsItemCategories
            {
                CategoryId = 6,
                NewsItemId = 24
            },

            new NewsItemCategories
            {
                CategoryId = 3,
                NewsItemId = 25
            },

            new NewsItemCategories
            {
                CategoryId = 7,
                NewsItemId = 25
            },

            new NewsItemCategories
            {
                CategoryId = 7,
                NewsItemId = 26
            },

            new NewsItemCategories
            {
                CategoryId = 3,
                NewsItemId = 26
            }
        };
    }
}