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
            return Ok(_projetoRepository.Listar());
        }
    }
}