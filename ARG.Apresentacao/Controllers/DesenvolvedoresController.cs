using ARG.Dominio;
using ARG.Infraestrutura.Interfaces;
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
            return Ok(_repository.Buscar());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_repository.Buscar(id));
        }

        [HttpPost]
        public IActionResult Post(Desenvolvedores desenvolvedores)
        {
            try
            {
                _repository.Adicionar(desenvolvedores);

                return StatusCode(201);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }

        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            try
            {
                _repository.Excluir(id);
                return StatusCode(204);
            }
            catch (Exception ex)
            {
                return StatusCode(400, ex.Message);
            }

        }
        [HttpPut]
        public IActionResult Put(Desenvolvedores desenvolvedores)
        {
            try
            {
                _repository.Atualizar(desenvolvedores.Id, desenvolvedores);
                return StatusCode(200);
            }
            catch (Exception ex)
            {
                return StatusCode(400, ex.Message);
            }

        }
    }
}
