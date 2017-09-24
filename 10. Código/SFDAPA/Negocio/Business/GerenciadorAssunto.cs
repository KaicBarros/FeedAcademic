using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Models;
using Persistencia.Persistence;

namespace Negocio.Business
{
    public class GerenciadorAssunto
    {
        private AssuntoPersistencia persistencia;

        public GerenciadorAssunto()
        {
            persistencia = new AssuntoPersistencia();
        }

        public Assunto Adicionar(Assunto assunto)
        {
            persistencia.Adicionar(assunto);
            return assunto;
        }

        public void Editar(Assunto assunto)
        {
            persistencia.Editar(assunto);
        }

        public void Remover(Assunto assunto)
        {
            persistencia.Remover(assunto);
        }

        public Assunto Obter(int codigo)
        {
            return persistencia.Obter(a => a.Codigo == codigo);
        }

        public List<Assunto> ObterTodos()
        {
            return persistencia.ObterTodos();
        }
    }
}
