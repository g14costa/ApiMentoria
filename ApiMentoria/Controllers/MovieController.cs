using Core.Entities;
using Core.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiMentoria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieService _service;

        public MovieController(IMovieService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("GetMovies")]
        public async Task<IEnumerable<Movie>> GetMovies()
        {
            return await _service.FindAllAsync();
        }

        // GET api/<MovieController>/5
        [HttpGet("{id}")]
        public Task<Movie> Get(int id)
        {
            return _service.FindAsync(id);
        }

        // POST api/<MovieController>
        [HttpPost]
        public async Task<string> Create([FromBody] Movie movie)
        {
            await _service.AddAsync(movie);
            return "Movie created successfully";
        }

        // PUT api/<MovieController>/5
        [HttpPut("{id}")]
        public bool Update([FromBody] Movie movie)
        {
            return _service.Update(movie);
        }

        // DELETE api/<MovieController>/5
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            return _service.Remove(id);
        }
    }
}
