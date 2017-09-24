using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Models;
using Persistencia.Persistence;

namespace Negocio.Business
{
    public class GerenciadorProfessor
    {
        private ProfessorPersistencia persistencia;

        public GerenciadorProfessor()
        {
            persistencia = new ProfessorPersistencia();
        }

        public Professor Adicionar(Professor professor)
        {
            persistencia.Adicinoar(professor);
            return professor;
        }
        
        public void Editar(Professor professor)
        {
            persistencia.Editar(professor);
        }
        
        public void Remover(Professor professor)
        {
            persistencia.Remover(professor);
        }

        public Professor Obter(int id)
        {
            return persistencia.Obter(e => e.Codigo == id);
        }

        public List<Professor> ObterTodos()
        {
            return persistencia.ObterTodos();
        }
    }
}
