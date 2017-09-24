using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Models;

namespace Persistencia.Persistence
{
    public class PerguntaFeedbackPersistencia
    {
        private static List<PerguntaFeedback> listaPerguntasFeedback;

        static PerguntaFeedbackPersistencia()
        {
            listaPerguntasFeedback = new List<PerguntaFeedback>();
        }

        public PerguntaFeedback Adicionar(PerguntaFeedback perguntaFeedback)
        {
            perguntaFeedback.Codigo = listaPerguntasFeedback.Count + 1;
            listaPerguntasFeedback.Add(perguntaFeedback);
            return perguntaFeedback;
        }

        public void Editar(PerguntaFeedback perguntaFeedback)
        {
            int posicao = listaPerguntasFeedback.FindIndex(p => p.Codigo == perguntaFeedback.Codigo);
            listaPerguntasFeedback[posicao] = perguntaFeedback;
        }

        public void Remover(PerguntaFeedback perguntaFeedback)
        {
            int posicao = listaPerguntasFeedback.FindIndex(p => p.Codigo == perguntaFeedback.Codigo);
            listaPerguntasFeedback.RemoveAt(posicao);
        }

        public PerguntaFeedback Obter(Func<PerguntaFeedback, bool> where)
        {
            return listaPerguntasFeedback.Where(where).FirstOrDefault();
        }

        public List<PerguntaFeedback> ObterTodos()
        {
            return listaPerguntasFeedback;
        }

    }
}
