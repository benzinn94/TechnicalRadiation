using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using TechnicalRadiation.Models.Dtos;
using TechnicalRadiation.Models.Entities;
using TechnicalRadiation.Repositories.Data.DataProvider;

namespace TechnicalRadiation.Repositories
{
    public class AuthorRepository
    {
        private IMapper _mapper;
        public AuthorRepository(IMapper mapper)
        {
            _mapper = mapper;
        }
        public IEnumerable<AuthorDto> GetAllAuthors(){
            return _mapper.Map<IEnumerable<AuthorDto>>(DataProvider.Authors);
        }

        public IEnumerable<AuthorDto> GetAuthorsByNewsItemId(int id){

            var authorIds = DataProvider.NewsItemAuthors.Where(x => x.NewsItemId == id).ToList();
            var authors = new List<Author>();

            foreach(var item in authorIds){
                authors.Add(DataProvider.Authors.FirstOrDefault(x => x.Id == item.AuthorId));
            }
            
            return _mapper.Map<IEnumerable<AuthorDto>>(authors);
        }

        public AuthorDetailDto GetAuthorById(int id)
        {
            return _mapper.Map<AuthorDetailDto>(DataProvider.Authors.FirstOrDefault(c => c.Id == id));
        }
    }
}