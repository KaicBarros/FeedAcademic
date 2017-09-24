using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Models;
using Persistencia.Persistence;

namespace Negocio.Business
{
    public class GerenciadorAlternativa
    {
        public AlternativaPersistencia persistencia;

        public GerenciadorAlternativa()
        {
            persistencia = new AlternativaPersistencia();
        }

        public Alternativa Adicionar(Alternativa alternativa)
        {
            persistencia.Adicionar(alternativa);
            return alternativa;
        }

        public void Editar(Alternativa alternativa)
        {
            persistencia.Editar(alternativa);
        }

        public void Remover(Alternativa alternativa)
        {
            persistencia.Remover(alternativa);
        }

        public Alternativa Obter(int codigo)
        {
            return persistencia.Obter(a => a.Codigo == codigo);
        }

        public List<Alternativa> ObterTodos()
        {
            return persistencia.ObterTodos();
        }
    }
}
