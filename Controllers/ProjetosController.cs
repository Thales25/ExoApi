using Exo.WebApi.Models;
using Exo.WebApi.Repositores;
using Microsoft.AspNetCore.Authorization;
using System;
using Microsoft.AspNetCore.Mvc;

namespace Exo.WebApi.Controllers
{
    [Route ("api/[controller]")]
    [ApiController]
    public class ProjetoController : ControllerBase
    {
        private readonly projetosRepository _projetoRepository;
        public ProjetoController(projetosRepository projetoRepository)
        {
            _projetoRepository = projetoRepository;

        }
        [HttpGet]
        public IActionResult Listar()
        {
            return Ok( _projetoRepository.Listar());
        }
        // Código novo que completa o CRUD.
        [HttpPost]
        public IActionResult Cadastrar(projetos projeto)
        {
            _projetoRepository.Cadastrar(projeto);
            return StatusCode(201);
        }
        [HttpGet("{id}")]
        public IActionResult BuscarPorId(int id)
        {
            projetos projeto = _projetoRepository.BuscarporId(id);
            if (projeto == null)
            {
                return NotFound();
            }
                return Ok(projeto);
        }
        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, projetos projeto)
        {
            _projetoRepository.Atualizar(id, projeto);
            return StatusCode(204);
        }
        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            try
            {
                _projetoRepository.Deletar(id);
                return StatusCode(204);
            }
                catch (Exception )
            {
            return BadRequest();
            }
        }


    }
}