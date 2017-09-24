using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Models;
using Persistencia.Persistence;

namespace Negocio.Business
{
    public class GerenciadorAluno
    {
        private AlunoPersistencia persistencia;

        public GerenciadorAluno()
        {
            persistencia = new AlunoPersistencia();
        }

        public Aluno Adicionar(Aluno aluno)
        {
            persistencia.Adicionar(aluno);
            return aluno;
        } 

        public void Editar(Aluno aluno)
        {
            persistencia.Editar(aluno);
        }

        public void Remover(Aluno aluno)
        {
            persistencia.Remover(aluno);
        }

        public Aluno Obter(int codigo)
        {
            return persistencia.Obter(a => a.Codigo == codigo);
        }

        public List<Aluno> ObterTodos()
        {
            return persistencia.ObterTodos();
        }
    }
}
