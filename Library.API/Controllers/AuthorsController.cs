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
    public class AuthorsController : ControllerBase
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public AuthorsController(IRepositoryManager repositoryManager, ILoggerManager logger, IMapper mapper)
        {
            this._repositoryManager = repositoryManager;
            this._logger = logger;
            this._mapper = mapper;
        }
        // GET: api/<AuthorsController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AuthorDTO>>> Get()
        {
            var authors = await _repositoryManager.Author.GetAllAuthorsWithBooksAsync();
            var authorsDTO = _mapper.Map<IEnumerable<AuthorDTO>>(authors);            
            return Ok(authorsDTO);
        }       

        // GET api/<AuthorsController>/5
        [HttpGet("{id}", Name = "AuthorById")]
        public async Task<ActionResult<AuthorDTO>> Get(int id)
        {
           var authorBook = await _repositoryManager.Author.GetAuthorByIdWithBooksAsync(id);

            if (authorBook == null)
            {
                _logger.LogInfo($"Author with id: {id} doesn't exist in the database.");
                return NotFound();
            }
            else
            {
                var authorDTO = _mapper.Map<AuthorDTO>(authorBook);
                return Ok(authorDTO);
            }
        }

        // GET api/<AuthorsController>/5
        [HttpGet("/api/Books/{publicationId}/Authors/{authorId}", Name = "AuthorByIdWithBookId")]
        public async Task<ActionResult<AuthorDTO>> Get(int authorId, int publicationId)
        {
            var authorIdBookId = await _repositoryManager.Author.ValidateAuthorWithPublication(authorId, publicationId);
            if (authorIdBookId== null)
            {
                _logger.LogInfo($"Author or Book with id: {authorId} or {publicationId} doesn't exist in the database.");
                return NotFound();
            }
            else
            {
                var authorBook = await _repositoryManager.Author.GetAuthorByIdWithBookIdAsync(publicationId, authorId);
                var authorDTO = _mapper.Map<AuthorDTO>(authorBook);
                return Ok(authorDTO);
            }
        }


        // POST api/<AuthorsController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] AuthorForCreationDTO authorForCreationDTO)
        {
            if (authorForCreationDTO == null)
            {
                _logger.LogError("authorForCreationDTO object send from client is null");
                return BadRequest("authorForCreationDTO object is null");
            }

            var author = _mapper.Map<Author>(authorForCreationDTO);
            _repositoryManager.Author.CreateAuthor(author);
            await _repositoryManager.SaveAsync();

            var authorToReturn = _mapper.Map<AuthorReturnCreateDTO>(author);
            return CreatedAtRoute("AuthorById", new { id = authorToReturn.AuthorId }, authorToReturn);
        }

        // PUT api/<AuthorsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AuthorsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
