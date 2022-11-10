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
    public class MateriaController : ControllerBase
    {
        private readonly IMateriaService _materiaService;
        public MateriaController(IMateriaService materiaService)
        {
            _materiaService = materiaService;
        }


        [HttpGet]
        public async Task<ActionResult<List<Materia>>> GetAll()
        {
            var materias = await _materiaService.Get();
            return Ok(materias);
        }

        [HttpGet("id")]
        public async Task<ActionResult<Materia>> GetById(int id)
        {
            var materia = await _materiaService.GetById(id);
            return Ok(materia);
        }

        [HttpPost]
        public async Task<ActionResult> Post(Materia materia)
        {
            var materiaId = await _materiaService.Post(materia);
            return Ok(materiaId);
        }
    }
}
