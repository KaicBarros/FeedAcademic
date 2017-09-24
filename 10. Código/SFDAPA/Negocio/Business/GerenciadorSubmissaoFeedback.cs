using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Models;
using Persistencia.Persistence;

namespace Negocio.Business
{
    public class GerenciadorSubmissaoFeedback
    {
        private SubmissaoFeedbackPersistencia persistencia;

        public GerenciadorSubmissaoFeedback()
        {
            persistencia = new SubmissaoFeedbackPersistencia();
        }

        public SubmissaoFeedback Adicionar(SubmissaoFeedback submissaoFeedback)
        {
            persistencia.Adicionar(submissaoFeedback);
            return submissaoFeedback;
        }

        public void Editar(SubmissaoFeedback submissaoFeedbback)
        {
            persistencia.Editar(submissaoFeedbback);
        }

        public void Remover(SubmissaoFeedback submissaoFeedback)
        {
            persistencia.Remover(submissaoFeedback);
        }

        public SubmissaoFeedback Obter(int id)
        {
            return persistencia.Obter(e => e.Codigo == id);
        }

        public List<SubmissaoFeedback> ObterTodos()
        {
            return persistencia.ObterTodos();
        }
    }
}