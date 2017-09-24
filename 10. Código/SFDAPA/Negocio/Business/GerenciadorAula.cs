using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Models;
using Persistencia.Persistence;

namespace Negocio.Business
{
    public class GerenciadorAula
    {
        private AulaPersistencia persistencia;

        public GerenciadorAula()
        {
            persistencia = new AulaPersistencia();
        }

        public Aula Adicionar(Aula aula)
        {
            persistencia.Adicionar(aula);
            return aula;
        }

        public void Editar(Aula aula)
        {
            persistencia.Editar(aula);
        }

        public void Remover(Aula aula)
        {
            persistencia.Remover(aula);
        }

        public Aula Obter(int codigo)
        {
            return persistencia.Obter(a => a.Codigo == codigo);
        }

        public List<Aula> ObterTodos()
        {
            return persistencia.ObterTodos();
        }
    }
}
