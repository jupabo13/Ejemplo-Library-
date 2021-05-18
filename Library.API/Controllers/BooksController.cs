using AutoMapper;
using Contracts;
using Entities;
using Entities.DTO;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Library.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public BooksController(IRepositoryManager repositoryManager, ILoggerManager logger, IMapper mapper)
        {
            this._repositoryManager = repositoryManager;
            this._logger = logger;
            this._mapper = mapper;
        }

        // GET: api/<BooksController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BookWithAuthorsDTO>>> Get()
        {            
            var books = await _repositoryManager.Book.GetAllBooksWithAuthorsAsync();
            var booksWithAuthorsDTO = _mapper.Map<IEnumerable<BookWithAuthorsDTO>>(books);
            return Ok(booksWithAuthorsDTO);
        }


        // GET api/<BooksController>/5
        [HttpGet("{publicationId}", Name = "GetBookById")]
        public async Task<ActionResult<BookWithAuthorsDTO>> Get(int publicationId)
        {
            var book = await _repositoryManager.Book.GetBookByIdAsync(publicationId);
            if (book == null)
            {
                _logger.LogInfo($"Book with publicationId: {publicationId} doesn't exist in the database.");
                return NotFound();
            }
            else
            {
                var bookWithAuthorsDTO = _mapper.Map<BookWithAuthorsDTO>(book);
                return Ok(bookWithAuthorsDTO);
            }
        }



        [HttpGet("/api/Authors/{authorId}/Books/{publicationId}", Name = "GetBookForAuthor")]
        
        public async Task<ActionResult<BookWithAuthorsDTO>> Get(int publicationId, int authorId)
        {
            var authorIdBookId = await _repositoryManager.Author.ValidateAuthorWithPublication(authorId, publicationId);
            if (authorIdBookId == null)
            {
                _logger.LogInfo($"Author or Book with publicationId: {authorId} or {publicationId} doesn't exist in the database.");
                return NotFound();
            }
            var bookDB = await _repositoryManager.Book.GetBookByAuthorIdAndPublicationId(authorId, publicationId);
            if (bookDB == null)
            {
                _logger.LogInfo($"Book with publicationId: {publicationId} doesn't exist in the database.");
                return NotFound();
            }

            var bookDTO = _mapper.Map<BookWithAuthorsDTO>(bookDB);

            return Ok(bookDTO);
        }


     
        [HttpPost("/api/Authors/{authorId}/Books", Name = "CreateBookForAuthor")]
       public async Task<ActionResult> Post([FromBody] BookForCreationDTO bookForCreationDTO, int authorId)
        {
            if (bookForCreationDTO == null)
            {
                _logger.LogError("bookForCreationDTO object sent from client is null.");
                return BadRequest("EmployeeForCreationDto object is null");
            }

            /* Falta validar que el libro no exista previamente */

            var author = await _repositoryManager.Author.GetAuthorByIdWithBooksAsync(authorId); 
            
            if (author == null)
            {
                _logger.LogInfo($"Author with publicationId: {authorId} doesn't exist in the database.");
                return NotFound();
            }
            var book = _mapper.Map<Book>(bookForCreationDTO);

            _repositoryManager.Book.CreateBookForAuthor(author, book);
           await _repositoryManager.SaveAsync();

            var bookToReturn = _mapper.Map<BookReturnCreateDTO>(book);

            return CreatedAtRoute("GetBookForAuthor", new {authorId, publicationId = bookToReturn.PublicationId }, bookToReturn);
        }

        [HttpPost(Name = "CreateBookWithAuthors")]
        public async Task<ActionResult> Post([FromBody] BookForCreationWithListIdsAuthorsDTO bookForCreationWithListIdsAuthorsDTO)
        {
            if (bookForCreationWithListIdsAuthorsDTO == null)
            {
                _logger.LogError("bookForCreationDTO object sent from client is null.");
                return BadRequest("EmployeeForCreationDto object is null");
            }

            /* Falta validar que el libro no exista previamente */

            List<Author> authors = await _repositoryManager.Author.GetAuthorsByIdsAsync(bookForCreationWithListIdsAuthorsDTO.AuthorsIds);

            if (authors == null)
            {
                _logger.LogInfo($"Author with publicationId: {authors} doesn't exist in the database.");
                return NotFound();
            }
            var book = _mapper.Map<Book>(bookForCreationWithListIdsAuthorsDTO);

            _repositoryManager.Book.CreateBookForAuthor(authors, book);
            await _repositoryManager.SaveAsync();
            var bookToReturn = _mapper.Map<BookReturnForCreationWithListIdsAuthorsDTO>(book);

            return CreatedAtRoute("GetBookById", new { publicationId = bookToReturn.PublicationId }, bookToReturn);
        }



        // PUT api/<BooksController>/5
        [HttpPut("{publicationId}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BooksController>/5
        [HttpDelete("{publicationId}")]
        public void Delete(int id)
        {
        }
    }
}
