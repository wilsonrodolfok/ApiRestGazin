using ARG.Dominio;
using ARG.Infraestrutura.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace ARG.Apresentacao.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DesenvolvedoresController : ControllerBase
    {
        private readonly IDesenvolvedoresRepository _repository;

        public DesenvolvedoresController(IDesenvolvedoresRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_repository.GetAll());
        }

        public async Task<IActionResult> Post(Desenvolvedores desenvolvedores)
        {
            try
            {
                await _repository.Add(desenvolvedores);
                return StatusCode(201);
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }

        }
    }
}
