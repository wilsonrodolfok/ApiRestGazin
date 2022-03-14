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
            return Ok(_repository.Buscar());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_repository.Buscar(id));
        }

        [HttpPost]
        public IActionResult Post(Niveis niveis)
        {
            try
            {
                _repository.Adicionar(niveis);
                
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
                if (ex.Message.Substring(0,7) == "Existem")
                    return StatusCode(501, ex.Message);  
                return StatusCode(400, ex.Message);
            }

        }
        [HttpPut]
        public IActionResult Put(Niveis niveis)
        {
            try
            {
                _repository.Atualizar(niveis.Id, niveis);
                return StatusCode(200);
            }
            catch (Exception ex)
            {
                return StatusCode(400, ex.Message);
            }

        }
    }
}
