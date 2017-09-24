using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Models;

namespace Persistencia.Persistence
{
    public class FeedbackAssuntoPersistencia
    {
        private static List<FeedbackAssunto> listaFeedbackAssuntos;

        static FeedbackAssuntoPersistencia()
        {
            listaFeedbackAssuntos = new List<FeedbackAssunto>();
        }

        public FeedbackAssunto Adicionar(FeedbackAssunto feedbackAssunto)
        {
            feedbackAssunto.Codigo = listaFeedbackAssuntos.Count + 1;
            listaFeedbackAssuntos.Add(feedbackAssunto);
            return feedbackAssunto;
        }

        public void Editar(FeedbackAssunto feedbackAssunto)
        {
            int posicao = listaFeedbackAssuntos.FindIndex(f => f.Codigo == feedbackAssunto.Codigo);
            listaFeedbackAssuntos[posicao] = feedbackAssunto;
        }

        public void Remover(FeedbackAssunto feedbackAssunto)
        {
            int posicao = listaFeedbackAssuntos.FindIndex(f => f.Codigo == feedbackAssunto.Codigo);
            listaFeedbackAssuntos.RemoveAt(posicao);
        }

        public FeedbackAssunto Obter(Func<FeedbackAssunto, bool> Where)
        {
            return listaFeedbackAssuntos.Where(Where).FirstOrDefault();
        }

        public List<FeedbackAssunto> ObterTodos()
        {
            return listaFeedbackAssuntos;
        }
    }
}
