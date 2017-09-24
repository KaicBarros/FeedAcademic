using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Models;
using Persistencia.Persistence;

namespace Negocio.Business
{
    public class GerenciadorAnalise
    {
        private AnalisePersistencia persistencia;

        public GerenciadorAnalise()
        {
            persistencia = new AnalisePersistencia();
        }

        public Analise Adicionar(Analise analise)
        {
            persistencia.Adicionar(analise);
            return analise;
        }

        public void Editar(Analise analise)
        {
            persistencia.Editar(analise); 
        }

        public void Remover(Analise analise)
        {
            persistencia.Remover(analise);
        }

        public Analise Obter(int codigo)
        {
            return persistencia.Obter(a => a.Codigo == codigo);
        }

        public List<Analise> ObterTodos()
        {
            return persistencia.ObterTodos();
        }
    }
}
