using ARG.Dominio;
using ARG.Infraestrutura.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace ARG.Apresentacao.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NiveisController : ControllerBase
    {
        private readonly INiveisRepository _repository;

        public NiveisController(INiveisRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_repository.GetAll());
        }

        public async Task<IActionResult> Post(Niveis niveis)
        {
            try
            {
                await _repository.Add(niveis);
                return StatusCode(201);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }

        }
    }
}
