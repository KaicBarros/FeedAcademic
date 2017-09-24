using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Models;

namespace Persistencia.Persistence
{
    public class SubmissaoRespostaPersistencia
    {
        private static List<SubmissaoResposta> listaSubmissaoResposta;

        static SubmissaoRespostaPersistencia()
        {
            listaSubmissaoResposta = new List<SubmissaoResposta>();
        }

        public SubmissaoResposta Adicionar(SubmissaoResposta SubmissaoResposta)
        {
            SubmissaoResposta.Codigo = listaSubmissaoResposta.Count + 1;
            listaSubmissaoResposta.Add(SubmissaoResposta);
            return SubmissaoResposta;
        }

        public void Editar(SubmissaoResposta SubmissaoResposta)
        {
            int posicao = listaSubmissaoResposta.FindIndex(sr => sr.Codigo == SubmissaoResposta.Codigo);
            listaSubmissaoResposta[posicao] = SubmissaoResposta;
        }

        public void Remover(SubmissaoResposta SubmissaoResposta)
        {
            int posicao = listaSubmissaoResposta.FindIndex(sr => sr.Codigo == SubmissaoResposta.Codigo);
            listaSubmissaoResposta.RemoveAt(posicao);
        }

        public SubmissaoResposta Obter(Func<SubmissaoResposta, bool> where)
        {
            return listaSubmissaoResposta.Where(where).FirstOrDefault();
        }

        public List<SubmissaoResposta> ObterTodos()
        {
            return listaSubmissaoResposta;
        }

    }
}
