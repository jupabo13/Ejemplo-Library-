using Microsoft.VisualStudio.TestTools.UnitTesting;
using Library.API.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using Contracts;
using Entities;

using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using LoggerService;

using Entities.DTO;
using Library.API.AutoMapper;

namespace Library.API.Controllers.Tests
{
    [TestClass()]
    public class AuthorsControllerTests
    {
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public AuthorsControllerTests()
        {
            this._logger = new LoggerManager();
            if (_mapper == null)
            {
                var mappingConfig = new MapperConfiguration(mc =>
                {
                    mc.AddProfile(new MappingProfile());
                });
                IMapper mapper = mappingConfig.CreateMapper();
                _mapper = mapper;
            }           
        }
       

        [TestMethod()]
        public async Task Get_SiElAutorNoExiste_SeNosRetornaUn404Async()
        {
            // Preparar
            var idAutor = 130;
            var mock = new Mock<IRepositoryManager>();
            mock.Setup(x => x.Author.GetAuthorByIdWithBooksAsync(idAutor)).ReturnsAsync(default(Author));
            var authoresController = new AuthorsController(mock.Object, _logger, _mapper);

            //Actuar
            var resultado = await authoresController.Get(idAutor);

            // Assert
            Assert.IsInstanceOfType(resultado.Result, typeof(NotFoundResult));
        }


        //[TestMethod]
        //public async Task Get_SiElAutorExiste_SeNosRetornaElAutorAsync()
        //{

        //    // Preparación
        //    var authorMock = new Author
        //    {
        //        AuthorId = 13,
        //        FirstName = "German",
        //        LastName = "Castro Caicedo",
        //        NationalityId = 4,
        //        Nationality = new Nationality
        //        {
        //            NationalityId = 4,
        //            NationalityName = "Algerian",
        //            CountryCode = "DZ",
        //            State = true
        //        }                
        //    };

         

        //    var mock = new Mock<IRepositoryManager>();
        //    mock.Setup(x => x.Author.GetAuthorByIdWithBooksAsync(authorMock.AuthorId)).ReturnsAsync(authorMock);
           
        //    var autoresController = new AuthorsController(mock.Object, _logger, _mapper);

        //    // Prueba
        //    var resultado =await autoresController.Get(authorMock.AuthorId);

        //    // Verificación
        
        //    Assert.IsNotNull(resultado.Value);
        //    Assert.AreEqual(resultado.Value.AuthorId, authorMock.AuthorId);
        //    Assert.AreEqual(resultado.Value.FullName, authorMock.FirstName+" "+authorMock.LastName);
        //}
    }
}