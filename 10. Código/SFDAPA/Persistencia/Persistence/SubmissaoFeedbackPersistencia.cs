using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Models;

namespace Persistencia.Persistence
{
    public class SubmissaoFeedbackPersistencia
    {
        private static List<SubmissaoFeedback> listaSubmissaoFeedback;

        static SubmissaoFeedbackPersistencia()
        {
            listaSubmissaoFeedback = new List<SubmissaoFeedback>();
        }

        public SubmissaoFeedback Adicionar(SubmissaoFeedback SubmissaoFeedback)
        {
            SubmissaoFeedback.Codigo = listaSubmissaoFeedback.Count + 1;
            listaSubmissaoFeedback.Add(SubmissaoFeedback);
            return SubmissaoFeedback;
        }

        public void Editar(SubmissaoFeedback SubmissaoFeedback)
        {
            int posicao = listaSubmissaoFeedback.FindIndex(sf => sf.Codigo == SubmissaoFeedback.Codigo);
            listaSubmissaoFeedback[posicao] = SubmissaoFeedback;
        }

        public void Remover(SubmissaoFeedback SubmissaoFeedback)
        {
            int posicao = listaSubmissaoFeedback.FindIndex(sf => sf.Codigo == SubmissaoFeedback.Codigo);
            listaSubmissaoFeedback.RemoveAt(posicao);
        }

        public SubmissaoFeedback Obter(Func<SubmissaoFeedback, bool> where)
        {
            return listaSubmissaoFeedback.Where(where).FirstOrDefault();
        }

        public List<SubmissaoFeedback> ObterTodos()
        {
            return listaSubmissaoFeedback;
        }
    }
}