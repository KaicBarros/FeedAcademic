using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Models;
using Persistencia.Persistence;

namespace Negocio.Business
{
    public class GerenciadorFeedbackAssunto
    {
        private FeedbackAssuntoPersistencia persistencia;

        public GerenciadorFeedbackAssunto()
        {
            persistencia = new FeedbackAssuntoPersistencia();
        }

        public FeedbackAssunto Adicionar(FeedbackAssunto feedbackAssunto)
        {
            persistencia.Adicionar(feedbackAssunto);
            return feedbackAssunto;
        }

        public void Editar(FeedbackAssunto feedbackAssunto)
        {
            persistencia.Editar(feedbackAssunto);
        }

        public void Remover(FeedbackAssunto feedbackAssunto)
        {
            persistencia.Remover(feedbackAssunto);
        }

        public FeedbackAssunto Obter(int codigo)
        {
            return persistencia.Obter(f => f.Codigo == codigo);
        }

        public List<FeedbackAssunto> ObterTodos()
        {
            return persistencia.ObterTodos();
        }
    }
}
