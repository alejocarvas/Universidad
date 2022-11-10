using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Universidad.Data.Model;
using Universidad.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Universidad.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SemestreController : ControllerBase
    {
        private readonly ISemestreService _semestreService;
        public SemestreController(ISemestreService estudianteService)
        {
            _semestreService = estudianteService;
        }

        // GET: api/<SemestreController>
        [HttpGet]
        public async Task<ActionResult<List<Semestre>>> Get()
        {
            var semestres = await _semestreService.Get();
            return Ok(semestres);
        }

        // GET api/<SemestreController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Semestre>> Get(int id)
        {
            var semestre = await _semestreService.GetById(id);
            return Ok(semestre);
        }

        // POST api/<SemestreController>
        [HttpPost]
        public async Task<ActionResult<int>> Post(Semestre semestre)
        {
            var semestreId = await _semestreService.Post(semestre);
            return Ok(semestreId);
        }

        // PUT api/<SemestreController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<int>> Put(int id, Semestre semestre)
        {
            var semestreId = await _semestreService.Put(semestre);
            return Ok(semestreId);
        }

        // DELETE api/<SemestreController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
