using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Universidad.Data.Model;
using Universidad.Service;

namespace Universidad.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstudianteController : ControllerBase
    {
        private readonly IEstudianteService _estudianteService;
        public EstudianteController(IEstudianteService estudianteService)
        {
            _estudianteService = estudianteService;
        }


        [HttpGet]
        public async Task<ActionResult<List<Estudiante>>> GetAll()
        {
            var estudantes = await _estudianteService.Get();
            return Ok(estudantes);
        }

        [HttpGet("id")]
        public async Task<ActionResult<Estudiante>> GetById(int id)
        {
            var estudante = await _estudianteService.GetById(id);
            return Ok(estudante);
        }

        [HttpPost]
        public async Task<ActionResult> Post(Estudiante estudiante)
        {
            var estudiateId = await _estudianteService.Post(estudiante);
            return Ok(estudiateId);
        }
    }
}
