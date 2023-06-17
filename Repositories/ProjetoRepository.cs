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

        //codigo novo que compila o CRUD
        public void Cadastrar(projetos projeto)
            {
                 _context.projetos.Add(projeto);
                 _context.SaveChanges();
            }
        public projetos BuscarporId(int id)
            {
                return _context.projetos.Find(id);
            }
            public void Atualizar(int id, projetos projeto)
                {
                    projetos projetoBuscado = _context.projetos.Find(id);
                    if (projetoBuscado != null)
                {
                    projetoBuscado.NomeDoProjeto = projeto.NomeDoProjeto;
                    projetoBuscado.Area = projeto.Area;
                    projetoBuscado.Status = projeto.Status;
                }
                    _context.projetos.Update(projetoBuscado);
                    _context.SaveChanges();
                }
            public void Deletar(int id)
                {
                    projetos projetoBuscado = _context.projetos.Find(id);
                    _context.projetos.Remove(projetoBuscado);
                    _context.SaveChanges();
                }

    }   
}