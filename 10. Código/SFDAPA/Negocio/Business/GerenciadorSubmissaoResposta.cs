using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Models;
using Persistencia.Persistence;

namespace Negocio.Business
{
    public class GerenciadorSubmissaoResposta
    {
        private SubmissaoRespostaPersistencia persistencia;

        public GerenciadorSubmissaoResposta()
        {
            persistencia = new SubmissaoRespostaPersistencia();
        }

        public SubmissaoResposta Adicionar(SubmissaoResposta submissaoResposta)
        {
            persistencia.Adicionar(submissaoResposta);
            return submissaoResposta;
        }

        public void Editar(SubmissaoResposta submissaoResposta)
        {
            persistencia.Editar(submissaoResposta);
        }

        public void Remover(SubmissaoResposta submissaoResposta)
        {
            persistencia.Remover(submissaoResposta);
        }

        public SubmissaoResposta Obter(int id)
        {
            return persistencia.Obter(e => e.Codigo == id);
        }

        public List<SubmissaoResposta> ObterTodos()
        {
            return persistencia.ObterTodos();
        }
    }
}
