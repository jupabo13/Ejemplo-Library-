using AutoMapper;
using Entities;
using Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.API.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            /* Authors */
            CreateMap<Author, AuthorDTO>()
                .ForMember(a => a.FullName, opt => opt.MapFrom(a => string.Join(' ', a.FirstName, a.LastName)))
                .ForMember(a => a.Nationality, opt => opt.MapFrom(a => a.Nationality.NationalityName))
                .ForMember(dto => dto.Book, opt => opt.MapFrom(x => x.AuthorBooks.Select(ab => ab.Book).ToList()));

            CreateMap<Author, AuthorsForBookDTO>()
                .ForMember(a => a.FullName, opt => opt.MapFrom(a => string.Join(' ', a.FirstName, a.LastName)))
                .ForMember(a => a.Nationality, opt => opt.MapFrom(a => a.Nationality.NationalityName));

            CreateMap<AuthorForCreationDTO, Author>();

            CreateMap<Author, AuthorReturnCreateDTO>();

            /* Books */
            CreateMap<Book, BookDTO>()
                .ForMember(a => a.Publisher, opt => opt.MapFrom(a => a.Publisher.PublisherName))
                .ForMember(a => a.Format, opt => opt.MapFrom(a => a.Format.FormatName));

            CreateMap<Book, BookWithAuthorsDTO>()   
                .ForMember(dto => dto.Author, opt => opt.MapFrom(x => x.AuthorsBook.Select(ab => ab.Author)))
                .ForMember(a => a.Publisher, opt => opt.MapFrom(a => a.Publisher.PublisherName))
                .ForMember(a => a.Format, opt => opt.MapFrom(a => a.Format.FormatName));

            CreateMap<BookForCreationDTO, Book>();

            CreateMap<BookForCreationWithListIdsAuthorsDTO, Book>();

            CreateMap<Book, BookReturnCreateDTO>();

            CreateMap<Book, BookReturnForCreationWithListIdsAuthorsDTO>()
                .ForMember(dto => dto.Authors, opt => opt.MapFrom(x => x.AuthorsBook.Select(ab => ab.Author.AuthorId)));

            /* Magazines */
            CreateMap<Magazine, MagazineDTO>();
        }
    }
}
