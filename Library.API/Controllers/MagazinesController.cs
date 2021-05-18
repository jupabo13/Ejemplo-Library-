using AutoMapper;
using Contracts;
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
    public class MagazinesController : ControllerBase
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public MagazinesController(IRepositoryManager repositoryManager, ILoggerManager logger, IMapper mapper)
        {
            this._repositoryManager = repositoryManager;
            this._logger = logger;
            this._mapper = mapper;
        }

        // GET: api/<MagazinesController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MagazineDTO>>> Get()
        {
                var magazines = await _repositoryManager.Magazine.GetAllMagazineAsync(filter: null, orderBy: x => x.OrderBy(a => a.Name), includeProperties: null, trackChanges: false);
                var magazineDTO = _mapper.Map<IEnumerable<MagazineDTO>>(magazines);
                return Ok(magazineDTO);
        }

        // GET api/<MagazinesController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MagazineDTO>> Get(int id)
        {
            var magazine = await _repositoryManager.Magazine.GetMagazineByIdAsync(id);
            if (magazine == null)
            {
                _logger.LogInfo($"Magazine with id: {id} doesn't exist in the database.");
                return NotFound();
            }
            else
            {
                var magazineDTO = _mapper.Map<MagazineDTO>(magazine);
                return Ok(magazineDTO);
            }
        }

        // POST api/<MagazinesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<MagazinesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MagazinesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
