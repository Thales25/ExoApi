using Exo.WebApi.Contexts;
using Exo.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exo.WebApi.Repositores
{
    public class projetosRepository
    {
        private readonly ExoContext _context;
        public projetosRepository(ExoContext context)
        {
            _context = context;
        }
        public List<projetos> Listar ()
        {
            return _context.projetos.ToList();
        }
    }
}